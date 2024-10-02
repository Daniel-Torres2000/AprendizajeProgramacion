namespace Interfaz_Esquema
{
    partial class Frm_luz
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
            this.Btm_limpiar = new System.Windows.Forms.Button();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.Txt_rangoconsumo = new System.Windows.Forms.TextBox();
            this.Lbl_pago = new System.Windows.Forms.Label();
            this.Txt_consumo = new System.Windows.Forms.TextBox();
            this.Lbl_consumido = new System.Windows.Forms.Label();
            this.Lbl_r4 = new System.Windows.Forms.Label();
            this.Lbl_r2 = new System.Windows.Forms.Label();
            this.Lbl_importe = new System.Windows.Forms.Label();
            this.Lbl_consumo = new System.Windows.Forms.Label();
            this.Lbl_r1 = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(483, 472);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 36;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(66, 472);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 35;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Txt_rangoconsumo
            // 
            this.Txt_rangoconsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_rangoconsumo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_rangoconsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_rangoconsumo.Enabled = false;
            this.Txt_rangoconsumo.Location = new System.Drawing.Point(24, 414);
            this.Txt_rangoconsumo.Name = "Txt_rangoconsumo";
            this.Txt_rangoconsumo.Size = new System.Drawing.Size(677, 36);
            this.Txt_rangoconsumo.TabIndex = 34;
            this.Txt_rangoconsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_pago
            // 
            this.Lbl_pago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_pago.AutoSize = true;
            this.Lbl_pago.Location = new System.Drawing.Point(233, 374);
            this.Lbl_pago.Name = "Lbl_pago";
            this.Lbl_pago.Size = new System.Drawing.Size(286, 37);
            this.Lbl_pago.TabIndex = 33;
            this.Lbl_pago.Text = "RANGO E IMPORTE";
            // 
            // Txt_consumo
            // 
            this.Txt_consumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_consumo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_consumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_consumo.Location = new System.Drawing.Point(397, 124);
            this.Txt_consumo.Name = "Txt_consumo";
            this.Txt_consumo.Size = new System.Drawing.Size(324, 36);
            this.Txt_consumo.TabIndex = 32;
            this.Txt_consumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_consumido
            // 
            this.Lbl_consumido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_consumido.AutoSize = true;
            this.Lbl_consumido.Location = new System.Drawing.Point(393, 87);
            this.Lbl_consumido.Name = "Lbl_consumido";
            this.Lbl_consumido.Size = new System.Drawing.Size(334, 37);
            this.Lbl_consumido.TabIndex = 31;
            this.Lbl_consumido.Text = "CONSUMO REALIZADO";
            // 
            // Lbl_r4
            // 
            this.Lbl_r4.AutoSize = true;
            this.Lbl_r4.Location = new System.Drawing.Point(17, 198);
            this.Lbl_r4.Name = "Lbl_r4";
            this.Lbl_r4.Size = new System.Drawing.Size(276, 37);
            this.Lbl_r4.TabIndex = 28;
            this.Lbl_r4.Text = "1001...                Q30";
            // 
            // Lbl_r2
            // 
            this.Lbl_r2.AutoSize = true;
            this.Lbl_r2.Location = new System.Drawing.Point(17, 161);
            this.Lbl_r2.Name = "Lbl_r2";
            this.Lbl_r2.Size = new System.Drawing.Size(279, 37);
            this.Lbl_r2.TabIndex = 27;
            this.Lbl_r2.Text = "201 - 1000         Q20";
            // 
            // Lbl_importe
            // 
            this.Lbl_importe.AutoSize = true;
            this.Lbl_importe.Location = new System.Drawing.Point(194, 87);
            this.Lbl_importe.Name = "Lbl_importe";
            this.Lbl_importe.Size = new System.Drawing.Size(147, 37);
            this.Lbl_importe.TabIndex = 26;
            this.Lbl_importe.Text = "IMPORTE";
            // 
            // Lbl_consumo
            // 
            this.Lbl_consumo.AutoSize = true;
            this.Lbl_consumo.Location = new System.Drawing.Point(17, 87);
            this.Lbl_consumo.Name = "Lbl_consumo";
            this.Lbl_consumo.Size = new System.Drawing.Size(163, 37);
            this.Lbl_consumo.TabIndex = 25;
            this.Lbl_consumo.Text = "CONSUMO";
            // 
            // Lbl_r1
            // 
            this.Lbl_r1.AutoSize = true;
            this.Lbl_r1.Location = new System.Drawing.Point(17, 124);
            this.Lbl_r1.Name = "Lbl_r1";
            this.Lbl_r1.Size = new System.Drawing.Size(275, 37);
            this.Lbl_r1.TabIndex = 24;
            this.Lbl_r1.Text = "0 - 200               Q10";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_titulo.Location = new System.Drawing.Point(194, 40);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(338, 37);
            this.Lbl_titulo.TabIndex = 23;
            this.Lbl_titulo.Text = "LUZ ELECTRICA PAGOS";
            // 
            // Frm_luz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(739, 576);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Txt_rangoconsumo);
            this.Controls.Add(this.Lbl_pago);
            this.Controls.Add(this.Txt_consumo);
            this.Controls.Add(this.Lbl_consumido);
            this.Controls.Add(this.Lbl_r4);
            this.Controls.Add(this.Lbl_r2);
            this.Controls.Add(this.Lbl_importe);
            this.Controls.Add(this.Lbl_consumo);
            this.Controls.Add(this.Lbl_r1);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "Frm_luz";
            this.Text = "Frm_luz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.Button Btm_operar;
        private System.Windows.Forms.TextBox Txt_rangoconsumo;
        private System.Windows.Forms.Label Lbl_pago;
        private System.Windows.Forms.TextBox Txt_consumo;
        private System.Windows.Forms.Label Lbl_consumido;
        private System.Windows.Forms.Label Lbl_r4;
        private System.Windows.Forms.Label Lbl_r2;
        private System.Windows.Forms.Label Lbl_importe;
        private System.Windows.Forms.Label Lbl_consumo;
        private System.Windows.Forms.Label Lbl_r1;
        private System.Windows.Forms.Label Lbl_titulo;
    }
}