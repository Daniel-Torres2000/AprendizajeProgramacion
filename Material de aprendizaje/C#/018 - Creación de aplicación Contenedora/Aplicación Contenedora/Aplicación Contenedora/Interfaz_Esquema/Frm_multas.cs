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
    public partial class Frm_multas : Form
    {
        public Frm_multas()
        {
            InitializeComponent();
        }
        private void Btm_operar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(Txt_velocidad.Text) >= 1) && (Convert.ToInt32(Txt_velocidad.Text) <= 10))
                {
                    Lbl_mostrar1.Visible = true;
                }
                else
                {
                    if ((Convert.ToInt32(Txt_velocidad.Text) >= 11) && (Convert.ToInt32(Txt_velocidad.Text) <= 20))
                    {
                        Lbl_mostrar2.Visible = true;
                    }
                    else
                    {
                        if ((Convert.ToInt32(Txt_velocidad.Text) >= 21) && (Convert.ToInt32(Txt_velocidad.Text) <= 30))
                        {
                            Lbl_mostrar3.Visible = true;
                        }
                        else
                        {
                            if ((Convert.ToInt32(Txt_velocidad.Text) >= 31) && (Convert.ToInt32(Txt_velocidad.Text) <= 40))
                            {
                                Lbl_mostrar4.Visible = true;
                            }
                            else
                            {
                                if (Convert.ToInt32(Txt_velocidad.Text) >= 41)
                                {
                                    Lbl_mostrar5.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (FormatException) { }
        }

        private void Btm_limpiar_Click(object sender, EventArgs e)
        {
            Txt_velocidad.Clear();
            Lbl_mostrar1.Visible = false;
            Lbl_mostrar2.Visible = false;
            Lbl_mostrar3.Visible = false;
            Lbl_mostrar4.Visible = false;
            Lbl_mostrar5.Visible = false;
        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_exceso_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_multa_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_velocidad_Click(object sender, EventArgs e)
        {

        }

        private void Txt_velocidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
