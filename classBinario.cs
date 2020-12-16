using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProgramador
{
    class classBinario:classDecimal
    {
        public classBinario(string infobinario) : base(infobinario)
        {

        }
        public void Infobinario()
        {
            System.Windows.Forms.MessageBox.Show("El tipo de numero binario consiste en: " + informacion);

        }
    }
}
