using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIB_HCI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            resultados.Visible = false;
            resultados.Location = new Point(0, 0);
            cancelarCC.Location = new Point(0, 0);
            CabiarContra.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/home");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/?hl=es-419");
        }
        String covid19 = "Son una gran familia de virus que causan enfermedades que van desde el resfriado común hasta enfermedades más graves";
        String cuarentena = "Aislamiento de personas o animales durante un período de tiempo no específico como método para evitar o limitar el riesgo de que se extienda una enfermedad o una plaga.";
        String pandemia = "Enfermedad epidémica que se extiende a muchos países o que ataca a casi todos los individuos de una localidad o región";
        String PAcovid = "CORONAVIRUS\n" + "SARS-CoV-2\n" + "VIRUS";
        String PAcuarentena = "AISLAMIENTO\n" + "CONFINAMIENTO\n" + "ENCIERRO";
        String PApandemia = "EPIDEMIA\n" + "PESTE\n" + "ENDEMIA";

        private void button1_Click(object sender, EventArgs e)
        {
            inicio.Visible = false;
            CabiarContra.Visible = false;
            resultados.Visible = true;
            entrada.Enabled = false;
            if (filtrar.Text.ToLower() == "covid19")
            {
                definicion.Text = covid19;
                palabras.Text = PAcovid;

                Image covid1 = Image.FromFile("coronavirus.png");
                Image covid2 = Image.FromFile("coronavirus1.png");
                grafico1.BackgroundImage = covid1;
                grafico2.BackgroundImage = covid2;
            }
            else if (filtrar.Text.ToLower() == "cuarentena")
            {
                definicion.Text = cuarentena;
                palabras.Text = PAcuarentena;
             
                Image cuarentena1 = Image.FromFile("cuarentena.png");
                Image cuarentena2 = Image.FromFile("cuarentena1.png");
                grafico1.BackgroundImage = cuarentena1;
                grafico2.BackgroundImage = cuarentena2;
  
            }
            else if (filtrar.Text.ToLower() == "pandemia")
            {
                definicion.Text = pandemia;
                palabras.Text = PApandemia;

                Image pandemia1 = Image.FromFile("pandemia.png");
                Image pandemia2 = Image.FromFile("insolation.png");
                grafico1.BackgroundImage = pandemia1;
                grafico2.BackgroundImage = pandemia2;
            }
            else
            {               
                inicio.Visible = true;
                CabiarContra.Visible = false;
                resultados.Visible = false;
                entrada.Enabled = true;
                filtrar.Text = "";
                MessageBox.Show("No se encontraron resultados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            entrada.Enabled = true;
            CabiarContra.Visible = false;
            inicio.Visible = true;
            resultados.Visible =false;
            definicion.Text = "";
            palabras.Text = "";
            filtrar.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inicio.Visible = false;
            resultados.Visible = false;
            entrada.Enabled = false;
            CabiarContra.Visible = true;
            usuarioCC.Text = nomUsuario.Text;
            usuarioCC.Enabled = false;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            inicio.Visible = false;
            resultados.Visible = false;
            entrada.Enabled = false;
            CabiarContra.Visible = true;
            usuarioCC.Text = nomUsuario.Text;
            usuarioCC.Enabled = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            inicio.Visible = false;
            resultados.Visible = false;
            entrada.Enabled = false;
            CabiarContra.Visible = true;
            usuarioCC.Text = nomUsuario.Text;
            usuarioCC.Enabled = false;
        }

        private void cancelarCC_Click(object sender, EventArgs e)
        {
            inicio.Visible = true;
            resultados.Visible = false;
            entrada.Enabled = true;
            CabiarContra.Visible = false;
            filtrar.Text = "";
        }

        private void guardarCC_Click(object sender, EventArgs e)
        {
            inicio.Visible = true;
            resultados.Visible = false;
            entrada.Enabled = true;
            CabiarContra.Visible = false;
            filtrar.Text = "";
        }
    }
}
