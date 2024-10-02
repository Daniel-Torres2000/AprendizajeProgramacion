using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Esquema
{
    public partial class Frm_esfera : Form
    {
        public Frm_esfera()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_volumen.Text = Convert.ToString(Convert.ToDouble(Txt_radio.Text) * 3.1416 * (4 / 3));
                Txt_area.Text = Convert.ToString(Convert.ToDouble(Txt_radio.Text) * 4 * 3.1416);
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_radio.Clear();
            Txt_area.Clear();
            Txt_volumen.Clear();
        }
    }
}
