using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Interfaz_Base
{
    public partial class CambiarColor : Form
    {
        #region TamañoVentana
        //Maximizar
        //278; 382 Size
        //Minimizar
        //278; 299 Size
        #endregion TamañoVentana
        /*ACTIVEFORM
        Para cambiar las propiedades de un formulario que se encuentra activo lo realizamos de la siguiente manera

        "NombreDelFormulario".ActiveForm."PropiedadAModificar"
        Ejemplo:

        CambiarColor.ActiveForm.Size = new Size(100, 50);
        */
        /*RED BLOOD
        Color barra titulo 
        Color.FromArgb(88, 1, 3);
        Color Cuerpo formulario
        Color.FromArgb(140, 1, 3);
        */
        /*DARK DREAMS
        Color barra titulo 
        Color.FromArgb(42, 44, 49);
        Color Cuerpo formulario
        Color.FromArgb(65, 61, 61);
        */
        #region CargarFormulario
        public CambiarColor()
        {
            InitializeComponent();
        }
        private void CambiarColor_Load(object sender, EventArgs e)
        {
            //Cambiar el tamaño inicial del Formulario
            Size = new Size(278, 299);
            //Color Inicial
            StreamReader Lectura = new StreamReader(@"Tema Seleccionado.txt");
            string TemaSelect = Lectura.ReadLine();
            if (TemaSelect == "Red Blood")
            {
                BarraDeTitulo.BackColor = Color.FromArgb(88, 1, 3);
                CambiarColor.ActiveForm.BackColor = Color.FromArgb(140, 1, 3);
            }
            else
            {
                if (TemaSelect == "Dark Dreams")
                {
                    BarraDeTitulo.BackColor = Color.FromArgb(42, 44, 49);
                    CambiarColor.ActiveForm.BackColor = Color.FromArgb(65, 61, 61);
                }
            }
            Lectura.Close();
        }
        #endregion CargarFormulario
        #region MovilidadFormulario
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion MovilidadFormulario
        #region Botones
        private string TemaSeleccionado;
        private void BtmCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterfazVisualBase ventana = new InterfazVisualBase();
            ventana.Show();
        }
        private void Aplicar_Click(object sender, EventArgs e)
        {
            CambiarColor.ActiveForm.Size = new Size(278, 382);
            Aplicar.Enabled = false;
            OpcionesTemas.Enabled = false;

            TemaSeleccionado = OpcionesTemas.Text;
            if (TemaSeleccionado == "Red Blood")
            {
                BarraDeTitulo.BackColor = Color.FromArgb(88, 1, 3);
                CambiarColor.ActiveForm.BackColor = Color.FromArgb(140, 1, 3);
            }
            else if(TemaSeleccionado == "Dark Dreams")
            {
                BarraDeTitulo.BackColor = Color.FromArgb(42, 44, 49);
                CambiarColor.ActiveForm.BackColor = Color.FromArgb(65, 61, 61);
            }
        }
        private void BtmAceptar_Click(object sender, EventArgs e)
        {
            StreamWriter Escritura = new StreamWriter(@"Tema Seleccionado.txt");
            Escritura.WriteLine(TemaSeleccionado);
            Escritura.Close();
            this.Hide();
            InterfazVisualBase ventana = new InterfazVisualBase();
            ventana.Show();
        }
        #endregion Botones
    }
}
