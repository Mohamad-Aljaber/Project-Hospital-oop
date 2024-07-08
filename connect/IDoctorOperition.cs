using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal interface IDoctorOperition
    {
        public abstract List<Doctor> GetDoctors();
        public abstract void UpdateDoctors(Doctor  doctor);
        public abstract void DeleteDoctor(Doctor doctor);
        public abstract void AddDoctor(Doctor doctor);
    }
}
