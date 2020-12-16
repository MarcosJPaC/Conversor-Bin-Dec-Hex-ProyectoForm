using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProgramador
{
    class classDecimal : Numeros
    {
        public classDecimal(string datodecimal):base(datodecimal)
        {
            
        }
        public void Datodecimal()
        {
            System.Windows.Forms.MessageBox.Show("El tipo de numero decimal consiste en: "+ informacion);
        }
    }
}
