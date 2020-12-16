using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProgramador
{
    class classHexa:classBinario
    {
        public classHexa(string infohexa) : base(infohexa)
        {

        }
        public void Infohexa()
        {
            System.Windows.Forms.MessageBox.Show("El tipo de numero hexadecimal consiste en: "+informacion);
        }
    }
}
