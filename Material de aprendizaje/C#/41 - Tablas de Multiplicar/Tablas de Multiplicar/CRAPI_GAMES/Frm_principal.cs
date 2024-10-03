using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRAPI_GAMES
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void Btm_instrucciones_Click(object sender, EventArgs e)
        {
            Frm_instrrucciones instancia = new Frm_instrrucciones();
            instancia.Show();
            this.Hide();
        }

        private void Btm_salir_Click(object sender, EventArgs e)
        {
            Frm_cerrar instancia = new Frm_cerrar();
            this.Hide();
            instancia.Show();
        }

        private void Btm_jugar_Click(object sender, EventArgs e)
        {
            Frm_jugar instancia = new Frm_jugar();
            instancia.Show();
            this.Hide();
        }
    }
}
