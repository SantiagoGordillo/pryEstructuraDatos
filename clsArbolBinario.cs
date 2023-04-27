using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        public clsNodo ini;

        public clsNodo Raiz
        {
            get { return ini; }
            set { ini = value; }
        }
    }
}
