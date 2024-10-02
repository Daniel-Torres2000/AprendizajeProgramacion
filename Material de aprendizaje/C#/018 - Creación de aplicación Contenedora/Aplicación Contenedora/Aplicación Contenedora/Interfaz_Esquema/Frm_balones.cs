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
    public partial class Frm_balones : Form
    {
        public Frm_balones()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToDouble(Txt_balones.Text) >= 1) && (Convert.ToDouble(Txt_balones.Text) <= 11))
                {
                    Txt_resultado.Text = Convert.ToString(Convert.ToDouble(Txt_balones.Text) * 40);
                }
                else
                {
                    if (Convert.ToDouble(Txt_balones.Text) >= 12)
                    {
                        Txt_resultado.Text = Convert.ToString(Convert.ToDouble(Txt_balones.Text) * 35);
                    }
                }
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_balones.Clear();
            Txt_resultado.Clear();
        }
    }
}
