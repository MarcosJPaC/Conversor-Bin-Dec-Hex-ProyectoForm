using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraProgramador
{
    public partial class Form1 : Form
    {
        int op = 0, n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void Escribir(string FF)
        {

            switch (op)
            {
                case 0:
                    if (txtDecimal.Text == "0")
                        txtDecimal.Text = "";
                    txtDecimal.Text += FF;
                    DecimalATodo();
                    break;
                
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Escribir("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Escribir("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Escribir("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Escribir("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Escribir("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Escribir("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Escribir("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Escribir("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Escribir("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Escribir("0");
        }

        private void Del_Click(object sender, EventArgs e)
        {
            string t = "";
            switch (op)
            {
                case 0:
                    t = txtDecimal.Text;
                    txtDecimal.Text = "";
                    for (int x = 0; x < t.Length - 1; x++)
                        txtDecimal.Text += t[x];
                    if (txtDecimal.Text == "") txtDecimal.Text = "0";
                    DecimalATodo();
                    break;
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtHexa.Text = "0";
            txtDecimal.Text = "0";
            txtBinario.Text = "0";
            
        }
        void DecimalATodo() 
        {
            n = int.Parse(txtDecimal.Text);

            txtBinario.Text = Numeros.DecaBin(n);
            
            n = int.Parse(txtDecimal.Text);

            txtHexa.Text = Numeros.DecimalAHexa(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cboInfo.Text)
            {
                case "Decimal":
                    classDecimal datodecimal = new classDecimal("El número que tiene una representación decimal finita en el sistema de numeración decimal, y por tanto es un número racional con denominador de la forma 2n5m, donde m y n son enteros no negativos.");
                    datodecimal.Datodecimal();
                    break;
                case "Binario":
                    classBinario datobinario = new classBinario("El sistema binario, llamado también sistema diádico​ en ciencias de la computación, es un sistema de numeración en el que los números són representados utilizando únicamente dos cifras: cero y uno. ");
                    datobinario.Infobinario();
                    break;
                case "Hexa":
                    classHexa datohexa = new classHexa("El método hexadecimal es una manera conveniente de representar valores binarios. Así como el sistema de numeración decimal es un sistema de base diez y el binario es un sistema de base dos, el sistema hexadecimal es un sistema de base dieciséis.");
                    datohexa.Infohexa();
                    break;
            }

        }





        
        
        



    }
}
