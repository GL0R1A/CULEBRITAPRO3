using System;
using System.Collections.Generic;
using System.Text;

namespace lcle
{
    internal class cle
    {
        public Nodo _primero;
        public Nodo _ultimo;
        int tamanio;

        public int numelement;

        public int numeleme()
        {
            return numelement;
        }

        public cle()
        {
            _primero = null;
            _ultimo = null;
        }

        //Devuelve si la Cola esta vacia
        public bool ColaVacia()
        {
            return _primero == null;
        }

        // Devuelve el tamaño de la Cola
        public int TamanioCola()
        {
            return tamanio;
        }

        // Devuelve el frende de la Cola
        public Object frenteCola()
        {
            if (!ColaVacia())
            {
                return (_primero.Dato);
               
            }
            throw new Exception("Cola Vacia");
        }

        // Devuelve el fin de la Cola
        public Object finalCola()
        {
            if (!ColaVacia())
            {
                return (_ultimo.Dato);
                
            }
            throw new Exception("Cola Vacia");
        }

        //Inserta un elemento en la cola de ListaEnlazada
        public void insertarValor(Object elemento)
        {
            numelement++;
            Nodo nuevo =  new Nodo(elemento);
            if (!ColaVacia())
            {
                _ultimo.Siguiente = nuevo;
            }
            else
            {
                _primero = nuevo;
            }
            _ultimo = nuevo;
            tamanio++;
        }

        //Quita un valor de la Cola ListaEnlazada
        public Object quitarValor()
        {
            numelement--;
            Object auxiliar;
            if (!ColaVacia())
            {
                auxiliar = _primero.Dato;
                _primero = _primero.Siguiente;
                tamanio--;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }

            return auxiliar;
        }

        //Devuelve el Numero de Elementos de la Lista
        public int numeroElementosLista()
        {
            int numero;
            Nodo nodo = _primero;
            if (!ColaVacia())
            {
                numero = 1;
                while (nodo != _ultimo)
                {
                    numero++;
                    nodo = nodo.Siguiente;
                }
            }
            else
            {
                numero = 0;
            }
            return numero;
        }
    }

}
