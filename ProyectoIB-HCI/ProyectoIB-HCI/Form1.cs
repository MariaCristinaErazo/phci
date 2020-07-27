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

namespace ProyectoIB_HCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayList usuarios = new ArrayList();
            ArrayList contrasenias = new ArrayList();
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
            foreach(var usr in usuarios)
            {
                if (usr == usuario.Text)
            }
            
            Form2 principal = new Form2();
            this.Hide();
            principal.Show();
        }
    }
}
