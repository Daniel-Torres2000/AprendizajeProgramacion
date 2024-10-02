namespace Interfaz_Esquema
{
    partial class Frm_multas
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
            this.Lbl_r1 = new System.Windows.Forms.Label();
            this.Lbl_exceso = new System.Windows.Forms.Label();
            this.Lbl_multa = new System.Windows.Forms.Label();
            this.Lbl_r2 = new System.Windows.Forms.Label();
            this.Lbl_r4 = new System.Windows.Forms.Label();
            this.Lbl_r5 = new System.Windows.Forms.Label();
            this.Lbl_r6 = new System.Windows.Forms.Label();
            this.Lbl_velocidad = new System.Windows.Forms.Label();
            this.Txt_velocidad = new System.Windows.Forms.TextBox();
            this.Lbl_pago = new System.Windows.Forms.Label();
            this.Txt_rangomulta = new System.Windows.Forms.TextBox();
            this.Lbl_mostrar1 = new System.Windows.Forms.Label();
            this.Btm_limpiar = new System.Windows.Forms.Button();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.Lbl_mostrar2 = new System.Windows.Forms.Label();
            this.Lbl_mostrar3 = new System.Windows.Forms.Label();
            this.Lbl_mostrar4 = new System.Windows.Forms.Label();
            this.Lbl_mostrar5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_titulo.Location = new System.Drawing.Point(231, 49);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(323, 37);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "MULTAS DE TRANSITO";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // Lbl_r1
            // 
            this.Lbl_r1.AutoSize = true;
            this.Lbl_r1.Location = new System.Drawing.Point(54, 123);
            this.Lbl_r1.Name = "Lbl_r1";
            this.Lbl_r1.Size = new System.Drawing.Size(215, 37);
            this.Lbl_r1.TabIndex = 2;
            this.Lbl_r1.Text = "1 - 10           Q10";
            // 
            // Lbl_exceso
            // 
            this.Lbl_exceso.AutoSize = true;
            this.Lbl_exceso.Location = new System.Drawing.Point(54, 86);
            this.Lbl_exceso.Name = "Lbl_exceso";
            this.Lbl_exceso.Size = new System.Drawing.Size(126, 37);
            this.Lbl_exceso.TabIndex = 3;
            this.Lbl_exceso.Text = "EXCESO";
            this.Lbl_exceso.Click += new System.EventHandler(this.Lbl_exceso_Click);
            // 
            // Lbl_multa
            // 
            this.Lbl_multa.AutoSize = true;
            this.Lbl_multa.Location = new System.Drawing.Point(197, 86);
            this.Lbl_multa.Name = "Lbl_multa";
            this.Lbl_multa.Size = new System.Drawing.Size(116, 37);
            this.Lbl_multa.TabIndex = 4;
            this.Lbl_multa.Text = "MULTA";
            this.Lbl_multa.Click += new System.EventHandler(this.Lbl_multa_Click);
            // 
            // Lbl_r2
            // 
            this.Lbl_r2.AutoSize = true;
            this.Lbl_r2.Location = new System.Drawing.Point(54, 160);
            this.Lbl_r2.Name = "Lbl_r2";
            this.Lbl_r2.Size = new System.Drawing.Size(222, 37);
            this.Lbl_r2.TabIndex = 5;
            this.Lbl_r2.Text = "11 - 20         Q20";
            // 
            // Lbl_r4
            // 
            this.Lbl_r4.AutoSize = true;
            this.Lbl_r4.Location = new System.Drawing.Point(54, 197);
            this.Lbl_r4.Name = "Lbl_r4";
            this.Lbl_r4.Size = new System.Drawing.Size(218, 37);
            this.Lbl_r4.TabIndex = 6;
            this.Lbl_r4.Text = "21 - 30        Q30";
            // 
            // Lbl_r5
            // 
            this.Lbl_r5.AutoSize = true;
            this.Lbl_r5.Location = new System.Drawing.Point(54, 234);
            this.Lbl_r5.Name = "Lbl_r5";
            this.Lbl_r5.Size = new System.Drawing.Size(221, 37);
            this.Lbl_r5.TabIndex = 7;
            this.Lbl_r5.Text = "31 - 40        Q40";
            // 
            // Lbl_r6
            // 
            this.Lbl_r6.AutoSize = true;
            this.Lbl_r6.Location = new System.Drawing.Point(54, 271);
            this.Lbl_r6.Name = "Lbl_r6";
            this.Lbl_r6.Size = new System.Drawing.Size(216, 37);
            this.Lbl_r6.TabIndex = 8;
            this.Lbl_r6.Text = "41...            Q50";
            // 
            // Lbl_velocidad
            // 
            this.Lbl_velocidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_velocidad.AutoSize = true;
            this.Lbl_velocidad.Location = new System.Drawing.Point(402, 86);
            this.Lbl_velocidad.Name = "Lbl_velocidad";
            this.Lbl_velocidad.Size = new System.Drawing.Size(336, 37);
            this.Lbl_velocidad.TabIndex = 9;
            this.Lbl_velocidad.Text = "VELOCIDAD EXCEDIDA";
            this.Lbl_velocidad.Click += new System.EventHandler(this.Lbl_velocidad_Click);
            // 
            // Txt_velocidad
            // 
            this.Txt_velocidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_velocidad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_velocidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_velocidad.Location = new System.Drawing.Point(368, 123);
            this.Txt_velocidad.Name = "Txt_velocidad";
            this.Txt_velocidad.Size = new System.Drawing.Size(390, 36);
            this.Txt_velocidad.TabIndex = 13;
            this.Txt_velocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_velocidad.TextChanged += new System.EventHandler(this.Txt_velocidad_TextChanged);
            // 
            // Lbl_pago
            // 
            this.Lbl_pago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_pago.AutoSize = true;
            this.Lbl_pago.Location = new System.Drawing.Point(270, 373);
            this.Lbl_pago.Name = "Lbl_pago";
            this.Lbl_pago.Size = new System.Drawing.Size(257, 37);
            this.Lbl_pago.TabIndex = 14;
            this.Lbl_pago.Text = "RANGO Y MULTA";
            // 
            // Txt_rangomulta
            // 
            this.Txt_rangomulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_rangomulta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_rangomulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_rangomulta.Enabled = false;
            this.Txt_rangomulta.Location = new System.Drawing.Point(61, 413);
            this.Txt_rangomulta.Name = "Txt_rangomulta";
            this.Txt_rangomulta.Size = new System.Drawing.Size(677, 36);
            this.Txt_rangomulta.TabIndex = 15;
            this.Txt_rangomulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_mostrar1
            // 
            this.Lbl_mostrar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_mostrar1.AutoSize = true;
            this.Lbl_mostrar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_mostrar1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostrar1.Location = new System.Drawing.Point(294, 415);
            this.Lbl_mostrar1.Name = "Lbl_mostrar1";
            this.Lbl_mostrar1.Size = new System.Drawing.Size(206, 34);
            this.Lbl_mostrar1.TabIndex = 16;
            this.Lbl_mostrar1.Text = "1 - 10           Q10";
            this.Lbl_mostrar1.Visible = false;
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(520, 471);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 22;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(103, 471);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 21;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Lbl_mostrar2
            // 
            this.Lbl_mostrar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_mostrar2.AutoSize = true;
            this.Lbl_mostrar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_mostrar2.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostrar2.Location = new System.Drawing.Point(288, 415);
            this.Lbl_mostrar2.Name = "Lbl_mostrar2";
            this.Lbl_mostrar2.Size = new System.Drawing.Size(212, 34);
            this.Lbl_mostrar2.TabIndex = 23;
            this.Lbl_mostrar2.Text = "11 - 20         Q20";
            this.Lbl_mostrar2.Visible = false;
            // 
            // Lbl_mostrar3
            // 
            this.Lbl_mostrar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_mostrar3.AutoSize = true;
            this.Lbl_mostrar3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_mostrar3.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostrar3.Location = new System.Drawing.Point(294, 415);
            this.Lbl_mostrar3.Name = "Lbl_mostrar3";
            this.Lbl_mostrar3.Size = new System.Drawing.Size(208, 34);
            this.Lbl_mostrar3.TabIndex = 24;
            this.Lbl_mostrar3.Text = "21 - 30        Q30";
            this.Lbl_mostrar3.Visible = false;
            // 
            // Lbl_mostrar4
            // 
            this.Lbl_mostrar4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_mostrar4.AutoSize = true;
            this.Lbl_mostrar4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_mostrar4.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostrar4.Location = new System.Drawing.Point(294, 415);
            this.Lbl_mostrar4.Name = "Lbl_mostrar4";
            this.Lbl_mostrar4.Size = new System.Drawing.Size(211, 34);
            this.Lbl_mostrar4.TabIndex = 25;
            this.Lbl_mostrar4.Text = "31 - 40        Q40";
            this.Lbl_mostrar4.Visible = false;
            // 
            // Lbl_mostrar5
            // 
            this.Lbl_mostrar5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_mostrar5.AutoSize = true;
            this.Lbl_mostrar5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_mostrar5.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostrar5.Location = new System.Drawing.Point(300, 415);
            this.Lbl_mostrar5.Name = "Lbl_mostrar5";
            this.Lbl_mostrar5.Size = new System.Drawing.Size(205, 34);
            this.Lbl_mostrar5.TabIndex = 26;
            this.Lbl_mostrar5.Text = "41...            Q50";
            this.Lbl_mostrar5.Visible = false;
            // 
            // Frm_multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.Lbl_mostrar5);
            this.Controls.Add(this.Lbl_mostrar4);
            this.Controls.Add(this.Lbl_mostrar3);
            this.Controls.Add(this.Lbl_mostrar2);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Lbl_mostrar1);
            this.Controls.Add(this.Txt_rangomulta);
            this.Controls.Add(this.Lbl_pago);
            this.Controls.Add(this.Txt_velocidad);
            this.Controls.Add(this.Lbl_velocidad);
            this.Controls.Add(this.Lbl_r6);
            this.Controls.Add(this.Lbl_r5);
            this.Controls.Add(this.Lbl_r4);
            this.Controls.Add(this.Lbl_r2);
            this.Controls.Add(this.Lbl_multa);
            this.Controls.Add(this.Lbl_exceso);
            this.Controls.Add(this.Lbl_r1);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Frm_multas";
            this.Text = "Frm_multas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_r1;
        private System.Windows.Forms.Label Lbl_exceso;
        private System.Windows.Forms.Label Lbl_multa;
        private System.Windows.Forms.Label Lbl_r2;
        private System.Windows.Forms.Label Lbl_r4;
        private System.Windows.Forms.Label Lbl_r5;
        private System.Windows.Forms.Label Lbl_r6;
        private System.Windows.Forms.Label Lbl_velocidad;
        private System.Windows.Forms.TextBox Txt_velocidad;
        private System.Windows.Forms.Label Lbl_pago;
        private System.Windows.Forms.TextBox Txt_rangomulta;
        private System.Windows.Forms.Label Lbl_mostrar1;
        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.Button Btm_operar;
        private System.Windows.Forms.Label Lbl_mostrar2;
        private System.Windows.Forms.Label Lbl_mostrar3;
        private System.Windows.Forms.Label Lbl_mostrar4;
        private System.Windows.Forms.Label Lbl_mostrar5;
    }
}