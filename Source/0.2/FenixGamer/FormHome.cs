// Fenix Gamer 0.2
// © Ismael Heredia , Argentina , 2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Net;
using System.Media;

namespace FenixGamer
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            cmbOpciones.SelectedIndex = 0;
            SoundPlayer sound = new SoundPlayer(FenixGamer.Properties.Resources.formcreate);
            sound.Play();
        }

        public string limpiar(string texto)
        {
            string limpiar_linea = texto;
            limpiar_linea = limpiar_linea.Replace("&aacute;", "a");
            limpiar_linea = limpiar_linea.Replace("&bacute;", "b");
            limpiar_linea = limpiar_linea.Replace("&cacute;", "c");
            limpiar_linea = limpiar_linea.Replace("&dacute;", "d");
            limpiar_linea = limpiar_linea.Replace("&eacute;", "e");
            limpiar_linea = limpiar_linea.Replace("&facute;", "f");
            limpiar_linea = limpiar_linea.Replace("&gacute;", "g");
            limpiar_linea = limpiar_linea.Replace("&hacute;", "h");
            limpiar_linea = limpiar_linea.Replace("&iacute;", "i");
            limpiar_linea = limpiar_linea.Replace("&jacute;", "j");
            limpiar_linea = limpiar_linea.Replace("&kacute;", "k");
            limpiar_linea = limpiar_linea.Replace("&lacute;", "l");
            limpiar_linea = limpiar_linea.Replace("&macute;", "m");
            limpiar_linea = limpiar_linea.Replace("&nacute;", "n");
            limpiar_linea = limpiar_linea.Replace("&oacute;", "o");
            limpiar_linea = limpiar_linea.Replace("&pacute;", "p");
            limpiar_linea = limpiar_linea.Replace("&qacute;", "q");
            limpiar_linea = limpiar_linea.Replace("&racute;", "r");
            limpiar_linea = limpiar_linea.Replace("&sacute;", "s");
            limpiar_linea = limpiar_linea.Replace("&tacute;", "t");
            limpiar_linea = limpiar_linea.Replace("&uacute;", "u");
            limpiar_linea = limpiar_linea.Replace("&vacute;", "v");
            limpiar_linea = limpiar_linea.Replace("&wacute;", "w");
            limpiar_linea = limpiar_linea.Replace("&xacute;", "x");
            limpiar_linea = limpiar_linea.Replace("&yacute;", "y");
            limpiar_linea = limpiar_linea.Replace("&zacute;", "z");
            limpiar_linea = limpiar_linea.Replace("&Aacute;", "A");
            limpiar_linea = limpiar_linea.Replace("&Bacute;", "B");
            limpiar_linea = limpiar_linea.Replace("&Cacute;", "C");
            limpiar_linea = limpiar_linea.Replace("&Dacute;", "D");
            limpiar_linea = limpiar_linea.Replace("&Eacute;", "E");
            limpiar_linea = limpiar_linea.Replace("&Facute;", "F");
            limpiar_linea = limpiar_linea.Replace("&Gacute;", "G");
            limpiar_linea = limpiar_linea.Replace("&Hacute;", "H");
            limpiar_linea = limpiar_linea.Replace("&Iacute;", "I");
            limpiar_linea = limpiar_linea.Replace("&Jacute;", "J");
            limpiar_linea = limpiar_linea.Replace("&Kacute;", "K");
            limpiar_linea = limpiar_linea.Replace("&Lacute;", "L");
            limpiar_linea = limpiar_linea.Replace("&Macute;", "M");
            limpiar_linea = limpiar_linea.Replace("&Nacute;", "N");
            limpiar_linea = limpiar_linea.Replace("&Oacute;", "O");
            limpiar_linea = limpiar_linea.Replace("&Pacute;", "P");
            limpiar_linea = limpiar_linea.Replace("&Qacute;", "Q");
            limpiar_linea = limpiar_linea.Replace("&Racute;", "R");
            limpiar_linea = limpiar_linea.Replace("&Sacute;", "S");
            limpiar_linea = limpiar_linea.Replace("&Tacute;", "T");
            limpiar_linea = limpiar_linea.Replace("&Uacute;", "U");
            limpiar_linea = limpiar_linea.Replace("&Vacute;", "V");
            limpiar_linea = limpiar_linea.Replace("&Wacute;", "W");
            limpiar_linea = limpiar_linea.Replace("&Xacute;", "X");
            limpiar_linea = limpiar_linea.Replace("&Yacute;", "Y");
            limpiar_linea = limpiar_linea.Replace("&Zacute;", "Z");
            return limpiar_linea;
        }

        public string cargar_con_control(string pagina)
        {
            string codigo = "";
            WebClient web = new WebClient();
            web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            try
            {
                codigo = web.DownloadString(pagina);
            }
            catch
            {
                codigo = "";
            }
            return codigo;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            SoundPlayer sound = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound.Play();

            List<string> contenidos = new List<string> { };

            status.Text = "[+] Cargando ...";
            this.Refresh();

            //

            string pagina = "http://www.topjuegos.net/";
            string nombre = txtNombreJuego.Text.ToLower();
            nombre = nombre.Replace(" ", "_");
            if (cmbOpciones.Text == "Trucos")
            {
                nombre = "trucos_" + nombre;
            }

            string pagina_final = pagina + nombre + ".html";

            //

            //

            string pagina_imagen = "http://www.topjuegos.net/img/";
            string nombre_imagen = txtNombreJuego.Text.ToLower();
            nombre_imagen = nombre_imagen.Replace(" ", "_");

            string pagina_final_imagen = pagina_imagen + nombre_imagen + ".jpg";
            //

            if (cmbOpciones.Text == "Trucos")
            {
                rtbTrucos.Clear();
                string codigofuente = cargar_con_control(pagina_final);
                Match search = Regex.Match(codigofuente, "<div align=\"justify\" class=\"division_valoracion\">(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (search.Success)
                {
                    string contenido = search.Groups[1].Value;
                    contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                    contenido = Regex.Replace(contenido, @"\s", " ");
                    contenido = Regex.Replace(contenido, @"\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s", "\n");

                    string[] lineas = Regex.Split(contenido, "\n");

                    foreach (string linea in lineas)
                    {
                        string linea_normal = linea;
                        linea_normal = Regex.Replace(linea_normal, @"\s{2,}", " ");
                        rtbTrucos.AppendText(limpiar(linea_normal) + "\n");
                    }
                }
                else
                {
                    search = Regex.Match(codigofuente, "<div align=\"justify\" class=\"division_trucos\">(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    if (search.Success)
                    {
                        string contenido = search.Groups[1].Value;
                        contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                        contenido = Regex.Replace(contenido, @"\s", " ");
                        contenido = Regex.Replace(contenido, @"\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s", "\n");

                        string[] lineas = Regex.Split(contenido, "\n");

                        foreach (string linea in lineas)
                        {
                            string linea_normal = linea;
                            linea_normal = Regex.Replace(linea_normal, @"\s{2,}", " ");
                            rtbTrucos.AppendText(limpiar(linea_normal) + "\n");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron trucos");
                    }
                }
            }

            //

            if (cmbOpciones.Text == "Descripcion")
            {
                rtbTrucos.Clear();
                string codigofuente = cargar_con_control(pagina_final);
                Match search = Regex.Match(codigofuente, "<div class=\"division_valoracion\">(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (search.Success)
                {
                    string contenido = search.Groups[1].Value;
                    contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                    contenido = Regex.Replace(contenido, @"\s", " ");
                    contenido = Regex.Replace(contenido, @"\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s", "\n");

                    string[] lineas = Regex.Split(contenido, "\n");

                    foreach (string linea in lineas)
                    {
                        string linea_normal = linea;
                        linea_normal = Regex.Replace(linea_normal, @"\s{2,}", " ");
                        rtbTrucos.AppendText(limpiar(linea_normal) + "\n");
                    }
                }
                else
                {
                    search = Regex.Match(codigofuente, "<div align=\"justify\" class=\"division_trucos\">(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    if (search.Success)
                    {
                        string contenido = search.Groups[1].Value;
                        contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                        contenido = Regex.Replace(contenido, @"\s", " ");
                        contenido = Regex.Replace(contenido, @"\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s\s", "\n");

                        string[] lineas = Regex.Split(contenido, "\n");

                        foreach (string linea in lineas)
                        {
                            string linea_normal = linea;
                            linea_normal = Regex.Replace(linea_normal, @"\s{2,}", " ");
                            rtbTrucos.AppendText(limpiar(linea_normal) + "\n");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro descripcion");
                    }
                }
            }

            //

            if (cmbOpciones.Text == "Informacion")
            {

                pbPreview.Image = null;
                txtDesarrollador.Text = "";
                txtDistribuidor.Text = "";
                txtTipo.Text = "";
                txtSubtitulos.Text = "";
                txtDialogos.Text = "";
                txtFormato.Text = "";
                txtPrecio.Text = "";
                txtWeb.Text = "";
                txtRelacionados.Text = "";

                string codigofuente = cargar_con_control(pagina_final);

                bool si = false;
                Match search = Regex.Match(codigofuente, "MENU", RegexOptions.IgnoreCase);
                if (search.Success)
                {
                    si = true;
                }
                else
                {
                   search = Regex.Match(codigofuente, "INFO", RegexOptions.IgnoreCase);
                   if (search.Success)
                   {
                       si = true;
                   }
                   else
                   {
                       si = false;
                   }
                }

                if (!si)
                {
                    MessageBox.Show("No se encontro juego");
                }
                else
                {
                    bool test = true;
                    search = Regex.Match(codigofuente, "class=\"division_requisitos\"(.*?)>(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    while (search.Success)
                    {
                        test = false;
                        string contenido = search.Groups[2].Value;
                        contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                        contenido = Regex.Replace(contenido, @"\s{2,}", " ");
                        contenidos.Add(contenido);
                        search = search.NextMatch();
                    }

                    if (!test)
                    {
                        search = Regex.Match(codigofuente, "<font face=\"Arial, Helvetica, sans-serif\" size=\"2\" color=\"#FFCC00\">(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        while (search.Success)
                        {
                            test = true;
                            string contenido = search.Groups[1].Value;
                            contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                            contenido = Regex.Replace(contenido, @"\s{2,}", " ");
                            contenidos.Add(contenido);
                            search = search.NextMatch();
                        }
                    }


                    string informacion = limpiar(contenidos[0]);
                    informacion = informacion.Replace("&euro;", " euros");
                    informacion = informacion.Replace("&ordf;", "D");
                    string requisitos_minimos = limpiar(contenidos[1]);
                    string requisitos_recomendados = limpiar(contenidos[2]);

                    var peticion = WebRequest.Create(pagina_final_imagen);
                    var respuesta = peticion.GetResponse();
                    var mostrar = respuesta.GetResponseStream();
                    pbPreview.Image = Bitmap.FromStream(mostrar);

                    search = Regex.Match(informacion, "Desarrollador:(.*) Distribuidor", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtDesarrollador.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtDesarrollador.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Distribuidor:(.*) Adese", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtDistribuidor.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtDistribuidor.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Tipo:(.*) Multijugador", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtTipo.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtTipo.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Idioma (.*):(.*) Formato", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtSubtitulos.Text = search.Groups[2].Value;
                    }
                    else
                    {
                        txtSubtitulos.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Di(.*)logos:(.*) Formato", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtDialogos.Text = search.Groups[2].Value;
                    }
                    else
                    {
                        txtDialogos.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Formato:(.*) Precio", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtFormato.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtFormato.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Precio Salida:(.*) Web", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtPrecio.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtPrecio.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Web Oficial:(.*) Relacionados", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtWeb.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtWeb.Text = "No disponible";
                    }

                    search = Regex.Match(informacion, "Relacionados:(.*)", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtRelacionados.Text = search.Groups[1].Value;

                    }
                    else
                    {
                        txtRelacionados.Text = "No disponible";
                    }

                }
            }

            if (cmbOpciones.Text == "Requisitos Minimos")
            {

                txtProcesador.Text = "";
                txtMemoria.Text = "";
                txtDiscoDuro.Text = "";
                txtTarjetaGrafica.Text = "";

                string codigofuente = cargar_con_control(pagina_final);

                bool si = false;
                Match search = Regex.Match(codigofuente, "MENU", RegexOptions.IgnoreCase);
                if (search.Success)
                {
                    si = true;
                }
                else
                {
                   search = Regex.Match(codigofuente, "INFO", RegexOptions.IgnoreCase);
                   if (search.Success)
                   {
                       si = true;
                   }
                   else
                   {
                       si = false;
                   }
                }

                if (!si)
                {
                    MessageBox.Show("No se encontro el juego");
                }
                else
                {
                    search = Regex.Match(codigofuente, "class=\"division_requisitos\"(.*?)>(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    while (search.Success)
                    {
                        string contenido = search.Groups[2].Value;
                        contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                        contenido = Regex.Replace(contenido, @"\s{2,}", " ");
                        contenidos.Add(contenido);
                        search = search.NextMatch();
                    }

                    string informacion = limpiar(contenidos[0]);
                    informacion = informacion.Replace("&euro;", " euros");
                    string requisitos_minimos = limpiar(contenidos[1]);
                    string requisitos_recomendados = limpiar(contenidos[2]);

                    search = Regex.Match(requisitos_minimos, "Procesador:(.*) Memoria", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtProcesador.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtProcesador.Text = "No disponible";
                    }

                    search = Regex.Match(requisitos_minimos, "Memoria:(.*) Disco", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtMemoria.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtMemoria.Text = "No disponible";
                    }

                    search = Regex.Match(requisitos_minimos, "Disco duro:(.*) T. Gra", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtDiscoDuro.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        search = Regex.Match(requisitos_minimos, "Disco duro:(.*) Gr", RegexOptions.IgnoreCase);
                        if (search.Success)
                        {
                            txtDiscoDuro.Text = search.Groups[1].Value;
                        }
                        else
                        {
                            txtDiscoDuro.Text = search.Groups[1].Value;
                        }
                    }
                    search = Regex.Match(requisitos_minimos, "T. Grafica: (.*)", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtTarjetaGrafica.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        search = Regex.Match(requisitos_minimos, "Gr(.*)ficos: (.*)", RegexOptions.IgnoreCase);
                        if (search.Success)
                        {
                            txtTarjetaGrafica.Text = search.Groups[2].Value;
                        }
                        else
                        {
                            txtTarjetaGrafica.Text = "No disponible";
                        }
                    }

                    //
                    if (txtProcesador.Text == "")
                    {
                        txtProcesador.Text = "No disponible";
                    }
                    if (txtMemoria.Text == "")
                    {
                        txtMemoria.Text = "No disponible";
                    }
                    if (txtDiscoDuro.Text == "")
                    {
                        txtDiscoDuro.Text = "No disponible";
                    }
                    if (txtTarjetaGrafica.Text == "")
                    {
                        txtTarjetaGrafica.Text = "No disponible";
                    }
                    //
                }
            }

            if (cmbOpciones.Text == "Requisitos Recomendados")
            {

                txtProcesador.Text = "";
                txtMemoria.Text = "";
                txtDiscoDuro.Text = "";
                txtTarjetaGrafica.Text = "";

                string codigofuente = cargar_con_control(pagina_final);

                bool si = false;
                Match search = Regex.Match(codigofuente, "MENU", RegexOptions.IgnoreCase);
                if (search.Success)
                {
                    si = true;
                }
                else
                {
                    search = Regex.Match(codigofuente, "INFO", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        si = true;
                    }
                    else
                    {
                        si = false;
                    }
                }

                if (!si)
                {
                    MessageBox.Show("No se encontro el juego");
                }
                else
                {
                    search = Regex.Match(codigofuente, "class=\"division_requisitos\"(.*?)>(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    while (search.Success)
                    {
                        string contenido = search.Groups[2].Value;
                        contenido = Regex.Replace(contenido, @"<[^>]+>|&nbsp;", "").Trim();
                        contenido = Regex.Replace(contenido, @"\s{2,}", " ");
                        contenidos.Add(contenido);
                        search = search.NextMatch();
                    }

                    string informacion = limpiar(contenidos[0]);
                    informacion = informacion.Replace("&euro;", " euros");
                    string requisitos_minimos = limpiar(contenidos[1]);
                    string requisitos_recomendados = limpiar(contenidos[2]);

                    search = Regex.Match(requisitos_recomendados, "Procesador:(.*) Memoria", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtProcesador.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtProcesador.Text = "No disponible";
                    }

                    search = Regex.Match(requisitos_recomendados, "Memoria:(.*) Disco", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtMemoria.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        txtMemoria.Text = "No disponible";
                    }

                    search = Regex.Match(requisitos_recomendados, "Disco duro:(.*) T. Gra", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtDiscoDuro.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        search = Regex.Match(requisitos_recomendados, "Disco duro:(.*) Gr", RegexOptions.IgnoreCase);
                        if (search.Success)
                        {
                            txtDiscoDuro.Text = search.Groups[1].Value;
                        }
                        else
                        {
                            txtDiscoDuro.Text = search.Groups[1].Value;
                        }
                    }
                    search = Regex.Match(requisitos_recomendados, "T. Grafica: (.*)", RegexOptions.IgnoreCase);
                    if (search.Success)
                    {
                        txtTarjetaGrafica.Text = search.Groups[1].Value;
                    }
                    else
                    {
                        search = Regex.Match(requisitos_recomendados, "Gr(.*)ficos: (.*)", RegexOptions.IgnoreCase);
                        if (search.Success)
                        {
                            txtTarjetaGrafica.Text = search.Groups[2].Value;
                        }
                        else
                        {
                            txtTarjetaGrafica.Text = "No disponible";
                        }
                    }
                    //
                    if (txtProcesador.Text == "")
                    {
                        txtProcesador.Text = "No disponible";
                    }
                    if (txtMemoria.Text == "")
                    {
                        txtMemoria.Text = "No disponible";
                    }
                    if (txtDiscoDuro.Text == "")
                    {
                        txtDiscoDuro.Text = "No disponible";
                    }
                    if (txtTarjetaGrafica.Text == "")
                    {
                        txtTarjetaGrafica.Text = "No disponible";
                    }
                    //
                }
            }

            status.Text = "[+] Listo";
            this.Refresh();

            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.scanfin);
            sound1.Play();

        }

        private void desarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtDesarrollador.Text);
            }
            catch
            {
                //
            }
        }

        private void distribuidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtDistribuidor.Text);
            }
            catch
            {
                //
            }
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtTipo.Text);
            }
            catch
            {
                //
            }
        }

        private void idiomaSubtitulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtSubtitulos.Text);
            }
            catch
            {
                //
            }
        }

        private void dialogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtDialogos.Text);
            }
            catch
            {
                //
            }
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtFormato.Text);
            }
            catch
            {
                //
            }
        }

        private void precioSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtPrecio.Text);
            }
            catch
            {
                //
            }
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtWeb.Text);
            }
            catch
            {
                //
            }
        }

        private void RelacionadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtRelacionados.Text);
            }
            catch
            {
                //
            }
        }

        private void procesadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtProcesador.Text);
            }
            catch
            {
                //
            }
        }

        private void memoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtMemoria.Text);
            }
            catch
            {
                //
            }
        }

        private void discoDuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtDiscoDuro.Text);
            }
            catch
            {
                //
            }
        }

        private void tarjetaGraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtTarjetaGrafica.Text);
            }
            catch
            {
                //
            }
        }

        private void TrucosMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            if (rtbTrucos.Text == "")
            {
                MessageBox.Show("No hay trucos para guardar");
            }
            else
            {
                SaveFileDialog guardando = new SaveFileDialog();
                guardando.Filter = "Archivo de texto (*.txt)|*.txt";
                guardando.FilterIndex = 2;
                guardando.RestoreDirectory = true;

                if (guardando.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter creando = new System.IO.StreamWriter(
                    guardando.FileName, false, Encoding.ASCII);
                    string contenido = rtbTrucos.Text;
                    contenido = contenido.Replace("\n", "\r\n");
                    creando.Write(contenido);
                    creando.Close();
                    MessageBox.Show("Trucos guardados");
                    System.Diagnostics.Process.Start(guardando.FileName);
                }
            }
        }

        private void cmbOpciones_SelectedValueChanged(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            if (cmbOpciones.Text == "Descripcion")
            {
                gbTrucos.Text = "Descripcion";
            }
            if (cmbOpciones.Text == "Trucos")
            {
                gbTrucos.Text = "Trucos";
            }
        }

        private void lblPowered_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(FenixGamer.Properties.Resources.click);
            sound1.Play();
            System.Diagnostics.Process.Start("http://www.topjuegos.net");
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixGamer.Properties.Resources.formexit);
            sound.Play();
            System.Threading.Thread.Sleep(2500);
        }

    }
}
