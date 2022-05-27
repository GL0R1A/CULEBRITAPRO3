using System;
using System.Collections.Generic;
using System.Text;

namespace lclarr
{
    internal class clarr
    {
        protected int fin;
        private static int MAXTAMQ = 900000000;
        protected int frente;

        public int numelement;

        public int numeleme()
        {
            return numelement;
        }

        protected Object[] listaCola;

        public clarr()
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[MAXTAMQ];
        }

        // OPERACIONES DE MODIFICACIN DE LA COLA

        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                numelement++;
                listaCola[++fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        
        }

        public Object quitar() 
        {
            if (!colaVacia()){

                numelement--;
                Object aux = listaCola[frente++];
                return aux;
            //return listaCola[frente++];
            } 
            else {
            throw new Exception("Cola vacia");
            }
        }
        //cola vacia
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia()){
                return listaCola[frente];
            } 
            else {
                throw new Exception("Cola vacio");
            }
        }

        public Object finalCola()
        {
            if (!colaVacia())
            {
                return listaCola[fin];
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }


        //metodos de verificacion de cola
        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }

    }
}
