using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jra.ListaCircularE
{
    class NodoCircular
    {
        public String dato;
        public NodoCircular enlace;
        public NodoCircular(String entrada)
        {
            dato = entrada;
            enlace = this;
        }
    }
}