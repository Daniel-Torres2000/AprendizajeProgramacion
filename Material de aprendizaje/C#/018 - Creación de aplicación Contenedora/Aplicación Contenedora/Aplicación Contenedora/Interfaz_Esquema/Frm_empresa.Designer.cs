namespace Interfaz_Esquema
{
    partial class Frm_empresa
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
            this.Txt_precio_venta = new System.Windows.Forms.TextBox();
            this.Txt_ganancia = new System.Windows.Forms.TextBox();
            this.Txt_produccion = new System.Windows.Forms.TextBox();
            this.Btm_operar = new System.Windows.Forms.Button();
            this.Txt_costo = new System.Windows.Forms.TextBox();
            this.Lbl_precio_venta = new System.Windows.Forms.Label();
            this.Lbl_ganancia = new System.Windows.Forms.Label();
            this.Lbl_produccion = new System.Windows.Forms.Label();
            this.Lbl_costo = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btm_limpiar
            // 
            this.Btm_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_limpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_limpiar.Location = new System.Drawing.Point(525, 450);
            this.Btm_limpiar.Name = "Btm_limpiar";
            this.Btm_limpiar.Size = new System.Drawing.Size(166, 55);
            this.Btm_limpiar.TabIndex = 29;
            this.Btm_limpiar.Text = "LIMPIAR";
            this.Btm_limpiar.UseVisualStyleBackColor = false;
            this.Btm_limpiar.Click += new System.EventHandler(this.Btm_limpiar_Click);
            // 
            // Txt_precio_venta
            // 
            this.Txt_precio_venta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_precio_venta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_precio_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_precio_venta.Enabled = false;
            this.Txt_precio_venta.Location = new System.Drawing.Point(439, 293);
            this.Txt_precio_venta.Name = "Txt_precio_venta";
            this.Txt_precio_venta.Size = new System.Drawing.Size(302, 36);
            this.Txt_precio_venta.TabIndex = 27;
            this.Txt_precio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_ganancia
            // 
            this.Txt_ganancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ganancia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_ganancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ganancia.Enabled = false;
            this.Txt_ganancia.Location = new System.Drawing.Point(439, 243);
            this.Txt_ganancia.Name = "Txt_ganancia";
            this.Txt_ganancia.Size = new System.Drawing.Size(302, 36);
            this.Txt_ganancia.TabIndex = 26;
            this.Txt_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_produccion
            // 
            this.Txt_produccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_produccion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_produccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_produccion.Enabled = false;
            this.Txt_produccion.Location = new System.Drawing.Point(439, 193);
            this.Txt_produccion.Name = "Txt_produccion";
            this.Txt_produccion.Size = new System.Drawing.Size(302, 36);
            this.Txt_produccion.TabIndex = 25;
            this.Txt_produccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btm_operar
            // 
            this.Btm_operar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btm_operar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btm_operar.Location = new System.Drawing.Point(108, 450);
            this.Btm_operar.Name = "Btm_operar";
            this.Btm_operar.Size = new System.Drawing.Size(166, 55);
            this.Btm_operar.TabIndex = 24;
            this.Btm_operar.Text = "OPERAR";
            this.Btm_operar.UseVisualStyleBackColor = false;
            this.Btm_operar.Click += new System.EventHandler(this.Btm_operar_Click);
            // 
            // Txt_costo
            // 
            this.Txt_costo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_costo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Txt_costo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_costo.Location = new System.Drawing.Point(439, 141);
            this.Txt_costo.Name = "Txt_costo";
            this.Txt_costo.Size = new System.Drawing.Size(302, 36);
            this.Txt_costo.TabIndex = 23;
            this.Txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_precio_venta
            // 
            this.Lbl_precio_venta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_precio_venta.AutoSize = true;
            this.Lbl_precio_venta.Location = new System.Drawing.Point(52, 293);
            this.Lbl_precio_venta.Name = "Lbl_precio_venta";
            this.Lbl_precio_venta.Size = new System.Drawing.Size(273, 37);
            this.Lbl_precio_venta.TabIndex = 21;
            this.Lbl_precio_venta.Text = "PRECIO DE VENTA";
            // 
            // Lbl_ganancia
            // 
            this.Lbl_ganancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ganancia.AutoSize = true;
            this.Lbl_ganancia.Location = new System.Drawing.Point(52, 243);
            this.Lbl_ganancia.Name = "Lbl_ganancia";
            this.Lbl_ganancia.Size = new System.Drawing.Size(174, 37);
            this.Lbl_ganancia.TabIndex = 20;
            this.Lbl_ganancia.Text = "GANANCIA";
            // 
            // Lbl_produccion
            // 
            this.Lbl_produccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_produccion.AutoSize = true;
            this.Lbl_produccion.Location = new System.Drawing.Point(52, 193);
            this.Lbl_produccion.Name = "Lbl_produccion";
            this.Lbl_produccion.Size = new System.Drawing.Size(375, 37);
            this.Lbl_produccion.TabIndex = 19;
            this.Lbl_produccion.Text = "GASTOS DE PRODUCCION";
            // 
            // Lbl_costo
            // 
            this.Lbl_costo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_costo.AutoSize = true;
            this.Lbl_costo.Location = new System.Drawing.Point(52, 141);
            this.Lbl_costo.Name = "Lbl_costo";
            this.Lbl_costo.Size = new System.Drawing.Size(326, 37);
            this.Lbl_costo.TabIndex = 18;
            this.Lbl_costo.Text = "COSTO DE PRODUCTO";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_titulo.Location = new System.Drawing.Point(202, 74);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(354, 37);
            this.Lbl_titulo.TabIndex = 17;
            this.Lbl_titulo.Text = "EMPRESA PRODUCCION";
            // 
            // Frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(793, 576);
            this.Controls.Add(this.Btm_limpiar);
            this.Controls.Add(this.Txt_precio_venta);
            this.Controls.Add(this.Txt_ganancia);
            this.Controls.Add(this.Txt_produccion);
            this.Controls.Add(this.Btm_operar);
            this.Controls.Add(this.Txt_costo);
            this.Controls.Add(this.Lbl_precio_venta);
            this.Controls.Add(this.Lbl_ganancia);
            this.Controls.Add(this.Lbl_produccion);
            this.Controls.Add(this.Lbl_costo);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "Frm_empresa";
            this.Text = "Frm_empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btm_limpiar;
        private System.Windows.Forms.TextBox Txt_precio_venta;
        private System.Windows.Forms.TextBox Txt_ganancia;
        private System.Windows.Forms.TextBox Txt_produccion;
        private System.Windows.Forms.Button Btm_operar;
        private System.Windows.Forms.TextBox Txt_costo;
        private System.Windows.Forms.Label Lbl_precio_venta;
        private System.Windows.Forms.Label Lbl_ganancia;
        private System.Windows.Forms.Label Lbl_produccion;
        private System.Windows.Forms.Label Lbl_costo;
        private System.Windows.Forms.Label Lbl_titulo;
    }
}