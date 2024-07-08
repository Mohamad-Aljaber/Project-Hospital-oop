using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal class OpertionManger : IOpertionManger
    {
        //اضافة مدير
        public void AddManger(Manger manger)
        {
            try
            {
                int new_Idpatients = Operitions.getid("Manger.txt");
                manger.id = new_Idpatients;
                FileStream fs = new FileStream("Manger.txt", FileMode.Append, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(manger.ToString());
                sr1.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");

            }
        }
        //حذف مدير
        public void DeleteManger(Manger manger)
        {
            try
            {
                FileStream fileStream = new FileStream("Manger.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<Manger> mangers = new List<Manger>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (manger.id.Equals(line))
                    {
                        mangers.RemoveAll(p => p.id == manger.id);
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
        //جلب المدير
        public List<Manger> GetManger()
        {
            int id = 0;
            FileStream fileStream = new FileStream("Manger.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fileStream);
            List<Manger> Mangers = new List<Manger>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Mangers.Add(line);
                fileStream.Close();
                sr.Close();
            }
            return Mangers;
        }
        //تعديل
        public void UpdateManger(Manger manger)
        {
            try
            {
                List<string> lines = new List<string>();

                // قراءة البيانات من الملف
                using (StreamReader sr = new StreamReader("patient.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == manger.id.ToString())
                        {
                            // بدلاً من حذف السطر، يمكننا تعديله مباشرة
                            // يتم تجاوز البيانات بالبيانات الجديدة للمريض
                            line = $"{manger.id},{manger.first_name},{manger.last_name},{manger.adders},{manger.age},{manger.phon},{manger.email},{manger.gender},{manger.blood_group}";
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
        //حذف
        public void DeleteManager(Manger manager)
        {
            try
            {
                List<Manger> managers = new List<Manger>();

                // قراءة البيانات من الملف وإضافتها إلى القائمة
                using (StreamReader sr = new StreamReader("manager.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == manager.id.ToString())
                        {
                            // تجاوز البيانات بالبيانات الجديدة للمدير
                            line = $"{manager.id},{manager.first_name},{manager.last_name},{manager.adders},{manager.age},{manager.phon},{manager.email},{manager.gender},{manager.blood_group},{manager.sal},{manager.namejob},{manager.namedepartment}";
                        }
                       
                        
                    }
                }

                // حذف المدير المطلوب من القائمة
                managers.RemoveAll(m => m.id == manager.id);

                // كتابة البيانات المحدثة إلى الملف
                using (StreamWriter sw = new StreamWriter("manager.txt"))
                {
                    foreach (var m in managers)
                    {
                        sw.WriteLine($"{m.id},{m.first_name},{m.last_name},{m.adders},{m.age},{m.phon},{m.email},{m.gender},{m.blood_group},{m.sal},{m.namejob},{m.namedepartment}");
                    }
                }

                Console.WriteLine("تم حذف المدير بنجاح.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"حدث خطأ: {ex.Message}");
            }
        }

      
    }

}

