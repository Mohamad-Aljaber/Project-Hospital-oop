using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.classes
{
    internal class Employe:parson
    {
        private int Sal;
        private string NameJob;
        private string NameDepartment;

      

        public Employe(int id, string first_Name, string last_Name, string adders, int age, string phon, string email, string gender, string blood_group, int sal, string nameJob, string nameDepartment) : base(id, first_Name, last_Name, adders, age, phon, email, gender, blood_group)
        {
            Sal = sal;
            NameJob = nameJob;
            NameDepartment = nameDepartment;
        }

        public  int sal { get { 
            
            return Sal;
            } set { 
            if(value>0)
                {
                    Sal = value;

                }
            } }
        //اسم الوظيفة
        public string namejob { 
            get {
            return NameJob;
            } 
            set { 
            if(value.Length>4)
                {
                    NameJob = value;
                }
            } 
        }
        //اسم القسم
        public string namedepartment {

            get
            {
                return NameDepartment;
            }
            set
            {
                if (value.Length > 4)
                {
                    NameDepartment = value;
                }
            }
        }



    }
}
