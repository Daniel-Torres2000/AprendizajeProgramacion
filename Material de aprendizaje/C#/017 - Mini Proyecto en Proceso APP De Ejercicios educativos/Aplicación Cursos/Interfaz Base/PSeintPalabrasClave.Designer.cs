namespace Interfaz_Base
{
    partial class PSeintPalabrasClave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PalabrasClaveTitulo = new System.Windows.Forms.Label();
            this.BarraTituloPalabrasClave = new System.Windows.Forms.Panel();
            this.PanelScroll = new System.Windows.Forms.Panel();
            this.BarraVertical = new System.Windows.Forms.VScrollBar();
            this.TextoDatos = new System.Windows.Forms.Label();
            this.BarraTituloPalabrasClave.SuspendLayout();
            this.PanelScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // PalabrasClaveTitulo
            // 
            this.PalabrasClaveTitulo.AutoSize = true;
            this.PalabrasClaveTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalabrasClaveTitulo.ForeColor = System.Drawing.Color.White;
            this.PalabrasClaveTitulo.Location = new System.Drawing.Point(12, 9);
            this.PalabrasClaveTitulo.Name = "PalabrasClaveTitulo";
            this.PalabrasClaveTitulo.Size = new System.Drawing.Size(311, 41);
            this.PalabrasClaveTitulo.TabIndex = 3;
            this.PalabrasClaveTitulo.Text = "PALABRAS CLAVE";
            // 
            // BarraTituloPalabrasClave
            // 
            this.BarraTituloPalabrasClave.Controls.Add(this.PalabrasClaveTitulo);
            this.BarraTituloPalabrasClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPalabrasClave.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPalabrasClave.Name = "BarraTituloPalabrasClave";
            this.BarraTituloPalabrasClave.Size = new System.Drawing.Size(621, 75);
            this.BarraTituloPalabrasClave.TabIndex = 10;
            // 
            // PanelScroll
            // 
            this.PanelScroll.Controls.Add(this.BarraVertical);
            this.PanelScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelScroll.Location = new System.Drawing.Point(602, 75);
            this.PanelScroll.Name = "PanelScroll";
            this.PanelScroll.Size = new System.Drawing.Size(19, 411);
            this.PanelScroll.TabIndex = 11;
            // 
            // BarraVertical
            // 
            this.BarraVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarraVertical.Location = new System.Drawing.Point(0, 0);
            this.BarraVertical.Maximum = 400;
            this.BarraVertical.Name = "BarraVertical";
            this.BarraVertical.Size = new System.Drawing.Size(19, 411);
            this.BarraVertical.TabIndex = 3;
            this.BarraVertical.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BarraVertical_Scroll);
            // 
            // TextoDatos
            // 
            this.TextoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TextoDatos.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoDatos.ForeColor = System.Drawing.Color.White;
            this.TextoDatos.Location = new System.Drawing.Point(14, 75);
            this.TextoDatos.Name = "TextoDatos";
            this.TextoDatos.Size = new System.Drawing.Size(552, 6000);
            this.TextoDatos.TabIndex = 12;
            // 
            // PSeintPalabrasClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(621, 486);
            this.Controls.Add(this.PanelScroll);
            this.Controls.Add(this.BarraTituloPalabrasClave);
            this.Controls.Add(this.TextoDatos);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PSeintPalabrasClave";
            this.Text = "PSeintPalabrasClave";
            this.Load += new System.EventHandler(this.PSeintPalabrasClave_Load);
            this.BarraTituloPalabrasClave.ResumeLayout(false);
            this.BarraTituloPalabrasClave.PerformLayout();
            this.PanelScroll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PalabrasClaveTitulo;
        private System.Windows.Forms.Panel BarraTituloPalabrasClave;
        private System.Windows.Forms.Panel PanelScroll;
        private System.Windows.Forms.VScrollBar BarraVertical;
        private System.Windows.Forms.Label TextoDatos;
    }
}