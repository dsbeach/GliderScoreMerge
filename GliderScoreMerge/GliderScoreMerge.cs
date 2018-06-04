using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    lZipFileName.Text = openFileDialog1.FileName;
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


                dgTimerNames.AutoGenerateColumns = false;
                dgTimerNames.DataSource = zip.GetTimerNames();
            }
        }

        private void dgTimerNames_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //TODO: check the existing timer names and update the button to 'Add' / 'Overwrite'
                DataGridViewButtonCell cell = (DataGridViewButtonCell)dgTimerNames[e.ColumnIndex, e.RowIndex];
                cell.Value = "Import";
            }
        }

        private void dgTimerNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                string name = ((DataTable)dgTimerNames.DataSource).Rows[e.RowIndex].Field<string>("TimerName");
                MessageBox.Show("Time to import " + name);
            }
        }

        private void GliderScoreMerge_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\GliderScore6"))
            {
                lGliderScoreDirectory.Text = "C:\\GliderScore6";
            }
        }

        private void bChangeGliderScoreDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Path.Combine(folderBrowserDialog1.SelectedPath, "GliderScoreData.mdb")))
                {
                    lGliderScoreDirectory.Text = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    MessageBox.Show(this, "Could not find GliderScoreData.mdb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
