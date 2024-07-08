using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class patient : parson
    {






        public patient(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, string nameIllness) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group)
        {
            NameIllness = nameIllness;
        }

        private string NameIllness;
        public List<Doctor> Doctors= new List<Doctor>();
        public List<nurse>nurses= new List<nurse>();  
     public List<patient>mangers = new List<patient>();


        public string nameillness
        {
            get
            {
                return NameIllness;
            }
            set
            {
                if (value.Length >= 5)
                {
                    NameIllness = value;
                }
            }

        }

        public override string ToString()
        {

            try
            {
                return $"{id},{first_name},{last_name},{adders},{age},{phon},{email},{gender},{blood_group},{nameillness}";
            }
            catch (Exception ex)
            {

                return $"{ex}";
            }
        }
        public static implicit operator string(patient p)
        {
            return p.ToString() ;
        }
        public static implicit operator patient(string str) {
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
                string nameIllness = arr[9];
                return new patient(ID, first_Name, last_Name, adders, age, phon, email, gender, blood_group,nameIllness);

            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }
    }
}
