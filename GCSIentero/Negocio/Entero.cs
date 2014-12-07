using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Entero
    {

        int numeroentero;

        public Entero() { 
        
        }

        public Entero(int numero) {

            numeroentero = numero;

        }


        public void set(int numero) {
            numeroentero = numero;
        }

        public int get() {
            return numeroentero;
        }

        //////////////////////////////////////////////...................


        public bool EsPar() {

            return numeroentero % 2 == 0;

        }

        public bool EsImpar()
        {

            return numeroentero % 2 ! = 0;

        }

    }
}
