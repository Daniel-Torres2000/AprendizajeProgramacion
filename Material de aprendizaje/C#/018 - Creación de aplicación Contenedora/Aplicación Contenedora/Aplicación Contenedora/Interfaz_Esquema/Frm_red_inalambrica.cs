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
    public partial class Frm_red_inalambrica : Form
    {
        public Frm_red_inalambrica()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_minutos.Text = Convert.ToString(Convert.ToInt32(Txt_segundos.Text) / 60);
                Txt_horas.Text = Convert.ToString(Convert.ToInt32(Txt_minutos.Text) / 60);
                Txt_dias.Text = Convert.ToString(Convert.ToInt32(Txt_horas.Text) / 24);
                Txt_meses.Text = Convert.ToString(Convert.ToInt32(Txt_dias.Text) / 30);
            }
            catch (FormatException) { }
        }
        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_segundos.Clear();
            Txt_minutos.Clear();
            Txt_horas.Clear();
            Txt_dias.Clear();
            Txt_meses.Clear();
        }
    }
}
