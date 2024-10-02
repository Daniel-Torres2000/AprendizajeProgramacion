using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Interfaz_Esquema
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
            AbrirFormHija(new Frm_enlace());
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Pic_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Pic_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Pic_maximizar.Visible = false;
            Pic_restaurar.Visible = true;
        }
        private void Pic_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Pic_restaurar.Visible = false;
            Pic_maximizar.Visible = true;
        }
        private void Pic_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Pbarra_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void AbrirFormHija(object FormHija)
        {
            if (this.Pcontenedor.Controls.Count > 0)
            {
                this.Pcontenedor.Controls.RemoveAt(0);
            }
            Form frm = FormHija as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Pcontenedor.Controls.Add(frm);
            this.Pcontenedor.Tag = frm;
            frm.Show();
        }

        private void Pic_Enlace_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormHija(new Frm_enlace());
        }

        private void Btm_conversiones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_conversiones());
        }

        private void Btm_termometro_ambiental_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_termometro_ambiental());
        }

        private void Btm_circunferencia_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_circunferencia());
        }

        private void Btm_esfera_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_esfera());
        }

        private void Btm_red_inalambrica_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_red_inalambrica());
        }

        private void Btm_produccion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_empresa());
        }

        private void Btm_cultivos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_cultivos());
        }

        private void Btm_resta_condicional_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_resta_condicional());
        }

        private void Btm_balones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_balones());
        }

        private void Btm_multas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_multas());
        }

        private void Btm_estacionamiento_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_estacionamiento());
        }

        private void Btm_luz_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_luz());
        }

       
    }
}
