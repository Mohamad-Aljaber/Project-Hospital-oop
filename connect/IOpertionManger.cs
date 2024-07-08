using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal interface IOpertionManger
    {
        public abstract List<Manger> GetManger();
        public abstract void UpdateManger(Manger manger);
        public abstract void DeleteManger(Manger manger);
        public abstract void AddManger(Manger manger);
    }
}
