namespace Interfaz_Esquema
{
    partial class Frm_resta_condicional
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
            this.Txt_num2 = new System.Windows.Forms.TextBox();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.Txt_num1 = new System.Windows.Forms.TextBox();
            this.Lbl_num2 = new System.Windows.Forms.Label();
            this.Lbl_num1 = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Txt_resultado = new System.Windows.Forms.TextBox();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(525, 449);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 36;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Txt_num2
            // 
            this.Txt_num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_num2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_num2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_num2.Location = new System.Drawing.Point(374, 192);
            this.Txt_num2.Name = "Txt_num2";
            this.Txt_num2.Size = new System.Drawing.Size(367, 36);
            this.Txt_num2.TabIndex = 35;
            this.Txt_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(108, 449);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 34;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Txt_num1
            // 
            this.Txt_num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_num1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_num1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_num1.Location = new System.Drawing.Point(374, 140);
            this.Txt_num1.Name = "Txt_num1";
            this.Txt_num1.Size = new System.Drawing.Size(367, 36);
            this.Txt_num1.TabIndex = 33;
            this.Txt_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_num2
            // 
            this.Lbl_num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_num2.AutoSize = true;
            this.Lbl_num2.Location = new System.Drawing.Point(52, 192);
            this.Lbl_num2.Name = "Lbl_num2";
            this.Lbl_num2.Size = new System.Drawing.Size(221, 37);
            this.Lbl_num2.TabIndex = 32;
            this.Lbl_num2.Text = "2DO. NUMERO";
            // 
            // Lbl_num1
            // 
            this.Lbl_num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_num1.AutoSize = true;
            this.Lbl_num1.Location = new System.Drawing.Point(52, 140);
            this.Lbl_num1.Name = "Lbl_num1";
            this.Lbl_num1.Size = new System.Drawing.Size(209, 37);
            this.Lbl_num1.TabIndex = 31;
            this.Lbl_num1.Text = "1ER. NUMERO";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_titulo.Location = new System.Drawing.Point(202, 73);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(363, 37);
            this.Lbl_titulo.TabIndex = 30;
            this.Lbl_titulo.Text = "RESTA DE DOS NUMEROS";
            // 
            // Txt_resultado
            // 
            this.Txt_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_resultado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_resultado.Enabled = false;
            this.Txt_resultado.Location = new System.Drawing.Point(374, 251);
            this.Txt_resultado.Name = "Txt_resultado";
            this.Txt_resultado.Size = new System.Drawing.Size(367, 36);
            this.Txt_resultado.TabIndex = 38;
            this.Txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.Location = new System.Drawing.Point(52, 251);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(186, 37);
            this.Lbl_resultado.TabIndex = 37;
            this.Lbl_resultado.Text = "RESULTADO";
            // 
            // Frm_resta_condicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.Txt_resultado);
            this.Controls.Add(this.Lbl_resultado);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Txt_num2);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Txt_num1);
            this.Controls.Add(this.Lbl_num2);
            this.Controls.Add(this.Lbl_num1);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "Frm_resta_condicional";
            this.Text = "Frm_resta_condicional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.TextBox Txt_num2;
        private System.Windows.Forms.Button Btm_operar;
        private System.Windows.Forms.TextBox Txt_num1;
        private System.Windows.Forms.Label Lbl_num2;
        private System.Windows.Forms.Label Lbl_num1;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TextBox Txt_resultado;
        private System.Windows.Forms.Label Lbl_resultado;
    }
}