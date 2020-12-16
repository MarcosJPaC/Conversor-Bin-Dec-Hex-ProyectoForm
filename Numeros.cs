using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProgramador
{
    public class Numeros
    {
        protected string informacion;

        public Numeros(string dato)
        {
            informacion = dato;
            
        }
        public void Informacion()
        {
            System.Windows.Forms.MessageBox.Show("Definicion de el tipo de numero: "+informacion);
        }
        public static string DecaBin(int n)
        {
           string oper  = "";
            while (n != 0)
            {
                oper = (n % 2).ToString() + oper;
                n /= 2;
            }

            return oper ;
        }
        //Inicia metodo Hexadecimal
        public static string DecimalAHexa(int n)
        {
           
            string oper = "";
            while (n != 0)
            {
                switch (n % 16)
                {
                    case 10: oper = "A" + oper; break;
                    case 11: oper = "B" + oper; break;
                    case 12: oper = "C" + oper; break;
                    case 13: oper = "D" + oper; break;
                    case 14: oper = "E" + oper; break;
                    case 15: oper = "F" + oper; break;
                    default: oper = (n % 16).ToString() + oper; break;
                }
                n /= 16;
            }
            return oper;
        }
    }
}
