using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class Manger : Employe
    {
        public Manger(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, int sal, string nameJob, string nameDepartment) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment)
        {
        }
        public List<Doctor> Doctors = new List<Doctor>();
        public List<nurse> nurses = new List<nurse>();
        public List<patient> patients = new List<patient>();

        public override string ToString()
        {
            try
            {
                return $"{id},{first_name},{last_name},{adders},{age},{phon},{email},{gender},{blood_group},{sal},{namejob},{namedepartment}";
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }
        public static implicit operator string(Manger manger)
        {
            return manger.ToString();
        }
        public static implicit operator Manger(string str)
        {
            try
            {
                string[] arr = str.Split(',');
                int ID = Convert.ToInt32(arr[0]);
                string first_Name = arr[1];
                string last_Name = arr[2];
                string adders = arr[3];
                int age = Convert.ToInt32(arr[4]);
                string phon = arr[5];
                string email = arr[6];
                string gender = arr[7];
                string blood_group = arr[8];
                int sal = Convert.ToInt32(arr[9]);
                string nameJob = arr[10];
                string nameDepartment = arr[11];
               


                return new Manger(ID, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment);

            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

    }
}
