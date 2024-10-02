namespace Interfaz_Base
{
    partial class CambiarColor
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
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.TemaTitulo = new System.Windows.Forms.Label();
            this.SeleccionaTema = new System.Windows.Forms.Label();
            this.OpcionesTemas = new System.Windows.Forms.ComboBox();
            this.Nota = new System.Windows.Forms.Label();
            this.OpcionLbl = new System.Windows.Forms.Label();
            this.BtmCancelar = new System.Windows.Forms.Button();
            this.BtmAceptar = new System.Windows.Forms.Button();
            this.Aplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(278, 48);
            this.BarraDeTitulo.TabIndex = 1;
            // 
            // TemaTitulo
            // 
            this.TemaTitulo.AutoSize = true;
            this.TemaTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemaTitulo.ForeColor = System.Drawing.Color.White;
            this.TemaTitulo.Location = new System.Drawing.Point(71, 60);
            this.TemaTitulo.Name = "TemaTitulo";
            this.TemaTitulo.Size = new System.Drawing.Size(127, 41);
            this.TemaTitulo.TabIndex = 2;
            this.TemaTitulo.Text = "TEMAS";
            // 
            // SeleccionaTema
            // 
            this.SeleccionaTema.AutoSize = true;
            this.SeleccionaTema.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionaTema.ForeColor = System.Drawing.Color.White;
            this.SeleccionaTema.Location = new System.Drawing.Point(12, 112);
            this.SeleccionaTema.Name = "SeleccionaTema";
            this.SeleccionaTema.Size = new System.Drawing.Size(197, 30);
            this.SeleccionaTema.TabIndex = 3;
            this.SeleccionaTema.Text = "Selecciona Tema";
            // 
            // OpcionesTemas
            // 
            this.OpcionesTemas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OpcionesTemas.DisplayMember = "Dark Dreams";
            this.OpcionesTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpcionesTemas.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionesTemas.ForeColor = System.Drawing.Color.Black;
            this.OpcionesTemas.FormattingEnabled = true;
            this.OpcionesTemas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OpcionesTemas.Items.AddRange(new object[] {
            "Dark Dreams",
            "Red Blood",
            "Breaking Stars",
            "Sweet People"});
            this.OpcionesTemas.Location = new System.Drawing.Point(17, 156);
            this.OpcionesTemas.Name = "OpcionesTemas";
            this.OpcionesTemas.Size = new System.Drawing.Size(249, 38);
            this.OpcionesTemas.TabIndex = 4;
            // 
            // Nota
            // 
            this.Nota.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nota.Location = new System.Drawing.Point(14, 206);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(252, 44);
            this.Nota.TabIndex = 5;
            this.Nota.Text = "La ventana actual se mostrará con el Tema Aplicado.";
            // 
            // OpcionLbl
            // 
            this.OpcionLbl.AutoSize = true;
            this.OpcionLbl.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionLbl.ForeColor = System.Drawing.Color.White;
            this.OpcionLbl.Location = new System.Drawing.Point(13, 295);
            this.OpcionLbl.Name = "OpcionLbl";
            this.OpcionLbl.Size = new System.Drawing.Size(239, 23);
            this.OpcionLbl.TabIndex = 6;
            this.OpcionLbl.Text = "¿Desea Guardar Cambios?";
            // 
            // BtmCancelar
            // 
            this.BtmCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BtmCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmCancelar.ForeColor = System.Drawing.Color.Silver;
            this.BtmCancelar.Location = new System.Drawing.Point(17, 332);
            this.BtmCancelar.Name = "BtmCancelar";
            this.BtmCancelar.Size = new System.Drawing.Size(92, 38);
            this.BtmCancelar.TabIndex = 7;
            this.BtmCancelar.Text = "Cancelar";
            this.BtmCancelar.UseVisualStyleBackColor = true;
            this.BtmCancelar.Click += new System.EventHandler(this.BtmCancelar_Click);
            // 
            // BtmAceptar
            // 
            this.BtmAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BtmAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmAceptar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmAceptar.ForeColor = System.Drawing.Color.Silver;
            this.BtmAceptar.Location = new System.Drawing.Point(174, 332);
            this.BtmAceptar.Name = "BtmAceptar";
            this.BtmAceptar.Size = new System.Drawing.Size(92, 38);
            this.BtmAceptar.TabIndex = 8;
            this.BtmAceptar.Text = "Aceptar";
            this.BtmAceptar.UseVisualStyleBackColor = true;
            this.BtmAceptar.Click += new System.EventHandler(this.BtmAceptar_Click);
            // 
            // Aplicar
            // 
            this.Aplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aplicar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aplicar.ForeColor = System.Drawing.Color.Silver;
            this.Aplicar.Location = new System.Drawing.Point(17, 253);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(92, 38);
            this.Aplicar.TabIndex = 9;
            this.Aplicar.Text = "Aplicar";
            this.Aplicar.UseVisualStyleBackColor = true;
            this.Aplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // CambiarColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(278, 382);
            this.Controls.Add(this.Aplicar);
            this.Controls.Add(this.BtmAceptar);
            this.Controls.Add(this.BtmCancelar);
            this.Controls.Add(this.OpcionLbl);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.OpcionesTemas);
            this.Controls.Add(this.SeleccionaTema);
            this.Controls.Add(this.TemaTitulo);
            this.Controls.Add(this.BarraDeTitulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarColor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CambiarColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.Label TemaTitulo;
        private System.Windows.Forms.Label SeleccionaTema;
        private System.Windows.Forms.ComboBox OpcionesTemas;
        private System.Windows.Forms.Label Nota;
        private System.Windows.Forms.Label OpcionLbl;
        private System.Windows.Forms.Button BtmCancelar;
        private System.Windows.Forms.Button BtmAceptar;
        private System.Windows.Forms.Button Aplicar;
    }
}