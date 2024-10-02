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
    public partial class Frm_circunferencia : Form
    {
        public Frm_circunferencia()
        {
            InitializeComponent();
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_radio.Clear();
            Txt_area.Clear();
            Txt_longitud.Clear();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_longitud.Text = Convert.ToString(Convert.ToDouble(Txt_radio.Text) * 2 * 3.1416);
                Txt_area.Text = Convert.ToString(Convert.ToDouble(Txt_radio.Text) * 3.1416);
            }
            catch (FormatException) { }
        }
    }
}
