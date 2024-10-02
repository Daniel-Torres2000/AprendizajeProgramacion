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
    public partial class Frm_conversiones : Form
    {
        public Frm_conversiones()
        {
            InitializeComponent();
        }
        private void Frm_conversiones_Load(object sender, EventArgs e){}
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_pulgadas.Text = Convert.ToString(Convert.ToDouble(Txt_pies.Text) * 12);
                Txt_centimetros.Text = Convert.ToString(Convert.ToDouble(Txt_pulgadas.Text) * 2.54);
                Txt_yardas.Text = Convert.ToString(Convert.ToDouble(Txt_centimetros.Text) / 91.44);
                Txt_metros.Text = Convert.ToString(Convert.ToDouble(Txt_centimetros.Text) / 100);
            }
            catch(FormatException){ }
        }
        private void Lbl_pulgadasr_Click(object sender, EventArgs e) { }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_pulgadas.Clear();
            Txt_centimetros.Clear();
            Txt_yardas.Clear();
            Txt_pies.Clear();
            Txt_metros.Clear();
        }
    }
}
