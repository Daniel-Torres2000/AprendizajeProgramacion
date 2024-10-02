using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Interfaz_Base
{
    public partial class InterfazVisualBase : Form
    {
        #region MovimientoBarraTitulo
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion MovimientoBarraTitulo
        #region InicioFormulario
        public InterfazVisualBase()
        {
            InitializeComponent();
        }
        private void InterfazVisualBase_Load(object sender, EventArgs e)
        {
            StreamReader Lectura = new StreamReader(@"Tema Seleccionado.txt");
            string TemaSelect = Lectura.ReadLine();
            if (TemaSelect == "Red Blood")
            {
                BarraDeTitulo.BackColor = Color.FromArgb(88, 1, 3);
                PanelContenedor.BackColor = Color.FromArgb(140, 1, 3);
                Pestañas.BackColor = Color.FromArgb(88, 1, 3);
                PinLenguajes.BackColor = Color.FromArgb(42, 44, 49);
                PinArchivo.BackColor = Color.FromArgb(42, 44, 49);
                PinFormato.BackColor = Color.FromArgb(42, 44, 49);
                Archivo.BackColor = Color.FromArgb(88, 1, 3);
                Formato.BackColor = Color.FromArgb(88, 1, 3);
                Lenguajes.BackColor = Color.FromArgb(88, 1, 3);
                Abrir.BackColor = Color.FromArgb(88, 1, 3);
                Guardar.BackColor = Color.FromArgb(88, 1, 3);
                GuardarComo.BackColor = Color.FromArgb(88, 1, 3);
                Salir.BackColor = Color.FromArgb(88, 1, 3);
                Fuente.BackColor = Color.FromArgb(88, 1, 3);
                Temas.BackColor = Color.FromArgb(88, 1, 3);
                GrupoFormato.BackColor = Color.FromArgb(88, 1, 3);
                GrupoArchivo.BackColor = Color.FromArgb(88, 1, 3);
                GrupoLenguajes.BackColor = Color.FromArgb(88, 1, 3);

                Lenguajes.BackColor = Color.FromArgb(88, 1, 3);
                LengPSeint.BackColor = Color.FromArgb(88, 1, 3);
                LengC.BackColor = Color.FromArgb(88, 1, 3);
                LengDev.BackColor = Color.FromArgb(88, 1, 3);
                LengJava.BackColor = Color.FromArgb(88, 1, 3);
                LengCsharp.BackColor = Color.FromArgb(88, 1, 3);
                LengHtml.BackColor = Color.FromArgb(88, 1, 3);
                LengCss.BackColor = Color.FromArgb(88, 1, 3);
                LengJavaScript.BackColor = Color.FromArgb(88, 1, 3);
                LengSQL.BackColor = Color.FromArgb(88, 1, 3);
                LengAndroid.BackColor = Color.FromArgb(88, 1, 3);
            }
            else
            {
                if (TemaSelect == "Dark Dreams")
                {
                    BarraDeTitulo.BackColor = Color.FromArgb(42, 44, 49);
                    PanelContenedor.BackColor = Color.FromArgb(65, 61, 61);
                    Pestañas.BackColor = Color.FromArgb(42, 44, 49);
                    PinArchivo.BackColor = Color.FromArgb(153, 1, 0);
                    PinFormato.BackColor = Color.FromArgb(153, 1, 0);
                    PinLenguajes.BackColor = Color.FromArgb(153, 1, 0);
                    Archivo.BackColor = Color.FromArgb(42, 44, 49);
                    Formato.BackColor = Color.FromArgb(42, 44, 49);
                    Abrir.BackColor = Color.FromArgb(42, 44, 49);
                    Guardar.BackColor = Color.FromArgb(42, 44, 49);
                    GuardarComo.BackColor = Color.FromArgb(42, 44, 49);
                    Salir.BackColor = Color.FromArgb(42, 44, 49);
                    Fuente.BackColor = Color.FromArgb(42, 44, 49);
                    Temas.BackColor = Color.FromArgb(42, 44, 49);
                    GrupoFormato.BackColor = Color.FromArgb(42, 44, 49);
                    GrupoArchivo.BackColor = Color.FromArgb(42, 44, 49);
                    GrupoLenguajes.BackColor = Color.FromArgb(42, 44, 49);

                    Lenguajes.BackColor = Color.FromArgb(42, 44, 49);
                    PinLenguajes.BackColor = Color.FromArgb(153, 1, 0);
                    LengPSeint.BackColor = Color.FromArgb(42, 44, 49);
                    LengC.BackColor = Color.FromArgb(42, 44, 49);
                    LengDev.BackColor = Color.FromArgb(42, 44, 49);
                    LengJava.BackColor = Color.FromArgb(42, 44, 49);
                    LengCsharp.BackColor = Color.FromArgb(42, 44, 49);
                    LengHtml.BackColor = Color.FromArgb(42, 44, 49);
                    LengCss.BackColor = Color.FromArgb(42, 44, 49);
                    LengJavaScript.BackColor = Color.FromArgb(42, 44, 49);
                    LengSQL.BackColor = Color.FromArgb(42, 44, 49);
                    LengAndroid.BackColor = Color.FromArgb(42, 44, 49);
                }
            }
            Lectura.Close();
        }
        #endregion FinFormulario
        #region Pestañas
        private void Archivo_Click(object sender, EventArgs e)
        {
            if (GrupoArchivo.Visible == false)
            {
                GrupoArchivo.Size = new Size(180, 182);
                GrupoArchivo.Location = new Point(0, 68);
                GrupoArchivo.Visible = true;
            }
            else if (GrupoArchivo.Visible == true)
            {
                GrupoArchivo.Visible = false;
                GrupoArchivo.Size = new Size(25, 25);
                GrupoArchivo.Location = new Point(12, 101);
            }
            //Cerrar el Grupo Formato
            if (GrupoFormato.Visible == true)
            {
                GrupoFormato.Visible = false;
                GrupoFormato.Size = new Size(25, 25);
                GrupoFormato.Location = new Point(12, 140);
            }
            if (GrupoLenguajes.Visible == true)
            {
                GrupoLenguajes.Visible = false;
                GrupoLenguajes.Size = new Size(25, 25);
                GrupoLenguajes.Location = new Point(12, 140);
            }
        }
        private void Formato_Click(object sender, EventArgs e)
        {
            if (GrupoFormato.Visible == false)
            {
                GrupoFormato.Size = new Size(184, 88);
                GrupoFormato.Location = new Point(126, 68);
                GrupoFormato.Visible = true;
            }
            else if (GrupoFormato.Visible == true)
            {
                GrupoFormato.Visible = false;
                GrupoFormato.Size = new Size(25, 25);
                GrupoFormato.Location = new Point(12, 140);
            }
            //Cerrar el Grupo Archivo
            if (GrupoArchivo.Visible == true)
            {
                GrupoArchivo.Visible = false;
                GrupoArchivo.Size = new Size(25, 25);
                GrupoArchivo.Location = new Point(12, 101);
            }
            if (GrupoLenguajes.Visible == true)
            {
                GrupoLenguajes.Visible = false;
                GrupoLenguajes.Size = new Size(25, 25);
                GrupoLenguajes.Location = new Point(12, 140);
            }
        }
        private void Lenguajes_Click(object sender, EventArgs e)
        {
            if (GrupoLenguajes.Visible == false)
            {
                GrupoLenguajes.Size = new Size(180, 461);
                GrupoLenguajes.Location = new Point(238, 68);
                GrupoLenguajes.Visible = true;
            }
            else if (GrupoLenguajes.Visible == true)
            {
                GrupoLenguajes.Visible = false;
                GrupoLenguajes.Size = new Size(25, 25);
                GrupoLenguajes.Location = new Point(12, 140);
            }
            //Cerrar el Grupo Archivo
            if (GrupoArchivo.Visible == true)
            {
                GrupoArchivo.Visible = false;
                GrupoArchivo.Size = new Size(25, 25);
                GrupoArchivo.Location = new Point(12, 101);
            }
            if (GrupoFormato.Visible == true)
            {
                GrupoFormato.Visible = false;
                GrupoFormato.Size = new Size(25, 25);
                GrupoFormato.Location = new Point(12, 140);
            }
        }
        #endregion Pestañas
        #region InstanciarGrupoFormato
        private void Temas_Click(object sender, EventArgs e)
        {
            CambiarColor ventana = new CambiarColor();
            this.Hide();
            ventana.Show();
        }
        #endregion InstanciarGrupoFormato
        #region Colores
        //65;61;61 Gris Dark Dimension Cuerpo
        //42; 44; 49 Gris Dark Dimension Barra
        //153;1;0 Rojo Dark Dimension Pin
        #endregion ColoresDisponibles
        #region GrupoArchivo
        //Maximizado
        //180; 182 Size Grupo Archivo
        //0; 68 Location Grupo Archivo
        //Minimizado
        //25; 25 Size Grupo Archivo
        //12; 101 Location Grupo Archivo
        #endregion GrupoArchivo
        #region GrupoFormato
        //Maximizado
        //184; 88 Size
        //126; 68 Location
        //Minimizado
        //25; 25 Size
        //12; 140 Location
        #endregion GrupoFormato
        #region GrupoLenguajes
        private void LengPSeint_Click(object sender, EventArgs e)
        {
            PSeint start = new PSeint();
            this.Hide();
            start.Show();
        }
        #endregion GrupoLenguajes
        #region BotonesArchivo
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion BotonesArchivo

       

        

    }
}
