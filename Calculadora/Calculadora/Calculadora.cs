using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    class Calculadora
    {
        private float Numero1;
        private float Numero2;
        private DateTime Fecha;
        private float Resultado;
        private char operador;
        public float numero2 { get => Numero2; set => Numero2 = value; }
        public float numero1 { get => Numero1; set => Numero1 = value; }
        public DateTime fecha { get => Fecha; set => Fecha = value; }
        public float Resultado1 { get => Resultado; set => Resultado = value; }
        public char Operador { get => operador; set => operador = value; }

        public float Operacion()
        {
            if (Operador == '+')
            {
                
                Resultado = numero1 + numero2;
            }
            else if (Operador == '-')
            {
                Resultado = numero1 - numero2;
            }
            else if (Operador == '*')
            {
                Resultado = numero1 * numero2;
            }
            else if (Operador == '/')
            {
                if (numero2 != 0)
                {
                    Resultado = numero1 / numero2;
                }
                else
                {
                    return 0;
                }
            }
            return Resultado;
        }
        public override string ToString()
        {
            return fecha.ToString()+ " --> " + Numero1.ToString() + Operador +   Numero2.ToString() + "=" + Resultado.ToString();
        }
    }
}
