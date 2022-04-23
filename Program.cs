/* Crea una clase llamada Cuenta para manejar una caja de ahorro. Deben tener los
siguientes atributos: titular y cantidad (puede tener decimales).
El titular ser´a obligatorio y la cantidad es opcional. Crea dos constructores que cumpla
lo anterior.
Crea sus m´etodos get, set y toString.
Tendr´a dos m´etodos especiales:
ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad
introducida es negativa, no se har´a nada.
retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad
actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
*/
using System;

namespace Ejercicio1_POO_CajaAhorros
{
    class Cuenta
    {
        private int titular;
        private float cantidad;

        public Cuenta(int _titular)
        {
            titular = _titular;
        }

        public int getTitular()
        {
            return titular;
        }
        public float getCantidad()
        {
            return cantidad;
        }
        /*No tiene sentido esta funcion: public void setTitular() { } */
        public void setCantidad(float _cantidad)
        {
            cantidad = _cantidad;
        }

        public override string ToString()
        {
            return "#Titular: " + titular + "  Cantidad$: " + cantidad;
        }

        public void ingresar(float monto)
        {
            if (monto > 0)
            {
                //bien
                cantidad += monto;
                Console.WriteLine("Depositaste: $" + monto + "\nSaldo actual: $" + cantidad);
            }
            else
            {
                Console.WriteLine("Monto invalido: valor negativo.\n");
            }
        }

        public void retirar(float monto)
        {
            if (monto < 0)
            {
                Console.WriteLine("Monto invalido: valor negativo.\n");
            }
            else
            {
                if (monto > cantidad)
                {
                    Console.WriteLine("Fondos insuficientes");
                }
                else
                {
                    cantidad -= monto;
                    Console.WriteLine("Retiraste: $" + monto + "\nSaldo: $" + cantidad);
                }
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta(1123);
            Console.WriteLine(miCuenta.ToString());

            miCuenta.ingresar(-23.5f);

            miCuenta.ingresar(23.30f);
            Console.WriteLine(miCuenta.ToString());
        }
    }
}
