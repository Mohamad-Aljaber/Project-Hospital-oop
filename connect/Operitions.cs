using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal class Operitions
    {
        public static int getid(string filename)
        {
            int id = 0;
            FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fileStream);
            string lastline = "";
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lastline = line;
            }
            int lastid = Convert.ToInt32(lastline.Split(',')[0]);
            return lastid + 1;
        }
    }
}
