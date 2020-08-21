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
            registro.Visible = false;
            usuarios = new ArrayList();
            contrasenias = new ArrayList();
            usuarios.Add("Edwin");
            contrasenias.Add("123");
            usuarios.Add("Maria Cristina");
            contrasenias.Add("m123");
            /*
            Form2 principal = new Form2();
            this.Hide();
            principal.Show();
            principal.nomUsuario.Text = usuario.Text;
            */
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
                principal.nomUsuario.Text = usuario.Text;

            }
            else
                MessageBox.Show("El usuario no existe o contraseña es incorrecta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bRegistrar1_Click(object sender, EventArgs e)
        {
            registro.Visible = true;
            inicioSesion.Visible = false;
            //

        }

        private void bRegistrar2_Click(object sender, EventArgs e)
        {
            usuarios.Add(usuario.Text.ToString());
            contrasenias.Add(contrasena.Text.ToString());
            registro.Visible = false;
            inicioSesion.Visible = true;
        }
    }
}
