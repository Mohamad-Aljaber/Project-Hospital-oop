using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal class OpertioNnurse : INurse
    {
        //اضافة
        public void Addnurse(nurse nurse)
        {

            try
            {
                int new_Idpatients = Operitions.getid("nurse.txt");
                nurse.id = new_Idpatients;
                FileStream fs = new FileStream("nurse.txt", FileMode.Append, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(nurse.ToString());
                sr1.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");

            }
        }
        //حذف 
        public void Deletenurser(nurse nurse)
        {
            try
            {
                FileStream fileStream = new FileStream("nurse.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<nurse> nurses = new List<nurse>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (nurse.id.Equals(line))
                    {
                        nurses.RemoveAll(p => p.id == nurse.id);
                    }


                }
                fileStream.Close();
                sr.Close();


            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex}");
            }
        }
     

        //جلب البيانات
        public List<nurse> Getnurse()
        {
            int id = 0;
            FileStream fileStream = new FileStream("nurse.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fileStream);
            List<nurse> nurses = new List<nurse>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                nurses.Add(line);
                fileStream.Close();
                sr.Close();
            }
            return nurses;
        }
        //تعديل
        public void Updatenurse(nurse nurse)
        {
            try
            {
                List<string> lines = new List<string>();

                // قراءة البيانات من الملف
                using (StreamReader sr = new StreamReader("nurse.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == nurse.id.ToString())
                        {
                            // بدلاً من حذف السطر، يمكننا تعديله مباشرة
                            // يتم تجاوز البيانات بالبيانات الجديدة للمريض
                            line = $"{nurse.id},{nurse.first_name},{nurse.last_name},{nurse.adders},{nurse.age},{nurse.phon},{nurse.email},{nurse.gender},{nurse.blood_group},{nurse.sal},{nurse.namejob},{nurse.namedepartment},{nurse.specialty}";
                        }
                        lines.Add(line);
                    }
                }

                // كتابة البيانات المحدثة إلى الملف
                using (StreamWriter sw = new StreamWriter("patient.txt"))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

    }
}

