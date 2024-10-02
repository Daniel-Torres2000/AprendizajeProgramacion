namespace Poo_OperacionesBasicas
{
    partial class Aplicacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            //this.Close = new System.Windows.Forms.Button();
            this.TituloAplicacion = new System.Windows.Forms.Label();
            this.ContenedorGeneral = new System.Windows.Forms.Panel();
            this.OperacionesCont = new System.Windows.Forms.Panel();
            this.Clean = new System.Windows.Forms.Button();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.Lblr = new System.Windows.Forms.Label();
            this.Divi = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Txtn2 = new System.Windows.Forms.TextBox();
            this.Txtn1 = new System.Windows.Forms.TextBox();
            this.Lbln2 = new System.Windows.Forms.Label();
            this.Lbln1 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.ContenedorGeneral.SuspendLayout();
            this.OperacionesCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Silver;
           // this.BarraTitulo.Controls.Add(this.Close);
            this.BarraTitulo.Controls.Add(this.TituloAplicacion);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(510, 27);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            // 
            // Close
            // 
           /* this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Kristen ITC", 11F);
            this.Close.Location = new System.Drawing.Point(479, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 27);
            this.Close.TabIndex = 13;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            
            */
            // 
            // TituloAplicacion
            // 
            this.TituloAplicacion.AutoSize = true;
            this.TituloAplicacion.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloAplicacion.Location = new System.Drawing.Point(3, 1);
            this.TituloAplicacion.Name = "TituloAplicacion";
            this.TituloAplicacion.Size = new System.Drawing.Size(170, 23);
            this.TituloAplicacion.TabIndex = 0;
            this.TituloAplicacion.Text = "Operaciones Básicas";
            // 
            // ContenedorGeneral
            // 
            this.ContenedorGeneral.Controls.Add(this.OperacionesCont);
            this.ContenedorGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorGeneral.Location = new System.Drawing.Point(0, 27);
            this.ContenedorGeneral.Name = "ContenedorGeneral";
            this.ContenedorGeneral.Size = new System.Drawing.Size(510, 275);
            this.ContenedorGeneral.TabIndex = 2;
            // 
            // OperacionesCont
            // 
            this.OperacionesCont.Controls.Add(this.Clean);
            this.OperacionesCont.Controls.Add(this.TxtResultado);
            this.OperacionesCont.Controls.Add(this.Lblr);
            this.OperacionesCont.Controls.Add(this.Divi);
            this.OperacionesCont.Controls.Add(this.Multi);
            this.OperacionesCont.Controls.Add(this.Resta);
            this.OperacionesCont.Controls.Add(this.Suma);
            this.OperacionesCont.Controls.Add(this.Txtn2);
            this.OperacionesCont.Controls.Add(this.Txtn1);
            this.OperacionesCont.Controls.Add(this.Lbln2);
            this.OperacionesCont.Controls.Add(this.Lbln1);
            this.OperacionesCont.Location = new System.Drawing.Point(12, 6);
            this.OperacionesCont.Name = "OperacionesCont";
            this.OperacionesCont.Size = new System.Drawing.Size(475, 241);
            this.OperacionesCont.TabIndex = 0;
            // 
            // Clean
            // 
            this.Clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clean.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean.Location = new System.Drawing.Point(27, 195);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(97, 33);
            this.Clean.TabIndex = 12;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.Location = new System.Drawing.Point(176, 153);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(289, 33);
            this.TxtResultado.TabIndex = 11;
            // 
            // Lblr
            // 
            this.Lblr.AutoSize = true;
            this.Lblr.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblr.ForeColor = System.Drawing.Color.Black;
            this.Lblr.Location = new System.Drawing.Point(22, 156);
            this.Lblr.Name = "Lblr";
            this.Lblr.Size = new System.Drawing.Size(106, 27);
            this.Lblr.TabIndex = 10;
            this.Lblr.Text = "Resultado";
            // 
            // Divi
            // 
            this.Divi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Divi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divi.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divi.Location = new System.Drawing.Point(368, 102);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(97, 33);
            this.Divi.TabIndex = 9;
            this.Divi.Text = "Division";
            this.Divi.UseVisualStyleBackColor = true;
            this.Divi.Click += new System.EventHandler(this.Divi_Click);
            // 
            // Multi
            // 
            this.Multi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multi.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.Location = new System.Drawing.Point(227, 102);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(135, 33);
            this.Multi.TabIndex = 8;
            this.Multi.Text = "Multiplicacion";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Resta
            // 
            this.Resta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Resta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resta.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(124, 102);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(97, 33);
            this.Resta.TabIndex = 7;
            this.Resta.Text = "Resta";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Suma
            // 
            this.Suma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suma.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(21, 102);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(97, 33);
            this.Suma.TabIndex = 6;
            this.Suma.Text = "Suma";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Txtn2
            // 
            this.Txtn2.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtn2.Location = new System.Drawing.Point(176, 53);
            this.Txtn2.Name = "Txtn2";
            this.Txtn2.Size = new System.Drawing.Size(289, 33);
            this.Txtn2.TabIndex = 5;
            // 
            // Txtn1
            // 
            this.Txtn1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtn1.Location = new System.Drawing.Point(176, 14);
            this.Txtn1.Name = "Txtn1";
            this.Txtn1.Size = new System.Drawing.Size(289, 33);
            this.Txtn1.TabIndex = 4;
            // 
            // Lbln2
            // 
            this.Lbln2.AutoSize = true;
            this.Lbln2.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbln2.ForeColor = System.Drawing.Color.Black;
            this.Lbln2.Location = new System.Drawing.Point(22, 56);
            this.Lbln2.Name = "Lbln2";
            this.Lbln2.Size = new System.Drawing.Size(103, 27);
            this.Lbln2.TabIndex = 3;
            this.Lbln2.Text = "Número 2";
            // 
            // Lbln1
            // 
            this.Lbln1.AutoSize = true;
            this.Lbln1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbln1.ForeColor = System.Drawing.Color.Black;
            this.Lbln1.Location = new System.Drawing.Point(22, 17);
            this.Lbln1.Name = "Lbln1";
            this.Lbln1.Size = new System.Drawing.Size(102, 27);
            this.Lbln1.TabIndex = 2;
            this.Lbln1.Text = "Número 1";
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(510, 302);
            this.Controls.Add(this.ContenedorGeneral);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ContenedorGeneral.ResumeLayout(false);
            this.OperacionesCont.ResumeLayout(false);
            this.OperacionesCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label TituloAplicacion;
        private System.Windows.Forms.Panel ContenedorGeneral;
        private System.Windows.Forms.Panel OperacionesCont;
        private System.Windows.Forms.Button Divi;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.TextBox Txtn2;
        private System.Windows.Forms.TextBox Txtn1;
        private System.Windows.Forms.Label Lbln2;
        private System.Windows.Forms.Label Lbln1;
       // private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label Lblr;
    }
}

