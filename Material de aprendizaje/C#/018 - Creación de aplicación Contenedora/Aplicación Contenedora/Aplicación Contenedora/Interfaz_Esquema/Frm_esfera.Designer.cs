﻿namespace Interfaz_Esquema
{
    partial class Frm_esfera
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
            this.Lbl_radio = new System.Windows.Forms.Label();
            this.Lbl_volumen = new System.Windows.Forms.Label();
            this.Lbl_area = new System.Windows.Forms.Label();
            this.Txt_radio = new System.Windows.Forms.TextBox();
            this.Txt_area = new System.Windows.Forms.TextBox();
            this.Txt_volumen = new System.Windows.Forms.TextBox();
            this.Btm_limpiar = new System.Windows.Forms.Button();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_titulo.Location = new System.Drawing.Point(138, 54);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(501, 37);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "VOLUMEN Y AREA DE UNA ESFERA";
            // 
            // Lbl_radio
            // 
            this.Lbl_radio.AutoSize = true;
            this.Lbl_radio.Location = new System.Drawing.Point(91, 133);
            this.Lbl_radio.Name = "Lbl_radio";
            this.Lbl_radio.Size = new System.Drawing.Size(111, 37);
            this.Lbl_radio.TabIndex = 1;
            this.Lbl_radio.Text = "RADIO";
            // 
            // Lbl_volumen
            // 
            this.Lbl_volumen.AutoSize = true;
            this.Lbl_volumen.Location = new System.Drawing.Point(91, 250);
            this.Lbl_volumen.Name = "Lbl_volumen";
            this.Lbl_volumen.Size = new System.Drawing.Size(161, 37);
            this.Lbl_volumen.TabIndex = 2;
            this.Lbl_volumen.Text = "VOLUMEN";
            // 
            // Lbl_area
            // 
            this.Lbl_area.AutoSize = true;
            this.Lbl_area.Location = new System.Drawing.Point(91, 192);
            this.Lbl_area.Name = "Lbl_area";
            this.Lbl_area.Size = new System.Drawing.Size(96, 37);
            this.Lbl_area.TabIndex = 3;
            this.Lbl_area.Text = "AREA";
            // 
            // Txt_radio
            // 
            this.Txt_radio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_radio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_radio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_radio.Location = new System.Drawing.Point(286, 133);
            this.Txt_radio.Name = "Txt_radio";
            this.Txt_radio.Size = new System.Drawing.Size(390, 36);
            this.Txt_radio.TabIndex = 12;
            this.Txt_radio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_area
            // 
            this.Txt_area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_area.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_area.Enabled = false;
            this.Txt_area.Location = new System.Drawing.Point(286, 192);
            this.Txt_area.Name = "Txt_area";
            this.Txt_area.Size = new System.Drawing.Size(390, 36);
            this.Txt_area.TabIndex = 13;
            this.Txt_area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_volumen
            // 
            this.Txt_volumen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_volumen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_volumen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_volumen.Enabled = false;
            this.Txt_volumen.Location = new System.Drawing.Point(286, 250);
            this.Txt_volumen.Name = "Txt_volumen";
            this.Txt_volumen.Size = new System.Drawing.Size(390, 36);
            this.Txt_volumen.TabIndex = 14;
            this.Txt_volumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(510, 421);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 20;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(93, 421);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 19;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Frm_esfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Txt_volumen);
            this.Controls.Add(this.Txt_area);
            this.Controls.Add(this.Txt_radio);
            this.Controls.Add(this.Lbl_area);
            this.Controls.Add(this.Lbl_volumen);
            this.Controls.Add(this.Lbl_radio);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "Frm_esfera";
            this.Text = "Frm_esfera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_radio;
        private System.Windows.Forms.Label Lbl_volumen;
        private System.Windows.Forms.Label Lbl_area;
        private System.Windows.Forms.TextBox Txt_radio;
        private System.Windows.Forms.TextBox Txt_area;
        private System.Windows.Forms.TextBox Txt_volumen;
        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.Button Btm_operar;
    }
}