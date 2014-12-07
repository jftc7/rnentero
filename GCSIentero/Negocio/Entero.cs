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

            return numeroentero % 2 != 0;

        }

        public Int32 Mayor(Int32 numero) {
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

        public int EliminarMayor(int num) {
            Int32 digitoMayor = Mayor(num), ultimoDigito = 0, reserva = 0;
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

        


        public Int32 Ordenado() {
            Int32 ordenado = 0;
        while(numeroentero>0){
            ordenado = (ordenado * 10) + (Mayor(numeroentero));
            numeroentero = EliminarMayor(numeroentero);
        }
        return ordenado;
        }

    }
}
