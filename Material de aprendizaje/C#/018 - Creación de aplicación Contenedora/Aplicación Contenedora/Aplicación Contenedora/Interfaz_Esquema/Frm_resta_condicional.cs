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
    public partial class Frm_resta_condicional : Form
    {
        public Frm_resta_condicional()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(Txt_num1.Text) >= Convert.ToDouble(Txt_num2.Text))
                {
                    Txt_resultado.Text = Convert.ToString(Convert.ToDouble(Txt_num1.Text) - Convert.ToDouble(Txt_num2.Text));
                }
                else
                {
                    Txt_resultado.Text = Convert.ToString(Convert.ToDouble(Txt_num2.Text) - Convert.ToDouble(Txt_num1.Text));
                }
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_num1.Clear();
            Txt_num2.Clear();
            Txt_resultado.Clear();
        }
    }
}
