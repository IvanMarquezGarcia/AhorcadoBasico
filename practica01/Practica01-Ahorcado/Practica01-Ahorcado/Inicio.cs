using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01_Ahorcado
{
    public partial class Inicio : Form
    {
        Boolean dosJ = false;
        public Inicio()
        {
            InitializeComponent();

            Color transparencia = Color.FromArgb(200, 150, 0);
            this.TransparencyKey = transparencia;
            this.BackColor = transparencia;
            this.Cursor = new Cursor(@"imagenes\cursor.cur");

        }

        private void nombreCambia(object sender, EventArgs e)
        {
            validarNombres();
        }

        private void jugar(object sender, EventArgs e)
        {
            if (dosJ == true)
            {
                VentanaPartida2 ventana = new VentanaPartida2(nombreJ1_textBox.Text, nombreJ2_textBox.Text);
                ventana.Show();
            }
            else
            {
                VentanaPartida ventana = new VentanaPartida();
                ventana.Show();
            }

            this.Close();
        }

        private void dosJ_button_Click(object sender, EventArgs e)
        {
            dosJ = !dosJ;

            if (dosJ == true)
            {
                dosJ_button.BackgroundImage = Image.FromFile("imagenes\\interruptorEncendido.png");
                nombreJ2_label.Visible = true;
                nombreJ2_textBox.Visible = true;
            }
            else
            {
                dosJ_button.BackgroundImage = Image.FromFile("imagenes\\interruptor.png");
                nombreJ2_label.Visible = false;
                nombreJ2_textBox.Visible = false;
            }

            validarNombres();
        }

        private void validarNombres()
        {
            if (dosJ == true)
            {
                if (nombreJ1_textBox.Text.Length > 0 && nombreJ2_textBox.Text.Length > 0)
                    jugar_button.Enabled = true;
                else
                    jugar_button.Enabled = false;
            }
            else
            {
                if (nombreJ1_textBox.Text.Length > 0)
                    jugar_button.Enabled = true;
                else
                    jugar_button.Enabled = false;
            }

            if (jugar_button.Enabled == true)
                jugar_button.ForeColor = Color.FromArgb(128, 70, 0);
            else
            {
                jugar_button.ForeColor = Color.Gray;
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
