using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml;

namespace Practica01_Ahorcado
{
    public partial class VentanaPartida2 : Form
    {
        public static Color miColorLetra = Color.FromArgb(151, 90, 15);
        //public static Color miColorCompActivo = Color.FromArgb(255, 199, 128);
        public static Color miColorCompInactivo = Color.Transparent;
        public static Color miColorCompPrimario = Color.FromArgb(255, 199, 128);
        public static Color miColorCompSecundario = ControlPaint.Light(miColorCompPrimario);
        public static Color miNegro = Color.DarkGray;
        private String categoria;
        private String palabra;
        private int rondasJugadas = 0;
        private int limiteMuertes = 3;
        private int muertesJ1 = 0;
        private int muertesJ2 = 0;
        private int fallosPermitidos = 7;
        private int fallos = 0;
        private String nombrej1 = "Jugador 1";
        private String nombrej2 = "Jugador 2";
        private Boolean turnoJ1 = false;
        /*private IEnumerable<Control> controles;
        private Type[] tiposAspectoAuto = { typeof(ButtonBase),
                                            typeof(Button),
                                            typeof(ComboBox)};*/

        public VentanaPartida2(String j1, String j2)
        {
            InitializeComponent();

            this.nombrej1 = j1;
            this.nombrej2 = j2;

            this.muertesJ1_label.Text = "Muertes de " + nombrej1 + " >";
            this.muertesJ2_label.Text = "Muertes de " + nombrej2 + " >";

            Color transparencia = Color.FromArgb(200, 150, 0);
            this.TransparencyKey = transparencia;
            this.BackColor = transparencia;

            this.Cursor = new Cursor(@"imagenes\cursor.cur");

            cargarCategorias();

            //controles = Controls.Cast<Control>();
        }



        private void cargarCategorias()
        {
            String rutaArchivo = "archivoPalabras.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(rutaArchivo);

            XmlNodeList categorias = doc.DocumentElement.ChildNodes;

            String[] nombresCategorias = new string[categorias.Count];

            for (int i = 0; i < nombresCategorias.Length; i++)
            {
                categorias_comboBox.Items.Add(categorias.Item(i).Attributes[1].Value);
               // MessageBox.Show(categorias_comboBox.Items[i].ToString()); // control
            }
        }



        private void formatearControlPrimario(Control c)
        {
            if (c.GetType() == typeof(Button))
            {
                c.BackColor = miColorCompPrimario;
                ((Button)c).FlatAppearance.BorderSize = 3;
                ((Button)c).FlatAppearance.BorderColor = ControlPaint.Dark(((Button)c).BackColor);
                c.ForeColor = miColorLetra;
            }
            //primarioPersonalizado = true;
        }



        private void desformatearControlPrimario(Control c)
        {
            if (c.GetType() == typeof(Button))
            {
                c.BackColor = miColorCompInactivo;
                ((Button)c).FlatAppearance.BorderSize = 0;
            }
            //primarioPersonalizado = false;
        }



        /*private void ajustarAspecto(Control c, int rol)
        {
            if (c.Enabled == true)
            {
                switch (rol)
                {
                    case 0: // compononte primario
                        c.BackColor = miColorCompPrimario;
                        break;

                    case 1: // componente secundario
                        c.BackColor = miColorCompSecundario;
                        break;

                    default: // componente cualquiera
                        c.BackColor = miColorCompActivo;
                        break;
                }
            }
            else
            {
                if (miColorCompInactivo != Color.Transparent)
                {
                    c.BackColor = miColorCompInactivo;
                }
                else
                {
                    try
                    {
                        c.BackColor = miColorCompInactivo;
                    }
                    catch (ArgumentException ae) { }
                }
            }
        }*/



        private XmlNode buscarCategoria(String categoria)
        {
            String rutaArchivo = "archivoPalabras.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(rutaArchivo);

            XmlNodeList categorias = doc.DocumentElement.ChildNodes;

            for (int i = 0; i < categorias.Count; i++)
            {
                //MessageBox.Show(categorias.Item(i).Attributes[1].Value); // control
                if (categorias.Item(i).Attributes[1].Value.Equals(categoria))
                    return categorias.Item(i);
            }

            return null;
        }


        
        public void elegirPalabra()
        {
            String rutaArchivo = "archivoPalabras.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(rutaArchivo);

            XmlNode categoriaNodo = buscarCategoria(this.categoria);

            XmlNodeList palabras = categoriaNodo.ChildNodes;

            Random r = new Random();

            this.palabra = palabras.Item(r.Next(0, palabras.Count - 1)).InnerText;
        }



