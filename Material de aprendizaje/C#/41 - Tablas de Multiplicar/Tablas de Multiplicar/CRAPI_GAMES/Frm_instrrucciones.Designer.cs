namespace CRAPI_GAMES
{
    partial class Frm_instrrucciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_instrrucciones));
            this.Lbl_instrucciones = new System.Windows.Forms.Label();
            this.Btm_comenzar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_instrucciones
            // 
            this.Lbl_instrucciones.AutoSize = true;
            this.Lbl_instrucciones.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_instrucciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_instrucciones.Location = new System.Drawing.Point(152, 33);
            this.Lbl_instrucciones.Name = "Lbl_instrucciones";
            this.Lbl_instrucciones.Size = new System.Drawing.Size(216, 33);
            this.Lbl_instrucciones.TabIndex = 0;
            this.Lbl_instrucciones.Text = "INSTRUCCIONES";
            this.Lbl_instrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btm_comenzar
            // 
            this.Btm_comenzar.BackColor = System.Drawing.Color.Lime;
            this.Btm_comenzar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btm_comenzar.Location = new System.Drawing.Point(327, 250);
            this.Btm_comenzar.Name = "Btm_comenzar";
            this.Btm_comenzar.Size = new System.Drawing.Size(163, 44);
            this.Btm_comenzar.TabIndex = 1;
            this.Btm_comenzar.Text = "COMENZAR";
            this.Btm_comenzar.UseVisualStyleBackColor = false;
            this.Btm_comenzar.Click += new System.EventHandler(this.Btm_comenzar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(27, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 149);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Debe desbloquear todos los resultados posibles mediante las multiplicaciones que " +
    "encuentre dentro de su tabla.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(27, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_instrrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(521, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btm_comenzar);
            this.Controls.Add(this.Lbl_instrucciones);
            this.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Frm_instrrucciones";
            this.Text = "INSTRUCCIONES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_instrucciones;
        private System.Windows.Forms.Button Btm_comenzar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}