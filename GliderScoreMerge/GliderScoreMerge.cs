using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GliderScoreMerge
{
    public partial class GliderScoreMerge : Form
    {
        GliderScoreZip zip;
        GliderScoreDirectory directory;

        public GliderScoreMerge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    // HACK HACK HACK - MICROSOFT BUG
                    // CHECK OUT https://www.telerik.com/forums/double-click-on-openfiledialog-is-raising-itemclick-event-on-radtreeview
                    dgTimerNames.Enabled = false;
                    zip = new GliderScoreZip(openFileDialog1.FileName);
                    tbInputZipFile.Text = openFileDialog1.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to process input file: " + openFileDialog1.FileName);
                }

                // NOW WAIT FOR THE ERRANT MOUSE UP EVENT TO BE CONSUMED
                System.Threading.Timer _bugTimer = new System.Threading.Timer(delegate
                {
                    dgTimerNames.Invoke((MethodInvoker)delegate
                   {
                       dgTimerNames.Enabled = true;
                   });
                }, null, 500, Timeout.Infinite);
                setDataSource();
            }
        }

        private void GliderScoreMerge_Load(object sender, EventArgs e)
        {
            dgTimerNames.AutoGenerateColumns = false;

            string inZip = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "GliderScore6.zip");
            if (File.Exists(inZip))
            {
                tbInputZipFile.Text = inZip;
                zip = new GliderScoreZip(inZip);
            }
            else { tbInputZipFile.Text = ""; }

            if (Directory.Exists("C:\\GliderScore6"))
            {
                tbOutputGliderScoreDirectory.Text = "C:\\GliderScore6";
                directory = new GliderScoreDirectory(tbOutputGliderScoreDirectory.Text);
            }
            else { tbOutputGliderScoreDirectory.Text = ""; }

            if (tbInputZipFile.Text != "" && tbOutputGliderScoreDirectory.Text != "")
            {
                setDataSource();
            }
        }

        private void setDataSource()
        {
            dgTimerNames.DataSource = null;
            DataTable table = zip.GetTimerNames();
            foreach (DataRow row in table.Rows)
            {
                if (!directory.ContainsTimer(row["TimerName"].ToString()))
                {
                    row["Checked"] = true;
                }
                else
                {
                    row["Checked"] = false;
                }
            }
            dgTimerNames.DataSource = table;
        }

        private void bChangeGliderScoreDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Path.Combine(folderBrowserDialog1.SelectedPath, "GliderScoreData.mdb")))
                {
                    tbOutputGliderScoreDirectory.Text = folderBrowserDialog1.SelectedPath;
                    directory = new GliderScoreDirectory(tbOutputGliderScoreDirectory.Text);
                }
                else
                {
                    MessageBox.Show(this, "Could not find GliderScoreData.mdb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgTimerNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex== 0 && e.RowIndex >= 0)
            {
                var senderGrid = (DataGridView)sender;
                DataRow row = ((DataTable)((DataGridView)sender).DataSource).Rows[e.RowIndex];
                row["Checked"] = !(bool)row["Checked"];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents(); // make sure the cursor updates
            DataTable timerNames = (DataTable)dgTimerNames.DataSource;
            foreach(DataRow row in timerNames.Rows)
            {
                if ((bool)row["Checked"] == true)
                {
                    Debug.WriteLine("Time to import:" + row["TimerName"].ToString() + " TimerNo:" + row["TimerNo"].ToString());
                    DataTable timerSettings = zip.GetTimerSettings((int)row["TimerNo"]);
                    directory.InsertTimerSettings(row["TimerName"].ToString(), timerSettings);
                    foreach (DataRow settingsRow in timerSettings.Rows)
                    {
                        zip.ExtractAudioFile(settingsRow["AnnouncementFileName"].ToString(), Path.Combine(tbOutputGliderScoreDirectory.Text, "Audio"));
                    }
                }
            }
            Cursor.Current = currentCursor;
            setDataSource(); // refresh the UI
        }
    }
}
