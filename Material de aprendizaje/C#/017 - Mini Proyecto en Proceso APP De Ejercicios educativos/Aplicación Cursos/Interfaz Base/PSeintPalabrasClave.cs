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

namespace Interfaz_Base
{
    public partial class PSeintPalabrasClave : Form
    {
        private int BarraEjeY = 75, BarraEjeYInicial = 0, BarraEjeYTemporal = 0;
        public PSeintPalabrasClave()
        {
            InitializeComponent();
        }
        private void BarraVertical_Scroll(object sender, ScrollEventArgs e)
        {
            if(BarraVertical.Value > BarraEjeYInicial)
            {
                BarraEjeYTemporal = BarraVertical.Value - BarraEjeYInicial;
                BarraEjeYInicial = BarraVertical.Value;
                for (int i = BarraEjeYTemporal; i >= 1; i--)
                {
                    BarraEjeY = BarraEjeY - 10;
                }
                TextoDatos.Location = new Point(14, BarraEjeY);
            }
            else if (BarraVertical.Value < BarraEjeYInicial)
            {
                BarraEjeYTemporal = BarraEjeYInicial - BarraVertical.Value;
                BarraEjeYInicial = BarraVertical.Value;
                for (int i = BarraEjeYTemporal; i >= 1; i--)
                {
                    BarraEjeY = BarraEjeY + 10;
                }
                TextoDatos.Location = new Point(14, BarraEjeY);
            }
        }
        private void PSeintPalabrasClave_Load(object sender, EventArgs e)
        {
            StreamReader Lectura = new StreamReader(@"PSeint Palabras Clave.txt");
            TextoDatos.Text = Lectura.ReadToEnd();
            Lectura.Close();
        }
    }
}
