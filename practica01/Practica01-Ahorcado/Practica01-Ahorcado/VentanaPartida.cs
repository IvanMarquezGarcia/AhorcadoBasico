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
    public partial class VentanaPartida : Form
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
        private int fallosPermitidos = 7;
        private int fallos = 0;
        /*private Boolean primarioPersonalizado = false;
        private IEnumerable<Control> controles;
        private Type[] tiposAspectoAuto = {
                                            typeof(ButtonBase),
                                            typeof(Button),
                                            typeof(ComboBox)
                                          };*/

        public VentanaPartida()
        {

            InitializeComponent();

            Color transparencia = Color.FromArgb(200, 150, 0);
            this.TransparencyKey = transparencia;
            this.BackColor = transparencia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Cursor = new Cursor(@"imagenes\cursor.cur");

            cargarCategorias();

           // controles = Controls.Cast<Control>();
        }



        private void cargarCategorias()
        {
            String rutaArchivo = @"archivoPalabras.xml";

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



        /* private void ajustarAspecto(Control c, int rol)
         {
             if (c.Enabled == true)
             {
                 switch (rol)
                 {
                     case 0: // compononte primario
                         //c.BackColor = miColorCompPrimario;
                         c.BackColor = miColorCompActivo;
                         ((Button)(c)).FlatAppearance.BorderSize = 5;
                         ((Button)(c)).FlatAppearance.BorderColor = ControlPaint.Dark(((Button)(c)).BackColor);
                         break;

                     case 1: // componente secundario
                         c.BackColor = miColorCompSecundario;
                         ((Button)(c)).FlatAppearance.BorderSize = 0;
                         break;

                     default: // componente cualquiera
                         c.BackColor = miColorCompActivo;
                         ((Button)(c)).FlatAppearance.BorderSize = 0;
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



        /*private void ajustarAspecto(IEnumerable<Control> controles)
        {
            for (int i = 0; i < controles.Count(); i++)
            {
                Control c = controles.ElementAt(i);

                Boolean tipoCorrecto = false;
                for (int j = 0; j < tiposAspectoAuto.Length; j++)
                {
                    if (c.GetType() == tiposAspectoAuto.ElementAt(j))
                        tipoCorrecto = true;
                }

                if (tipoCorrecto == true)
                {
                    //if (c.BackColor != null)
                    //{
                        // MessageBox.Show(c.Name); // control
                        if (c.Enabled == false)
                        {
                            if (c.GetType() == typeof(Button))
                            {
                                if (((Button)c).Name.Equals("volver_button") && primarioPersonalizado == true)
                                {
                                    desformatearControlPrimario(c);
                                    MessageBox.Show("desformateo volver" + primarioPersonalizado); // control
                                }
                                else if (((Button)c).Name.Equals("jugar_button") && primarioPersonalizado == true)
                                {
                                    if (volver_button.Enabled == false)
                                        desformatearControlPrimario(c);
                                    else
                                    {
                                        ((Button)c).FlatAppearance.BorderSize = 0;
                                        c.BackColor = miColorCompInactivo;
                                    }
                                    MessageBox.Show("desformateo juegar" + primarioPersonalizado); // control
                                }
                                else if (((Button)c).Name.Equals("adivinar_button") && primarioPersonalizado == true)
                                {
                                    desformatearControlPrimario(c);
                                    MessageBox.Show("desformateo adivinar" + primarioPersonalizado); // control
                                }
                                else
                                {
                                    c.BackColor = miColorCompInactivo;
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
                                    catch (ArgumentException ae)
                                    {
                                        c.BackColor = miNegro;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (c.GetType() == typeof(Button))
                            {
                                if (((Button)c).Name.Equals("adivinar_button") && primarioPersonalizado == false)
                                {
                                    formatearControlPrimario(c);
                                    MessageBox.Show("formateo adivinar" + primarioPersonalizado); // control
                                }
                                //else if (((Button)c).Name.Equals("jugar_button") && primarioPersonalizado == false)
                                //{
                                  //  formatearControlPrimario(c);
                                    // MessageBox.Show("juega" + primarioPersonalizado); // control
                                //}
                                else if (((Button)c).Name.Equals("volver_button") && primarioPersonalizado == false)
                                {
                                    formatearControlPrimario(c);
                                    MessageBox.Show("formateo volver" + primarioPersonalizado); // control
                                }
                                else if (((Button)c).Name.Contains("Letra"))
                                    c.BackColor = Color.Transparent;
                                else
                                    c.BackColor = miColorCompActivo;
                            }
                        }
                    //}
                }
                else if (c.GetType() == typeof(Panel))
                {
                    IEnumerable<Control> controlesAnidados = c.Controls.Cast<Control>();

                    if (c.Enabled == false)
                    {
                        for (int j = 0; j < controlesAnidados.Count(); j++)
                        {
                            try
                            {
                                controlesAnidados.ElementAt(j).BackColor = miColorCompInactivo;
                            } catch (Exception exei) {}
                        }
                    }
                    else
                    {
                        MessageBox.Show(c.Name + ""); // control
                        MessageBox.Show("manolo entra y llama recursivamente");
                        MessageBox.Show("Antes de recursivo " + primarioPersonalizado);
                        ajustarAspecto(controlesAnidados);
                        MessageBox.Show("Despues de recursivo " + primarioPersonalizado);
                    }
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

            //ajustarAspecto(controles);
            //ajustarAspecto(jugar_button, 0);

        }



        private void prepararRonda()
        {
            pictureBox.Image = null;

            reiniciarCtrlsPartida();

            desactivarCtrlsPartida();

            activarCtrlsConf();

            //ajustarAspecto(jugar_button, 0);
            

            //ajustarAspecto(categorias_comboBox, 2);

            volver_button.BackColor = miColorCompSecundario;

            fallos = 0;

            rondasJugadas++;

            //ajustarAspecto(controles);
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
                //salir_button.Text = "Terminar partida";
                //jugar_button.Text = "Siguiente palabra";
            }
            else
            {
                prepararRonda();
                siguientePalabra();
            }

            categorias_comboBox.Enabled = false;
            //ajustarAspecto(categorias_comboBox, 2);

            activarCtrlsPartida();

            //ajustarAspecto(jugar_button, 0);

            jugar_button.Enabled = false;
            desformatearControlPrimario(jugar_button);

            puntuacion_label.ForeColor = miColorCompSecundario;
            valorPuntuacion_label.ForeColor = miColorCompSecundario;
            intentos_label.ForeColor = miColorCompSecundario;
            valorIntentos_label.ForeColor = miColorCompSecundario;
            categoria_label.ForeColor = miColorCompSecundario;

            //jugar_button.BackColor = miColorCompInactivo;

            //ajustarAspecto(controles);////////////////////////////////////////////////////
        }



        private void fallado()
        {
            fallos++;

            if (fallos >= fallosPermitidos)
                finPartida(true);
            else
                pictureBox.Image = Image.FromFile(@"imagenes\fallo" + fallos + ".png");
        }

        
        
        private void letra_button_Click(object sender, EventArgs e)
        {
            valorIntentos_label.Text = (int.Parse(valorIntentos_label.Text) + 1).ToString();

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
            {
                valorPuntuacion_label.Text = (int.Parse(valorPuntuacion_label.Text) - 1).ToString();
                fallado();
            }
            else
            {
                misteriosa_label.Text = misteriosaMostrada;

                if (misteriosaMostrada.Contains("_") == false)
                {
                    valorPuntuacion_label.Text = (int.Parse(valorPuntuacion_label.Text) + 10).ToString();
                    //sugeridas_FlowPane.Controls.Clear();
                    prepararRonda();
                }
                else
                    valorPuntuacion_label.Text = (int.Parse(valorPuntuacion_label.Text) + 2).ToString();
            }

            ((Button)sender).Enabled = false;
            //ajustarAspecto(((Button)sender), 10);
            //ajustarAspecto(controles); /////////////////////////////////////////////////////////////////////////
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
            valorIntentos_label.Text = (int.Parse(valorIntentos_label.Text) + 1).ToString();

            if (sugerida_textBox.Text.ToUpper().Equals(palabra))
            {
                misteriosa_label.Text = palabra;
                valorPuntuacion_label.Text = (int.Parse(valorPuntuacion_label.Text) + 10).ToString();

                //prepararRonda();
                sugeridas_FlowPane.Controls.Clear();
                desactivarCtrlsPartida();
                activarCtrlsConf();
            }
            else
            {
                valorPuntuacion_label.Text = (int.Parse(valorPuntuacion_label.Text) - 5).ToString();
                
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
            desactivarCtrlsConf();
            desactivarCtrlsPartida();
            this.BackgroundImage = Image.FromFile(@"imagenes\bgBack.png");

            if (fallos != 0)
            {
                if (fallos < fallosPermitidos)
                    pictureBox.Image = Image.FromFile(@"imagenes\fallo" + fallos + "Back.png");
                else
                    pictureBox.Image = Image.FromFile(@"imagenes\muertoBack.png");
            }

            puntuacion_label.ForeColor = ControlPaint.Dark(puntuacion_label.ForeColor);
            valorPuntuacion_label.ForeColor = ControlPaint.Dark(valorPuntuacion_label.ForeColor);
            intentos_label.ForeColor = ControlPaint.Dark(intentos_label.ForeColor);
            valorIntentos_label.ForeColor = ControlPaint.Dark(valorIntentos_label.ForeColor);
            jugar_button.BackColor = ControlPaint.Dark(jugar_button.BackColor);
            volver_button.BackColor = ControlPaint.Dark(volver_button.BackColor);
            misteriosa_label.ForeColor = ControlPaint.Dark(misteriosa_label.ForeColor);
            categoria_label.ForeColor = ControlPaint.Dark(categoria_label.ForeColor);
            sugerida_textBox.Visible = false;
            categorias_comboBox.Visible = false;
        }



        private void finPartida(Boolean muerto)
        {
            desformatearControlPrimario(adivinar_button);
            resultado_label.Text = "";

            if (muerto == true)
            {
                pictureBox.Image = Image.FromFile(@"imagenes\muerto.png");
                resultado_label.Text = "La palabra era " + palabra + "\n";
            }

            categorias_comboBox.Enabled = true;
            //ajustarAspecto(categorias_comboBox, 2);

            jugar_button.Enabled = true;
            //ajustarAspecto(jugar_button, 0);
            //jugar_button.BackColor = miColorCompActivo;

            //adivinar_button.BackColor = miColorCompInactivo;

            volver_button.Text = "Volver a inicio";

            jugar_button.Text = "Jugar";
            formatearControlPrimario(jugar_button);

            resultado_label.Text += "Rondas totales > " + rondasJugadas +
                                    "\nPuntuación > " + valorPuntuacion_label.Text +
                                    "\nIntentos totales > " + valorIntentos_label.Text +
                                    "\nFallos > " + fallos;
            // o aqui
            mostrarResultado();
            //ajustarAspecto(controles); //////////////////////////////////////////////////////////////////////////////////////
        }



        private void ocultarResultados()
        {
            resultado_panel.Visible = false;
            this.BackgroundImage = Image.FromFile(@"imagenes\bgStandard.png");

            puntuacion_label.ForeColor = ControlPaint.LightLight(puntuacion_label.ForeColor);
            valorPuntuacion_label.ForeColor = ControlPaint.LightLight(valorPuntuacion_label.ForeColor);
            intentos_label.ForeColor = ControlPaint.LightLight(intentos_label.ForeColor);
            valorIntentos_label.ForeColor = ControlPaint.LightLight(valorIntentos_label.ForeColor);
            volver_button.BackColor = ControlPaint.LightLight(volver_button.BackColor);
            jugar_button.BackColor = ControlPaint.LightLight(jugar_button.BackColor);
            sugerida_textBox.Visible = true;
            categoria_label.ForeColor = ControlPaint.Light(valorIntentos_label.ForeColor);
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
            desformatearControlPrimario(adivinar_button);
            controlesPartida_panel.Enabled = false;
        }



        private void desactivarCtrlsConf()
        {
            desformatearControlPrimario(jugar_button);
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
        }


        private void reiniciarMarcadores()
        {
            valorIntentos_label.Text = "0";
            valorPuntuacion_label.Text = "0";
            rondasJugadas = 0;
            fallos = 0;
            misteriosa_label.Text = "";
        }



        private void volver_button_Click(Object sender, EventArgs e)
        {
            String buttonText = ((Button)(sender)).Text;

            if (buttonText.Equals("Terminar partida"))
            {
                finPartida(false);
            }
            else if (buttonText.Equals("Volver a inicio"))
            {
                Inicio ini = new Inicio();
                ini.Show();
                
                this.Close();
            }
        }
    }
}
