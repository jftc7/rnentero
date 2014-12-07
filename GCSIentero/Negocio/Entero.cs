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

<<<<<<< HEAD
        //////////////////////////////////////////////...................

        public int[] ObtenerNumeros() {

            int aux = numeroentero;

            int[] vnumeros = new int[10];

            while(aux > 0){

                int d = aux % 10;

                aux /= 10;

                vnumeros[d] += 1;

                
            }
            //123 / 10
            // 23 / 1

            // 23 / 10
            //  3 / 2

            //  3 / 10
            //  0  / 3


            return vnumeros; 
        }

        public int DigitoMasRepetido() {

            //222344455555588888000000000

            int[] vnumero = ObtenerNumeros();
            int i = vnumero.Length;

            int mayor = 0;
            int indicemayor = 0;

            while( i>0){

                if (vnumero[i - 1] > mayor)
                {

                    mayor = vnumero[i - 1];

                    indicemayor = i-1;


                    //..........1.7.3.4.8.5
                    //0;5
                    


                }

                i--;

            }

            return indicemayor;
=======
        public bool EsImpar()
        {

            return numeroentero % 2 ! = 0;

>>>>>>> a95384aa83551ff21f739f18cb5c5191e2e62bb7
        }

    }
}
