namespace Interfaz_Esquema
{
    partial class Frm_termometro_ambiental
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
            this.Lbl_centigrados = new System.Windows.Forms.Label();
            this.Txt_centigrados = new System.Windows.Forms.TextBox();
            this.Lbl_faren = new System.Windows.Forms.Label();
            this.Txt_faren = new System.Windows.Forms.TextBox();
            this.Btm_limpiar = new System.Windows.Forms.Button();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_titulo.Location = new System.Drawing.Point(190, 58);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(394, 37);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "TERMOMETRO AMBIENTAL";
            // 
            // Lbl_centigrados
            // 
            this.Lbl_centigrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_centigrados.AutoSize = true;
            this.Lbl_centigrados.Location = new System.Drawing.Point(28, 141);
            this.Lbl_centigrados.Name = "Lbl_centigrados";
            this.Lbl_centigrados.Size = new System.Drawing.Size(349, 37);
            this.Lbl_centigrados.TabIndex = 2;
            this.Lbl_centigrados.Text = "GRADOS CENTIGRADOS";
            // 
            // Txt_centigrados
            // 
            this.Txt_centigrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_centigrados.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_centigrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_centigrados.Location = new System.Drawing.Point(408, 141);
            this.Txt_centigrados.Name = "Txt_centigrados";
            this.Txt_centigrados.Size = new System.Drawing.Size(300, 36);
            this.Txt_centigrados.TabIndex = 11;
            this.Txt_centigrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_faren
            // 
            this.Lbl_faren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_faren.AutoSize = true;
            this.Lbl_faren.Location = new System.Drawing.Point(28, 232);
            this.Lbl_faren.Name = "Lbl_faren";
            this.Lbl_faren.Size = new System.Drawing.Size(320, 37);
            this.Lbl_faren.TabIndex = 12;
            this.Lbl_faren.Text = "GRADOS FARENHEITS";
            // 
            // Txt_faren
            // 
            this.Txt_faren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_faren.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_faren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_faren.Enabled = false;
            this.Txt_faren.Location = new System.Drawing.Point(408, 233);
            this.Txt_faren.Name = "Txt_faren";
            this.Txt_faren.Size = new System.Drawing.Size(300, 36);
            this.Txt_faren.TabIndex = 13;
            this.Txt_faren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(502, 414);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 18;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(85, 414);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 17;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Frm_termometro_ambiental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Txt_faren);
            this.Controls.Add(this.Lbl_faren);
            this.Controls.Add(this.Txt_centigrados);
            this.Controls.Add(this.Lbl_centigrados);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Frm_termometro_ambiental";
            this.Text = "Termometro_Ambiental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_centigrados;
        private System.Windows.Forms.TextBox Txt_centigrados;
        private System.Windows.Forms.Label Lbl_faren;
        private System.Windows.Forms.TextBox Txt_faren;
        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.Button Btm_operar;
    }
}