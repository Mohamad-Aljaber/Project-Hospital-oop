using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class nurse:Employe
    {


        private string Specialty;

      

        public nurse(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, int sal, string nameJob, string nameDepartment,string specialty) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment)
        {
            Specialty = specialty;
        }

        public string specialty
        {
            get
            {
                return Specialty;
            }
            set
            {
                if (value.Length > 5)
                {
                    Specialty = value;
                }

            }
        }
        public override string ToString()
        {
            try
            {
                return $"{id},{first_name},{last_name},{adders},{age},{phon},{email},{gender},{blood_group},{sal},{namejob},{namedepartment},{specialty}";
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }
        public static implicit operator string(nurse p)
        {
            return p.ToString();
        }
        public static implicit operator nurse(string str)
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
                string specialty = arr[12];


                return new nurse(ID, first_Name, last_Name, adders, age, phon, email, gender, blood_group, sal, nameJob, nameDepartment, specialty);

            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }





    }
}
