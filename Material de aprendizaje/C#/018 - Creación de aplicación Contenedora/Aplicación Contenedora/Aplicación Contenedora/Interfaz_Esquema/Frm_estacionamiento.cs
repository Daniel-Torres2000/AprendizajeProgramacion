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
    public partial class Frm_estacionamiento : Form
    {
        public Frm_estacionamiento()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                int contador = 3;
                Txt_cargos.Text = Convert.ToString(0);
                for (int i = 1; i <= Convert.ToInt32(Txt_horas.Text); i++)
                {
                    Txt_cargos.Text = Convert.ToString(Convert.ToInt32(Txt_cargos.Text) + contador);
                    contador++;
                }
                if (Convert.ToInt32(Txt_min.Text) >= 1)
                {
                    if (Convert.ToInt32(Txt_horas.Text) >= 1)
                        Txt_cargos.Text = Convert.ToString(Convert.ToInt32(Txt_cargos.Text) + contador);
                }
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_horas.Clear();
            Txt_min.Clear();
            Txt_cargos.Clear();
        }
    }
}
