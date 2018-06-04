using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data;

namespace GliderScoreMerge
{
    class GliderScoreZip
    {
        string ZipFileName;
        string mdbExtractedFileName;
        List<string> tempFileNames = new List<string>();

        public GliderScoreZip(string fileName)
        {
            ZipFileName = fileName;
            using (var zip = ZipFile.OpenRead(ZipFileName))
            {
                var mdbEntry = zip.Entries.First(x => x.Name == "GliderScoreData.mdb");
                mdbExtractedFileName = Path.GetTempFileName();
                tempFileNames.Add(mdbExtractedFileName);
                File.Delete(mdbExtractedFileName);
                mdbEntry.ExtractToFile(mdbExtractedFileName);
            }
        }

        ~GliderScoreZip()
        {
            foreach (string filename in tempFileNames)
            {
                File.Delete(filename);
            }
        }

        public DataTable GetTimerNames()
        {
            List<string> nameList = new List<string>();
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbExtractedFileName;
            string query = "SELECT * FROM TimerNames";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connString);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            return dTable;
        }
    }
}
