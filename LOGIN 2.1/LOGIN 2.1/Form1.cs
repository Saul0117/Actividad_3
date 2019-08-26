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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra el Formulario1
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "juancho" && contraseña.Text == "123tamarindo")
            {
                MessageBox.Show("Bienvenido Sr juancho");
                this.Hide();//Escondemos ventana login
                Ventana2 CursosVentana = new Ventana2();
                CursosVentana.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña no valido.");
                usuario.Text = "";
                contraseña.Text = "";
                usuario.Focus();
            }

        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                if (usuario.Text == "juancho" && contraseña.Text == "123tamarindo")
                {
                    MessageBox.Show("Bienvenido Sr juancho");
                    this.Hide();//Escondemos ventana login
                    Ventana2 CursosVentana = new Ventana2();
                    CursosVentana.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña no valido.");
                    usuario.Text = "";
                    contraseña.Text = "";
                    usuario.Focus();
                }
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                contraseña.Focus();
            }
        }
    }
}
