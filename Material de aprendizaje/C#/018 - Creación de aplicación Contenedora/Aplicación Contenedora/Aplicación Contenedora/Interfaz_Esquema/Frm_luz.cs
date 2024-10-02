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
    public partial class Frm_luz : Form
    {
        public Frm_luz()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(Txt_consumo.Text) >= 1) && (Convert.ToInt32(Txt_consumo.Text) <= 200))
                {
                    Txt_rangoconsumo.Text = Convert.ToString(10);
                }
                else
                {
                    if ((Convert.ToInt32(Txt_consumo.Text) >= 201) && (Convert.ToInt32(Txt_consumo.Text) <= 1000))
                    {
                        Txt_rangoconsumo.Text = Convert.ToString(Convert.ToDouble(Txt_consumo.Text) - 200);
                        Txt_rangoconsumo.Text = Convert.ToString(Convert.ToDouble(Txt_rangoconsumo.Text) * 0.05 + 10);
                    }
                    else
                    {
                        if (Convert.ToInt32(Txt_consumo.Text) >= 1001)
                        {
                            Txt_rangoconsumo.Text = Convert.ToString(Convert.ToDouble(Txt_consumo.Text) - 1000);
                            Txt_rangoconsumo.Text = Convert.ToString(Convert.ToDouble(Txt_rangoconsumo.Text) * 0.03 + 50);
                        }
                    }
                }
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_consumo.Clear();
            Txt_rangoconsumo.Clear();
        }
    }
}
