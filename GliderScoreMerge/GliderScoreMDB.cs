using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GliderScoreMerge
{
    class GliderScoreMDB
    {
        string connString;
        DataTable dtTimerNames;

        public GliderScoreMDB(string mdbPath)
        {
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath;
        }

        public DataTable GetTimerNames()
        {
            if (dtTimerNames == null)
            {
                dtTimerNames = new DataTable();
                string query = "SELECT * FROM TimerNames";
                using (OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connString))
                {
                    using (OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter))
                    {
                        dAdapter.Fill(dtTimerNames);
                    }
                }
                dtTimerNames.Columns.Add("Checked", typeof(bool));
                foreach (DataRow row in dtTimerNames.Rows)
                {
                    row["Checked"] = false;
                }

            }
            return dtTimerNames;
        }

        public bool ContainsTimer(string timerName)
        {
            bool result = false;
            IEnumerable<DataRow> timerNames = GetTimerNames().AsEnumerable().Where(r => r.Field<string>("TimerName") == timerName);
            if (timerNames.Count() > 0)
            {
                result = true;
            }
            return result;
        }

        public DataTable GetTimerSettings(int timerNo)
        {
            DataTable dtTimerSettings = new DataTable();
            string query = "SELECT * FROM TimerSettings where TimerNo = " + timerNo.ToString();
            using (OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connString))
            {
                using (OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter))
                {
                    dAdapter.Fill(dtTimerSettings);
                }
            }
            return dtTimerSettings;
        }

        public void InsertTimerSettings(string timerName, DataTable timerSettings)
        {
            DataRow maxTimerName = GetTimerNames().AsEnumerable().OrderByDescending(r => r.Field<int>("TimerNo")).FirstOrDefault();
            int nextTimerNo = (int)maxTimerName["TimerNo"] + 1;

            string sql = "INSERT INTO TimerNames(TimerNo, TimerName) VALUES (" + nextTimerNo.ToString() + ", \"" + timerName + "\")";
            // force a refresh of the timerNames since we did an insert!
            dtTimerNames = null;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                foreach (DataRow row in timerSettings.Rows)
                {
                    // insert the timersettings row
                    sql = "INSERT INTO TimerSettings(TimerNo,TimerTime,DisplayTime,AnnouncementDescription,AnnouncementFileName,BeepFreq,BeepDuration) VALUES (" +
                        nextTimerNo.ToString() + "," +
                        row["TimerTime"].ToString() + "," +
                        "\"" + row["DisplayTime"].ToString() + "\"," +
                        "\"" + row["AnnouncementDescription"].ToString() + "\"," +
                        "\"" + row["AnnouncementFileName"].ToString() + "\"," +
                        row["BeepFreq"].ToString() + "," +
                        row["BeepDuration"].ToString() +
                        ")";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }
    }
}
