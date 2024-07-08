using hospital1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital1.connect
{
    internal interface INurse
    {
        public abstract List<nurse> Getnurse();
        public abstract void Updatenurse(nurse nurse);
        public abstract void Deletenurser(nurse nurse);
        public abstract void Addnurse(nurse nurse);
    }
}
