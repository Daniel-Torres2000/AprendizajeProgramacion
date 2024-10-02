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
    public partial class Frm_empresa : Form
    {
        public Frm_empresa()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_produccion.Text = Convert.ToString(Convert.ToDouble(Txt_costo.Text) * 0.10);
                Txt_ganancia.Text = Convert.ToString(Convert.ToDouble(Txt_produccion.Text) * 0.20);
                Txt_precio_venta.Text = Convert.ToString(Convert.ToDouble(Txt_costo.Text) + Convert.ToDouble(Txt_produccion.Text) + Convert.ToDouble(Txt_ganancia.Text));
            }
            catch (FormatException) { }
        }
        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_costo.Clear();
            Txt_produccion.Clear();
            Txt_ganancia.Clear();
            Txt_precio_venta.Clear();
        }
    }
}
