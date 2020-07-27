using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoIB_HCI
{
    public partial class Form1 : Form
    {
        ArrayList usuarios;
        ArrayList contrasenias;
        public Form1()
        {
                       InitializeComponent();
            usuarios = new ArrayList();
            contrasenias = new ArrayList();
            usuarios.Add("Edwin");
            contrasenias.Add("123");
            usuarios.Add("Maria Cristina");
            contrasenias.Add("m123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean banderaU = false;
            Boolean banderaC = false;
            foreach (var usr in usuarios)
            {
                if (usr.ToString() == usuario.Text)
                    banderaU = true;
            }
            foreach (var contr in contrasenias)
            {
                if (contr.ToString() == contrasena.Text)
                    banderaC = true;
            }
            if (banderaC && banderaU)
            {
                Form2 principal = new Form2();
                this.Hide();
                principal.Show();
            }
            else
                MessageBox.Show("El usuario no existe o contraseña es incorrecta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
