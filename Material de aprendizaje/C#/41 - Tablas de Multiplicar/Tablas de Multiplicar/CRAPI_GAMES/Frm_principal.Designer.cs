namespace CRAPI_GAMES
{
    partial class Frm_principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btm_jugar = new System.Windows.Forms.Button();
            this.Btm_instrucciones = new System.Windows.Forms.Button();
            this.Btm_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Location = new System.Drawing.Point(100, 57);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(316, 30);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "TABLAS DE MULTIPLICAR";
            // 
            // Btm_jugar
            // 
            this.Btm_jugar.BackColor = System.Drawing.Color.Snow;
            this.Btm_jugar.Location = new System.Drawing.Point(105, 147);
            this.Btm_jugar.Name = "Btm_jugar";
            this.Btm_jugar.Size = new System.Drawing.Size(105, 39);
            this.Btm_jugar.TabIndex = 1;
            this.Btm_jugar.Text = "JUGAR";
            this.Btm_jugar.UseVisualStyleBackColor = false;
            this.Btm_jugar.Click += new System.EventHandler(this.Btm_jugar_Click);
            // 
            // Btm_instrucciones
            // 
            this.Btm_instrucciones.BackColor = System.Drawing.Color.Snow;
            this.Btm_instrucciones.Location = new System.Drawing.Point(155, 206);
            this.Btm_instrucciones.Name = "Btm_instrucciones";
            this.Btm_instrucciones.Size = new System.Drawing.Size(216, 39);
            this.Btm_instrucciones.TabIndex = 2;
            this.Btm_instrucciones.Text = "INSTRUCCIONES";
            this.Btm_instrucciones.UseVisualStyleBackColor = false;
            this.Btm_instrucciones.Click += new System.EventHandler(this.Btm_instrucciones_Click);
            // 
            // Btm_salir
            // 
            this.Btm_salir.BackColor = System.Drawing.Color.Snow;
            this.Btm_salir.Location = new System.Drawing.Point(311, 147);
            this.Btm_salir.Name = "Btm_salir";
            this.Btm_salir.Size = new System.Drawing.Size(105, 39);
            this.Btm_salir.TabIndex = 3;
            this.Btm_salir.Text = "SALIR";
            this.Btm_salir.UseVisualStyleBackColor = false;
            this.Btm_salir.Click += new System.EventHandler(this.Btm_salir_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(521, 322);
            this.Controls.Add(this.Btm_salir);
            this.Controls.Add(this.Btm_instrucciones);
            this.Controls.Add(this.Btm_jugar);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Frm_principal";
            this.Text = "TABLAS_DE_MULTIPLICAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btm_jugar;
        private System.Windows.Forms.Button Btm_instrucciones;
        private System.Windows.Forms.Button Btm_salir;
    }
}

