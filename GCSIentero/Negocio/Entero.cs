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

            numeroentero = 0;

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


        //////////////////////////////////////////////...................

        public int[] ObtenerNumeros() {

            int aux = numeroentero;

            int[] vnumeros = new int[10];

            while(aux > 0){

                int d = aux % 10;

                aux /= 10;

                vnumeros[d] += 1;

                
            }

            return vnumeros; 
        }

        public int DigitoMasRepetido()
        {

            //222344455555588888000000000

            int[] vnumero = ObtenerNumeros();
            int i = vnumero.Length;

            int mayor = 0;
            int indicemayor = 0;

            while (i > 0)
            {

                if (vnumero[i - 1] > mayor)
                {

                    mayor = vnumero[i - 1];

                    indicemayor = i - 1;


                    //..........1.7.3.4.8.5
                    //0;5

                }

                i--;

            }

            return indicemayor;
        }


        //////////////////////////////////////////////...................
        private Int32 Mayorpa(Int32 numero) {
            Int32 digitoMayor = 0, ultimoDigito = 0;
            while(numero>0){
                ultimoDigito = numero % 10;
                numero = numero / 10;
                if(ultimoDigito>digitoMayor){
                    digitoMayor = ultimoDigito;
                }
            }
            return digitoMayor;
        }

        public int Mayor() {

            return Mayorpa(numeroentero);

        }
        //////////////////////////////////////////////...................
        public int EliminarMayor() {

            int num = numeroentero;

            Int32 digitoMayor = Mayorpa(num), ultimoDigito = 0, reserva = 0;
            Boolean a=false;             
                while (a==false){                   
                    ultimoDigito = num % 10;
                    if (ultimoDigito == digitoMayor)
                    {
                        a = true;
                        num = num / 10;
                        while (reserva != 0)
                        {
                            num = (num * 10) + reserva % 10;
                            reserva = reserva / 10;
                        }                                       
                    }
                    else {
                        reserva = (reserva * 10) + ultimoDigito;
                        num = num / 10;                     
                    }
                }
                return num;
            }

        //////////////////////////////////////////////...................
        public Int32 Ordenado() {

            Int32 ordenado = 0;
            int num = numeroentero;

            while(num>0){

                ordenado = (ordenado * 10) + (Mayorpa(num));
                numeroentero = EliminarMayor();

            }
            return ordenado;
        }

        ////////////// Many \\\\\\\\\\\\\\\\\\\\\\\\\\
        public bool esPrimo(Int32 n)
        { //// Many \\\\\\
            Int32 Count = 0;
            if (n == 1 || n == 0)
                return false;
            for (Int32 i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Count++;
                    if (Count > 2)
                        return false;
                }

            }
            return true;
        }

        public Int32 mostrarPrimos()
        { //// Many \\\\\\\\\\
            Int32 mod = 0;
            Int32 result = 0;
            while (numeroentero > 0)
            {
                mod = numeroentero % 10;
                numeroentero = numeroentero / 10;
                if (esPrimo(mod))
                {
                    result = result * 10 + mod;
                }
            }
            return invertir(result);

        }


        public Int32 eliminarPrimos()
        { //// Many \\\\\\\\\
            Int32 mod = 0;
            Int32 result = 0;
            while (numeroentero > 0)
            {
                mod = numeroentero % 10;
                numeroentero = numeroentero / 10;
                if (!esPrimo(mod))
                {
                    result = result * 10 + mod;
                }
            }
            return invertir(result);

        }
        public Int32 invertir(Int32 n)
        { //// Many \\\\\\\\\\
            Int32 mod = 0;
            Int32 result = 0;
            while (n > 0)
            {
                mod = n % 10;
                n = n / 10;
                result = result * 10 + mod;
            }
            return result;
        }
        public Int32 cantidadDigitos()
        {       //// Many \\\\\\      
            Int32 result = 0;
            while (numeroentero > 0)
            {
                numeroentero = numeroentero / 10;
                result++;
            }
            return result;
        }
    }
}
