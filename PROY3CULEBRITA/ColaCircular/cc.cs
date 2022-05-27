using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcc
{
    internal class cc
    {
        private static int fin;
        private static int MAXTAMQ = 900000000;
        protected int frente;

        public int numelement;

        public int numeleme()
        {
            return numelement; 
        }



        protected Object[] listaCola; //lo unico que cambia es lo de Object 
        // avanza una posición

        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //inicializa la cola vacía

        public cc()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new Object[MAXTAMQ];
        }

        // operaciones de modificación de la cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                numelement++;
                fin = siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        }

        public Object quitar()
        {
            if (!colaVacia())
            {
                numelement--;
                Object tm = listaCola[frente];
                frente = siguiente(frente);
                return tm;
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }



        public void borrarCola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        // acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia ");
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


        // métodos de verificación del estado de la cola

        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }

        // comprueba si está llena

        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }





    }

}
