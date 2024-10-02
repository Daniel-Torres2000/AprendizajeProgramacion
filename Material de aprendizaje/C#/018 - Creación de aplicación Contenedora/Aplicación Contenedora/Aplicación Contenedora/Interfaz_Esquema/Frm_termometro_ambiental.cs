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
    public partial class Frm_termometro_ambiental : Form
    {
        public Frm_termometro_ambiental()
        {
            InitializeComponent();
        }

        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_faren.Text = Convert.ToString(Convert.ToDouble(Txt_centigrados.Text) * 1.8 + 32);
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_centigrados.Clear();
            Txt_faren.Clear();
        }
    }
}
