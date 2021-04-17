using jra.ListaDoble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jra.ListaDoble
{
    class ListaDoble
    {
        public Nodo cabeza;//es el nodo que se llama primero

        public ListaDoble()
        {
            cabeza = null;
        }

        public ListaDoble InsertarCabezaLista(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            return null;
        }

        public ListaDoble InsertaDespues(Nodo anterior, string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = anterior.adelante;

            if (anterior.adelante != null)
            {
                anterior.adelante.atras = nuevo;
            }
            anterior.adelante = nuevo;
            nuevo.atras = anterior;
            return this;
        }

        public void eliminar(String entrada)
        {
            Nodo actual;
            bool encontrado = false;
            actual = cabeza;

            //bucle de busqueda (elemento que necesitamos eliminar)
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato.Equals(entrada));
                if (!encontrado)
                {
                    actual = actual.adelante;
                }
            }
            //enlace de nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir entre nodo cabecera del resto de la lista
                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                }
                else if (actual.adelante != null)
                {
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else
                {//ultimo nodo
                    actual.atras.adelante = null;
                }
                actual = null;
            }
        }

        public void visualizar()
        {
            Nodo n;
            n = cabeza;
            while (n != null)
            {
                Console.WriteLine(n.dato);
                n = n.adelante;
            }
        }     
    }
}