using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesMatematicasGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declacion de las variables y sus conversiones 
            double num1 = int.Parse(txtNumero1.Text);
            double num2 = int.Parse(txtNumero2.Text);

            //proceso de la operacion suma, resta, multiplicacion, Division 

            double suma = num1 + num2;
            double resta = num1 - num2;


            //salida 
            txtResultado.Text = $" La suma es: {suma} " +
                $"La resta es: {resta}";

        }
    }
}
