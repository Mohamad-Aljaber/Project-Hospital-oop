using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class parson
    {
        private int Id;
        private string First_Name;
        private string Last_Name;
        private string Adders;
        private int Age;
        private string Phon;
        private string Email;
        private string Gender;
        private string Blood_group;

        public parson(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group)
        {
            Id = id;
            First_Name = first_Name;
            Last_Name = last_Name;
            Adders = adders;
            Age = age;
            Phon = phon;
            Email = email;
            Gender = gender;
            Blood_group = blood_group;
        }

        public  int id 
        {
            get {
            return Id;
            }
            set {
                if (value >= 0)
                {
                    Id = value;
                }
            } 
        }
        public string first_name {
            get
            {
                return First_Name;
            }
            set
            {
                if (value.Length >= 2)
                {
                    First_Name = value;
                }
            }
        }
        public string last_name {
            get
            {
                return Last_Name;
            }
            set
            {
                if (value.Length >= 2)
                {
                    last_name = value;
                }
            }
        }
        public string adders {
            get
            {
                return Adders;
            }
            set
            {
                if (value.Length >= 2)
                {
                    Adders = value;
                }
            }
        }
        public int age {
            get
            {
                return Age;
            }
            set
            {
                if (value >= 0)
                {
                    Age = value;
                }
            }
        }
        public string phon {
            get
            {
                return Phon;
            }
            set
            {
                if (value.Length == 5)
                {
                    Phon = value;
                }
            }
        }
        public string email {

            get
            {
                return Email;
            }
            set
            {
                if (value.Length >= 10)
                {
                    Email = value;
                }
            }
        }
        public string gender {
            get
            {
                return Gender;
            }
            set
            {
                if (value.Length >= 4)
                {
                    Gender = value;
                }
            }

        }
        public string blood_group {
            get
            {
                return Blood_group;
            }
            set
            {
                if (value.Length >= 2)
                {
                    Blood_group = value;
                }
            }

        }




    }
}