        private void siguientePalabra()
        {
            misteriosa_label.Text = "";

            elegirPalabra();

            for (int i = 0; i < palabra.Length; i++)
            {
                if (i != 0)
                    misteriosa_label.Text += " ";

                misteriosa_label.Text += "_";
            }
        }



        private void categorias_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categorias_comboBox.SelectedIndex < 0 || categorias_comboBox.SelectedIndex > categorias_comboBox.Items.Count - 1)
            {
                jugar_button.Enabled = false;
                desformatearControlPrimario(jugar_button);
            }
            else
            {
                this.categoria = categorias_comboBox.SelectedItem.ToString();
                jugar_button.Enabled = true;
                formatearControlPrimario(jugar_button);
            }
        }



        private void cambiarTurno()
        {
            turnoJ1 = !turnoJ1;

            if (turnoJ1 == true)
                turno_label.Text = "Turno de " + nombrej1;
            else
                turno_label.Text = "Turno de " + nombrej2;
        }



        private void prepararRonda()
        {
            pictureBox.Image = null;

            reiniciarCtrlsPartida();

            desactivarCtrlsPartida();

            activarCtrlsConf();

            formatearControlPrimario(jugar_button);

            //ajustarAspecto(categorias_comboBox, 2);

            fallos = 0;

            cambiarTurno();

            rondasJugadas++;
        }



        private void iniciarJuego()
        {
            if (categorias_comboBox.SelectedIndex < 0 || categorias_comboBox.SelectedIndex > categorias_comboBox.Items.Count - 1)
            {
                categorias_comboBox.SelectedIndex = 0;
                // MessageBox.Show(categorias_comboBox.SelectedIndex.ToString()); // control
            }

            this.categoria = categorias_comboBox.SelectedItem.ToString();

            reiniciarMarcadores();

            volver_button.Text = "Terminar partida";
            jugar_button.Text = "Siguiente palabra";

            prepararRonda();
            siguientePalabra();
        }

        
        
        private void jugar_button_Click(object sender, EventArgs e)
        {
            if (((Button)(sender)).Text.Equals("Jugar"))
            {
                iniciarJuego();
                //volver_button.Text = "Terminar partida";
                //jugar_button.Text = "Siguiente palabra";
            }
            else
            {
                prepararRonda();
                siguientePalabra();
            }

            categorias_comboBox.Enabled = false;
            //ajustarAspecto(controles);
            //ajustarAspecto(categorias_comboBox, 2);

            activarCtrlsPartida();
            //controlesPartida_panel.Enabled = true;

            jugar_button.Enabled = false;
            desformatearControlPrimario(jugar_button);

            muertesJ1_label.ForeColor = miColorCompSecundario;
            valorMuertesJ1_label.ForeColor = miColorCompSecundario;
            muertesJ2_label.ForeColor = miColorCompSecundario;
            valorMuertesJ2_label.ForeColor = miColorCompSecundario;
            turno_label.ForeColor = miColorCompSecundario;
            categoria_label.ForeColor = miColorCompSecundario;
        }



        private void fallado()
        {
            fallos++;

            if (fallos >= fallosPermitidos)
            {
                finPartida(true, false);
            }
            else
                pictureBox.Image = Image.FromFile("imagenes\\fallo" + fallos + ".png");
        }

        
        
        private void letra_button_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            char letra = ((Button)sender).Name.ToString().ToUpper().First();

            char[] misteriosa = palabra.ToCharArray();

            String[] misteriosaLabelText = misteriosa_label.Text.Split(' ');

            String misteriosaMostrada = "";
            
            for (int i = 0; i < misteriosa.Length; i++)
            {
                if (misteriosa[i] == letra)
                {
                    misteriosa[i] = letra;
                    misteriosaLabelText[i] = letra + "";
                }

                if (i != 0)
                    misteriosaMostrada += ' ';

                misteriosaMostrada += misteriosaLabelText[i];
            }

            if (misteriosa_label.Text.Equals(misteriosaMostrada))
                fallado();
            else
            {
                misteriosa_label.Text = misteriosaMostrada;

                if (misteriosaMostrada.Contains("_") == false)
                    //prepararRonda();
                    finPartida(false, false);
            }
        }

        
        
        private void sugerida_textBox_TextChanged(object sender, EventArgs e)
        {
            if (sugerida_textBox.Text != "")
            {
                adivinar_button.Enabled = true;
                formatearControlPrimario(adivinar_button);
            }
            else
            {
                adivinar_button.Enabled = false;
                desformatearControlPrimario(adivinar_button);
            }
        }

        
        
        private void adivinar_button_Click(object sender, EventArgs e)
        {
            if (sugerida_textBox.Text.ToUpper().Equals(palabra))
            {
                misteriosa_label.Text = palabra;

                //prepararRonda();
                sugeridas_FlowPane.Controls.Clear();
                desactivarCtrlsPartida();
                activarCtrlsConf();

                finPartida(false, false);
            }
            else
            {
                fallado();

                Label nuevaFallida = new Label();
                nuevaFallida.Text = sugerida_textBox.Text;
                nuevaFallida.ForeColor = Color.FromArgb(166, 53, 18);
                nuevaFallida.Font = new Font(nuevaFallida.Font.FontFamily, 12, FontStyle.Strikeout | FontStyle.Bold);

                sugeridas_FlowPane.Controls.Add(nuevaFallida);
            }

            sugerida_textBox.Clear();
        }




        private void mostrarResultado()
        {
            resultado_panel.Visible = true;
            this.BackgroundImage = Image.FromFile(@"imagenes\bgBack.png");

            if (fallos != 0)
            {
                if (fallos < fallosPermitidos)
                    pictureBox.Image = Image.FromFile(@"imagenes\fallo" + fallos + "Back.png");
                else
                    pictureBox.Image = Image.FromFile(@"imagenes\muertoBack.png");
            }

            muertesJ1_label.ForeColor = ControlPaint.Dark(muertesJ1_label.ForeColor);
            muertesJ2_label.ForeColor = ControlPaint.Dark(muertesJ2_label.ForeColor);
            valorMuertesJ1_label.ForeColor = ControlPaint.Dark(valorMuertesJ1_label.ForeColor);
            valorMuertesJ2_label.ForeColor = ControlPaint.Dark(valorMuertesJ2_label.ForeColor);
            turno_label.ForeColor = ControlPaint.Dark(turno_label.ForeColor);
            jugar_button.BackColor = ControlPaint.Dark(jugar_button.BackColor);
            volver_button.BackColor = ControlPaint.Dark(volver_button.BackColor);
            categoria_label.ForeColor = ControlPaint.Dark(categoria_label.ForeColor);
            misteriosa_label.ForeColor = ControlPaint.Dark(misteriosa_label.ForeColor);
            sugerida_textBox.Visible = false;
            categorias_comboBox.Visible = false;
        }



        private void finPartida(Boolean muerto, Boolean forzar)
        {
            resultado_label.Text = "";
            
            Boolean fin = forzar;

            if (muerto == true)
            {
                pictureBox.Image = Image.FromFile("imagenes\\muerto.png");

                muertesJ1 = int.Parse(valorMuertesJ1_label.Text);
                muertesJ2 = int.Parse(valorMuertesJ2_label.Text);

                if (turnoJ1 == true)
                {
                    muertesJ1++;
                    valorMuertesJ1_label.Text = (muertesJ1) + "";
                }
                else
                {
                    muertesJ2++;
                    valorMuertesJ2_label.Text = (muertesJ2) + "";
                }

                if (muertesJ1 >= limiteMuertes)
                {
                    resultado_label.Text = nombrej2 + " GANA\n\n";
                    fin = true;
                }
                else if (muertesJ2 >= limiteMuertes)
                {
                    resultado_label.Text = nombrej1 + " GANA\n\n";
                    fin = true;
                }
            }

            if (fin == false)
            {
                prepararRonda();
                siguientePalabra();

                categorias_comboBox.Enabled = false;
                //ajustarAspecto(categorias_comboBox, 2);

                jugar_button.Enabled = false;
                desformatearControlPrimario(jugar_button);

                activarCtrlsPartida();
            } else
            {
                //ajustarAspecto(categorias_comboBox, 2);
                //ajustarAspecto(jugar_button, 0);
                desformatearControlPrimario(jugar_button);

                volver_button.Text = "Volver al inicio";
                jugar_button.Text = "Jugar";

                desactivarCtrlsConf();
                desactivarCtrlsPartida();

                resultado_label.Text += "Rondas totales > " + rondasJugadas +
                                        "\n\n" + nombrej1 +
                                        "\n\tMuertes > " + valorMuertesJ1_label.Text +
                                        "\n\n" + nombrej2 +
                                        "\n\tMuertes > " + valorMuertesJ2_label.Text;

                mostrarResultado();
            }
        }



        private void ocultarResultados()
        {
            resultado_panel.Visible = false;
            this.BackgroundImage = Image.FromFile(@"imagenes\bgStandard.png");

            muertesJ1_label.ForeColor = ControlPaint.LightLight(muertesJ1_label.ForeColor);
            muertesJ2_label.ForeColor = ControlPaint.LightLight(muertesJ2_label.ForeColor);
            valorMuertesJ1_label.ForeColor = ControlPaint.LightLight(valorMuertesJ1_label.ForeColor);
            valorMuertesJ2_label.ForeColor = ControlPaint.LightLight(valorMuertesJ2_label.ForeColor);
            turno_label.ForeColor = ControlPaint.LightLight(turno_label.ForeColor);
            categoria_label.ForeColor = ControlPaint.LightLight(categoria_label.ForeColor);
            volver_button.BackColor = ControlPaint.LightLight(volver_button.BackColor);
            misteriosa_label.ForeColor = ControlPaint.LightLight(misteriosa_label.ForeColor);
            sugerida_textBox.Visible = true;
            categorias_comboBox.Visible = true;
        }



        private void reiniciarCtrlsPartida()
        {
            for (int i = 0; i < controlesPartida_panel.Controls.Count; i++)
            {
                controlesPartida_panel.Controls[i].Enabled = true;
            }

            desformatearControlPrimario(adivinar_button);
            adivinar_button.Enabled = false;

            sugeridas_FlowPane.Controls.Clear();

            sugerida_textBox.Clear();

            ocultarResultados();
        }



        private void activarCtrlsPartida()
        {
            reiniciarCtrlsPartida();
            controlesPartida_panel.Enabled = true;
        }



        private void desactivarCtrlsPartida()
        {
            controlesPartida_panel.Enabled = false;
        }



        private void desactivarCtrlsConf()
        {
            controlesConfiguracion_panel.Enabled = false;
        }



        private void activarCtrlsConf()
        {
            for (int i = 0; i < controlesConfiguracion_panel.Controls.Count; i++)
                controlesConfiguracion_panel.Controls[i].Enabled = true;

            formatearControlPrimario(jugar_button);

            controlesConfiguracion_panel.Enabled = true;
        }



        private void resultado_button_Click(object sender, EventArgs e)
        {
            ocultarResultados();

            reiniciarMarcadores();
            
            prepararRonda();

            turnoJ1 = false;
        }


        private void reiniciarMarcadores()
        {
            valorMuertesJ1_label.Text = "0";
            valorMuertesJ2_label.Text = "0";
            rondasJugadas = 0;
            fallos = 0;
            misteriosa_label.Text = "";
        }



        private void salir_button_Click(Object sender, EventArgs e)
        {
            String buttonText = ((Button)(sender)).Text;

            if (buttonText.Equals("Terminar partida"))
                finPartida(false, true);
            else if (buttonText.Equals("Volver al inicio"))
            {
                Inicio ini = new Inicio();
                ini.Show();

                this.Close();
            }
        }



        /*
        private void ajustarAspecto(IEnumerable<Control> controles)
        {
            for (int i = 0; i < controles.Count(); i++)
            {
                Control c = controles.ElementAt(i);

                MessageBox.Show(c.Name + " " + c.GetType().IsInstanceOfType(typeof(Panel)) + ""); // control

                Boolean tipoCorrecto = false;
                for(int j = 0; j < tiposAspectoAuto.Length; j++)
                {
                    if (c.GetType() == tiposAspectoAuto.ElementAt(j))
                        tipoCorrecto = true;
                }

                if (tipoCorrecto == true)
                {
                    if (c.BackColor != null)
                    {
                        // MessageBox.Show(c.Name); // control
                        if (c.Enabled == false)
                        {
                            if (miColorCompInactivo != Color.Transparent)
                            {
                                c.BackColor = miColorCompInactivo;
                            }
                            else
                            {
                                try
                                {
                                    c.BackColor = miColorCompInactivo;
                                }
                                catch (ArgumentException ae) { }
                            }
                        }
                        else
                            c.BackColor = miColorCompActivo;

                        // MessageBox.Show(c.Name + " " + c.BackColor); // control
                    }
                }
                else if (c.GetType().IsInstanceOfType(typeof(Panel)))
                {
                    IEnumerable<Control> controlesAnidados = c.Controls.Cast<Control>();
                    ajustarAspecto(controlesAnidados);
                }
            }
        }
        */
    }
}
