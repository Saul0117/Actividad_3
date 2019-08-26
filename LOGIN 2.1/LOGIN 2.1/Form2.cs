using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_2._1
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if (VC.Checked == true)
            {
                conteo++;
            }
            if (VB.Checked == true)
            {
                conteo++;
            }
            if (TC.Checked == true)
            {
                seleccion = "Tarjeta de Crédito";
            }
            else
            {
                seleccion = "PayPal";
            }
        }
    }
}
