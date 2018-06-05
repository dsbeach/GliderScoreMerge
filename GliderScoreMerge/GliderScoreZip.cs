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
using System.Windows.Forms;

namespace GliderScoreMerge
{
    class GliderScoreZip
    {
        string ZipFileName;
        string mdbExtractedFileName;
        GliderScoreMDB zipMDB;
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
                zipMDB = new GliderScoreMDB(mdbExtractedFileName);
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
            return zipMDB.GetTimerNames();
        }

        public DataTable GetTimerSettings(int timerNo)
        {
            return zipMDB.GetTimerSettings(timerNo);
        }

        public void ExtractAudioFile(string fileName, string destination)
        {
            if (fileName.Length == 0) { return; }
            try
            {
                using (ZipArchive zip = ZipFile.OpenRead(ZipFileName))
                {
                    ZipArchiveEntry audioFile = zip.Entries.First(x => x.FullName.EndsWith("Audio/" + fileName));
                    string qualifiedFileName = Path.Combine(destination, fileName);
                    if (File.Exists(qualifiedFileName))
                    {
                        File.Delete(qualifiedFileName);
                    }
                    audioFile.ExtractToFile(qualifiedFileName);
                }
            }
            catch
            {
                MessageBox.Show("Unable to extract file: " + fileName, "File skipped!");
            }
        }
    }
}
