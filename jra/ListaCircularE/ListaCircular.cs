using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jra.ListaCircularE
{
    class ListaCircular
    {

        public NodoCircular lc;

        public ListaCircular()
        {
            lc = null;
        }

        public ListaCircular insertar(String entrada)
        {
            NodoCircular nuevo;
            nuevo = new NodoCircular(entrada);
            if (lc != null) // lista circular no vacía
            {
                nuevo.enlace = lc.enlace;
                lc.enlace = nuevo;
            }
            lc = nuevo;
            return this;
        }

        public void eliminar(String entrada)
        {
            NodoCircular actual;
            actual = lc;
            while ((actual.enlace != lc) && !(actual.enlace.dato.Equals(entrada)))
            {
                if (!actual.enlace.dato.Equals(entrada))
                {
                    actual = actual.enlace;
                }
            }
            // Enlace de nodo anterior con el siguiente
            // si se ha encontrado el nodo.
            if (actual.enlace.dato.Equals(entrada))
            {
                NodoCircular p;
                p = actual.enlace; // Nodo a eliminar
                if (lc == lc.enlace) // Lista con un solo nodo
                {
                    lc = null;
                }
                else
                {
                    if (p == lc)
                    {
                        lc = actual; // Se borra el elemento referenciado por lc,   
                                     // el nuevo acceso a la lista es el anterior
                    }
                    actual.enlace = p.enlace;
                }
                p = null;
            }
        }

        public void borrarLista()
        {
            NodoCircular p;
            if (lc != null)
            {
                p = lc;
                do
                {
                    NodoCircular t;
                    t = p;
                    p = p.enlace;
                    t = null; // no es estrictamente necesario
                } while (p != lc);
            }
            else
            {
                Console.WriteLine("\n\t Lista vacía.");
            }
            lc = null;
        }

        public void recorrer()
        {
            NodoCircular p;
            if (lc != null)
            {
                p = lc.enlace; // siguiente nodo al de acceso
                do
                {
                    Console.WriteLine("\t" + p.dato);
                    p = p.enlace;
                } while (p != lc.enlace);
            }
            else
            {
                Console.WriteLine("\t Lista Circular vacía.");
            }
        }
    }
}// end class
