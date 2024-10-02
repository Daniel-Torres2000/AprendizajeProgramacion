namespace Interfaz_Esquema
{
    partial class Frm_balones
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
            this.Txt_resultado = new System.Windows.Forms.TextBox();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Btm_limpiar = new System.Windows.Forms.Button();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.Txt_balones = new System.Windows.Forms.TextBox();
            this.Lbl_balones = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_resultado
            // 
            this.Txt_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_resultado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_resultado.Enabled = false;
            this.Txt_resultado.Location = new System.Drawing.Point(342, 201);
            this.Txt_resultado.Name = "Txt_resultado";
            this.Txt_resultado.Size = new System.Drawing.Size(399, 36);
            this.Txt_resultado.TabIndex = 47;
            this.Txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.Location = new System.Drawing.Point(52, 200);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(186, 37);
            this.Lbl_resultado.TabIndex = 46;
            this.Lbl_resultado.Text = "RESULTADO";
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(525, 449);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 45;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(108, 449);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 43;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Txt_balones
            // 
            this.Txt_balones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_balones.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_balones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_balones.Location = new System.Drawing.Point(342, 140);
            this.Txt_balones.Name = "Txt_balones";
            this.Txt_balones.Size = new System.Drawing.Size(399, 36);
            this.Txt_balones.TabIndex = 42;
            this.Txt_balones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_balones
            // 
            this.Lbl_balones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_balones.AutoSize = true;
            this.Lbl_balones.Location = new System.Drawing.Point(52, 140);
            this.Lbl_balones.Name = "Lbl_balones";
            this.Lbl_balones.Size = new System.Drawing.Size(151, 37);
            this.Lbl_balones.TabIndex = 40;
            this.Lbl_balones.Text = "BALONES";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_titulo.Location = new System.Drawing.Point(225, 73);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(311, 37);
            this.Lbl_titulo.TabIndex = 39;
            this.Lbl_titulo.Text = "PRECIO DE BALONES";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(292, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 36);
            this.textBox1.TabIndex = 48;
            this.textBox1.Text = "Q";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_balones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Txt_resultado);
            this.Controls.Add(this.Lbl_resultado);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Txt_balones);
            this.Controls.Add(this.Lbl_balones);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Frm_balones";
            this.Text = "Frm_balones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_resultado;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.Button Btm_operar;
        private System.Windows.Forms.TextBox Txt_balones;
        private System.Windows.Forms.Label Lbl_balones;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TextBox textBox1;
    }
}