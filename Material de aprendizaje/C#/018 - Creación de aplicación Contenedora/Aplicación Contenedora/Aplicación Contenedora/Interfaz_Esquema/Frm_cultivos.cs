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
    public partial class Frm_cultivos : Form
    {
        public Frm_cultivos()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_alquiler.Text = Convert.ToString(Convert.ToInt64(Txt_cuerdas.Text) * 500);
                Txt_semillas.Text = Convert.ToString(Convert.ToDouble(Txt_cuerdas.Text) / 2 * 300);
                Txt_seguros.Text = Convert.ToString(Convert.ToInt64(Txt_cuerdas.Text) * 1000);
                Txt_gastos.Text = Convert.ToString(Convert.ToInt64(Txt_cuerdas.Text) * 800);
                Txt_inversion.Text = Convert.ToString(Convert.ToDouble(Txt_alquiler.Text) + Convert.ToDouble(Txt_semillas.Text) + Convert.ToDouble(Txt_gastos.Text) + Convert.ToDouble(Txt_seguros.Text));
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_cuerdas.Clear();
            Txt_alquiler.Clear();
            Txt_semillas.Clear();
            Txt_gastos.Clear();
            Txt_seguros.Clear();
            Txt_inversion.Clear();
        }
    }
}
