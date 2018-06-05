using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GliderScoreMerge
{
    class GliderScoreDirectory
    {
        string gsRootPath;
        GliderScoreMDB directoryMDB;

        public GliderScoreDirectory(string path)
        {
            gsRootPath = path;
            directoryMDB = new GliderScoreMDB(Path.Combine(gsRootPath, "GliderScoreData.mdb"));
        }

        public bool ContainsTimer(string timerName)
        {
            return directoryMDB.ContainsTimer(timerName);
        }

        public void InsertTimerSettings(string timerName, DataTable timerSettings)
        {
            directoryMDB.InsertTimerSettings(timerName, timerSettings);
        }

    }
}
