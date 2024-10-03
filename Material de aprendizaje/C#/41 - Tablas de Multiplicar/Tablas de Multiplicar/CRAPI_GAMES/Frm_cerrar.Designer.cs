namespace CRAPI_GAMES
{
    partial class Frm_cerrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cerrar));
            this.Lbl_advertencia = new System.Windows.Forms.Label();
            this.Btm_si = new System.Windows.Forms.Button();
            this.Btm_no = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_advertencia
            // 
            this.Lbl_advertencia.AutoSize = true;
            this.Lbl_advertencia.Location = new System.Drawing.Point(172, 45);
            this.Lbl_advertencia.Name = "Lbl_advertencia";
            this.Lbl_advertencia.Size = new System.Drawing.Size(188, 33);
            this.Lbl_advertencia.TabIndex = 0;
            this.Lbl_advertencia.Text = "ADVERTENCIA";
            // 
            // Btm_si
            // 
            this.Btm_si.BackColor = System.Drawing.Color.NavajoWhite;
            this.Btm_si.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_si.Location = new System.Drawing.Point(64, 197);
            this.Btm_si.Name = "Btm_si";
            this.Btm_si.Size = new System.Drawing.Size(94, 43);
            this.Btm_si.TabIndex = 2;
            this.Btm_si.Text = "SI";
            this.Btm_si.UseVisualStyleBackColor = false;
            this.Btm_si.Click += new System.EventHandler(this.Btm_si_Click);
            // 
            // Btm_no
            // 
            this.Btm_no.BackColor = System.Drawing.Color.NavajoWhite;
            this.Btm_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_no.Location = new System.Drawing.Point(350, 197);
            this.Btm_no.Name = "Btm_no";
            this.Btm_no.Size = new System.Drawing.Size(94, 43);
            this.Btm_no.TabIndex = 3;
            this.Btm_no.Text = "NO";
            this.Btm_no.UseVisualStyleBackColor = false;
            this.Btm_no.Click += new System.EventHandler(this.Btm_no_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(107, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 110);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Usted esta cerrando CRAPI_GAMES, ¿Desea continuar?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_cerrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(521, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btm_no);
            this.Controls.Add(this.Btm_si);
            this.Controls.Add(this.Lbl_advertencia);
            this.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Frm_cerrar";
            this.Text = "ADVERTENCIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_advertencia;
        private System.Windows.Forms.Button Btm_si;
        private System.Windows.Forms.Button Btm_no;
        private System.Windows.Forms.TextBox textBox1;
    }
}