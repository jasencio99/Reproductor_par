using jra.ListaPuntos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jra.objListaOrdenada
{
    public class ListaOrdenada : ListaPuntos.Lista
    {
        public ListaOrdenada() : base()
        {

        }
        public void insertaOrden(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (primero == null)
            {
                primero = nuevo;
            }
            else if (entrada.CompareTo(primero.getDato()) < 0) //van a ser las letras que este mas cercanas a la a
            {
                nuevo.setEnlace(primero);
                primero = nuevo;
            }
            else
            {
                //Busqueda del nodo anterior, a partir de aqui se hara la insercion
                Nodo anterior, p;
                anterior = p = primero;
                while ((p.getEnlace() != null) && (entrada.CompareTo(p.getDato())) > 0)
                {
                    anterior = p;
                    p = p.getEnlace();
                }
                if (entrada.CompareTo(p.getDato()) > 0)//se inserta despues del ultimo nodo
                {
                    anterior = p;
                }
                nuevo.setEnlace(anterior.getEnlace());
                anterior.setEnlace(nuevo);

            }
            // return this;

        }


        ////Metodo para poder localizar el archivo que quiero eliminar de la lista
        //public Nodo search(int index)// nos retorna el nodo que estamos buscando
        //{

        //    if (index < 0)
        //    {
        //        return null;
        //    }

        //    int n = 0;
        //    Nodo aux = primero;

        //    while (n != index)
        //    {
        //        aux = aux.enlace;
        //        n++;
        //    }

        //    return aux;
        //}

        public void eliminar(string entrada)
        {
            Nodo actual, anterior;
            bool encontrado;

            //inicializa los apuntadores de memoria
            actual = primero;
            anterior = null;
            encontrado = false;

            //busqueda del nodo anterior
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato.Equals(entrada));

                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }//end if
            }//end while

            //enlace del nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir si es el nodo inicial o cabeza, o si es cualquier otro nodo de la lista
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null;
            }//end if
        }//end metodo


    }
}
