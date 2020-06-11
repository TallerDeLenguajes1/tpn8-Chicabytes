using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculadora
    {
        private float Numero1;
        private float Numero2;

        public float numero2 { get => Numero2; set => Numero2 = value; }
        public float numero1 { get => Numero1; set => Numero1 = value; }

        public float Suma()
        {
            return numero1 + numero2;
        }
        public float Resta()
        {
            return numero1 - numero2;
        }
        public float Multiplicacion()
        {
            return numero1 * numero2;
        }
        public float Division()
        {
            if(numero2 != 0)
            {
                return numero1 / numero2;
            }
            else
            {
                return 0;
            }
        }
    }
}
