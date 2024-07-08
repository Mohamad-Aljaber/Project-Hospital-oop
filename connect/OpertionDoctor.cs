using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal class OpertionDoctor : IDoctorOperition
    {
        //اضافة دكتور
        public void AddDoctor(Doctor doctor)
        {
            
                int new_Idpatients = Operitions.getid("doctors.txt");
               doctor.id = new_Idpatients;
                FileStream fs = new FileStream("doctors.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sr1 = new StreamWriter(fs);
                sr1.WriteLine(doctor.ToString());
            
                fs.Close();
          
            
          
        }
        //حذف الدكتور
        public void DeleteDoctor(Doctor doctor)
        {
            try
            {
                FileStream fileStream = new FileStream("doctors.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<Doctor> doctors = new List<Doctor>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (doctor.id.Equals(line))
                    {
                        doctors.RemoveAt(doctor.id);
                    }

                    fileStream.Close();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex}");
            }
        }
        //جلب بيانات الدكتور
        public List<Doctor> GetDoctors()
        {
            try
            {
                int id = 0;
                FileStream fileStream = new FileStream("doctors", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fileStream);
                List<Doctor> doctors = new List<Doctor>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    doctors.Add(line);
                    fileStream.Close();
                }
                return doctors;
            }
            catch (Exception ex)
            {

                throw ;
            }
        }
        //التعديل على ملفات الدكتور
        public void UpdateDoctors(Doctor doctor)
        {
            try
            {
                List<Doctor> lines = new List<Doctor>();


                // قراءة البيانات من الملف
                using (StreamReader sr = new StreamReader("patient.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == doctor.id.ToString())
                        {

                            // يتم تجاوز البيانات بالبيانات الجديدة للمريض
                            line = $"{doctor.id},{doctor.first_name},{doctor.last_name},{doctor.adders},{doctor.age},{doctor.phon},{doctor.email},{doctor.gender},{doctor.blood_group},{doctor.sal},{doctor.namejob},{doctor.namedepartment},{doctor.specialty}";
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
