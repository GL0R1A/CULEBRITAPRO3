using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lca
{
    internal class ca
    {
        ArrayList colaarray = new ArrayList();
        int tamanio;
        public int TamanioCola()
        {
            return tamanio;
        }



        //incializa la cola con una serie de elementos
        public ca()
        {
             this.colaarray = new ArrayList();
        }


        public int numelement;

        public int numeleme()
        {
            return numelement;
        }

        public Object finalcola()
        {

            return colaarray[colaarray.Count - 1];
        }

        public void Insertar(object dato)
        {
            if (!colaLlena())
            {
                numelement++;
                colaarray.Add(dato);
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
            tamanio++;

        }

        public object quitar()
        {
            if (!colaVacia())
            {
                object dato = colaarray[0];
                colaarray.RemoveAt(0);
                numelement--;
                tamanio--;
                return dato;
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }

         
        
        public bool colaVacia()
        {
            if (colaarray.Count == 1000000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool colaLlena()
        {
            if (colaarray.Count == 1000000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
