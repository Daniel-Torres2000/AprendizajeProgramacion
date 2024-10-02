namespace Interfaz_Esquema
{
    partial class Frm_estacionamiento
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txt_cargos = new System.Windows.Forms.TextBox();
            this.Lbl_cargos = new System.Windows.Forms.Label();
            this.Btm_limpiar = new System.Windows.Forms.Button();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.Txt_min = new System.Windows.Forms.TextBox();
            this.Lbl_horas = new System.Windows.Forms.Label();
            this.Txt_horas = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_titulo.Location = new System.Drawing.Point(157, 63);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(482, 37);
            this.Lbl_titulo.TabIndex = 40;
            this.Lbl_titulo.Text = "PRECIOS DEL ESTACIONAMIENTO";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(292, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 36);
            this.textBox1.TabIndex = 55;
            this.textBox1.Text = "Q";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_cargos
            // 
            this.Txt_cargos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_cargos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_cargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_cargos.Enabled = false;
            this.Txt_cargos.Location = new System.Drawing.Point(342, 163);
            this.Txt_cargos.Name = "Txt_cargos";
            this.Txt_cargos.Size = new System.Drawing.Size(399, 36);
            this.Txt_cargos.TabIndex = 54;
            this.Txt_cargos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_cargos
            // 
            this.Lbl_cargos.AutoSize = true;
            this.Lbl_cargos.Location = new System.Drawing.Point(52, 163);
            this.Lbl_cargos.Name = "Lbl_cargos";
            this.Lbl_cargos.Size = new System.Drawing.Size(136, 37);
            this.Lbl_cargos.TabIndex = 53;
            this.Lbl_cargos.Text = "CARGOS";
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(525, 415);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 52;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(108, 415);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 51;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Txt_min
            // 
            this.Txt_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_min.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_min.Location = new System.Drawing.Point(525, 103);
            this.Txt_min.Name = "Txt_min";
            this.Txt_min.Size = new System.Drawing.Size(216, 36);
            this.Txt_min.TabIndex = 50;
            this.Txt_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_horas
            // 
            this.Lbl_horas.AutoSize = true;
            this.Lbl_horas.Location = new System.Drawing.Point(52, 106);
            this.Lbl_horas.Name = "Lbl_horas";
            this.Lbl_horas.Size = new System.Drawing.Size(117, 37);
            this.Lbl_horas.TabIndex = 49;
            this.Lbl_horas.Text = "HORAS";
            // 
            // Txt_horas
            // 
            this.Txt_horas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_horas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_horas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_horas.Location = new System.Drawing.Point(316, 103);
            this.Txt_horas.Name = "Txt_horas";
            this.Txt_horas.Size = new System.Drawing.Size(213, 36);
            this.Txt_horas.TabIndex = 57;
            this.Txt_horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(500, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 32);
            this.textBox2.TabIndex = 58;
            this.textBox2.Text = ":";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Txt_horas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Txt_cargos);
            this.Controls.Add(this.Lbl_cargos);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Txt_min);
            this.Controls.Add(this.Lbl_horas);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "Frm_estacionamiento";
            this.Text = "Frm_estacionamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Txt_cargos;
        private System.Windows.Forms.Label Lbl_cargos;
        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.Button Btm_operar;
        private System.Windows.Forms.TextBox Txt_min;
        private System.Windows.Forms.Label Lbl_horas;
        private System.Windows.Forms.TextBox Txt_horas;
        private System.Windows.Forms.TextBox textBox2;
    }
}