using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal class OPertionPatient : IPatientOperiition
    {
        //اضافة
        public void AddPatients(patient patient )
        {
            try
            {
                int new_Idpatients = Operitions.getid("patient.txt");
                patient.id = new_Idpatients;
                FileStream fs = new FileStream("patient.txt", FileMode.Append, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(patient.ToString());               
                sr1.Close();
                sr1.Dispose();
                fs.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");

            }
        }


        //حذف موظف
        public void DeletePatients(patient patient)
        {
            try
            {
                FileStream fileStream = new FileStream("patient.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<patient> patients = new List<patient>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (patient.id.Equals(line))
                    {
                        patients.RemoveAll(p => p.id == patient.id);
                    }

                  
                }
                fileStream.Close();
             

            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex}");
            }
        }

       

      

        //جلب المرضى
        public List<patient> GetPatients() 
        {
            int id = 0;
            FileStream fileStream = new FileStream("patient.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fileStream);
            List<patient>  patients = new List<patient>(); 
                string line;
            while ((line = sr.ReadLine()) != null)
            {
                patients.Add(line);
                fileStream.Close();
            }
            return patients;
        }
        //تعديل
        public void UpdatePatients(patient patient)
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
                        if (parts[0] == patient.id.ToString())
                        {
                            // بدلاً من حذف السطر، يمكننا تعديله مباشرة
                            // يتم تجاوز البيانات بالبيانات الجديدة للمريض
                            line = $"{patient.id},{patient.first_name},{patient.last_name},{patient.adders},{patient.age},{patient.phon},{patient.email},{patient.gender},{patient.blood_group},{patient.nameillness}";
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
