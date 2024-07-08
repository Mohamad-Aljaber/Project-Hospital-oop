using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal interface IPatientOperiition
    {
        public abstract List<patient> GetPatients();
        public abstract void UpdatePatients(patient patient);
        public abstract void DeletePatients(patient patient);
        public abstract void AddPatients(patient patient);
    }
}
