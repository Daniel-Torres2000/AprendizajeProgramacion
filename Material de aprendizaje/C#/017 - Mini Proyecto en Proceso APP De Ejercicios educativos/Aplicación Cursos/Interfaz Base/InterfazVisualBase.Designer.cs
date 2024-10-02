namespace Interfaz_Base
{
    partial class InterfazVisualBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazVisualBase));
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.Pestañas = new System.Windows.Forms.Panel();
            this.PinFormato = new System.Windows.Forms.Panel();
            this.Formato = new System.Windows.Forms.Button();
            this.PinArchivo = new System.Windows.Forms.Panel();
            this.Archivo = new System.Windows.Forms.Button();
            this.GrupoArchivo = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.Button();
            this.GuardarComo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Abrir = new System.Windows.Forms.Button();
            this.GrupoFormato = new System.Windows.Forms.Panel();
            this.Temas = new System.Windows.Forms.Button();
            this.Fuente = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PinLenguajes = new System.Windows.Forms.Panel();
            this.Lenguajes = new System.Windows.Forms.Button();
            this.GrupoLenguajes = new System.Windows.Forms.Panel();
            this.LengJava = new System.Windows.Forms.Button();
            this.LengDev = new System.Windows.Forms.Button();
            this.LengC = new System.Windows.Forms.Button();
            this.LengPSeint = new System.Windows.Forms.Button();
            this.LengCsharp = new System.Windows.Forms.Button();
            this.LengHtml = new System.Windows.Forms.Button();
            this.LengCss = new System.Windows.Forms.Button();
            this.LengJavaScript = new System.Windows.Forms.Button();
            this.LengSQL = new System.Windows.Forms.Button();
            this.LengAndroid = new System.Windows.Forms.Button();
            this.BarraDeTitulo.SuspendLayout();
            this.Pestañas.SuspendLayout();
            this.GrupoArchivo.SuspendLayout();
            this.GrupoFormato.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.GrupoLenguajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BarraDeTitulo.Controls.Add(this.Pestañas);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(800, 68);
            this.BarraDeTitulo.TabIndex = 0;
            this.BarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraDeTitulo_MouseDown);
            // 
            // Pestañas
            // 
            this.Pestañas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Pestañas.Controls.Add(this.PinLenguajes);
            this.Pestañas.Controls.Add(this.PinFormato);
            this.Pestañas.Controls.Add(this.Lenguajes);
            this.Pestañas.Controls.Add(this.Formato);
            this.Pestañas.Controls.Add(this.PinArchivo);
            this.Pestañas.Controls.Add(this.Archivo);
            this.Pestañas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pestañas.Location = new System.Drawing.Point(0, 27);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.Size = new System.Drawing.Size(800, 41);
            this.Pestañas.TabIndex = 1;
            // 
            // PinFormato
            // 
            this.PinFormato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.PinFormato.Location = new System.Drawing.Point(114, 0);
            this.PinFormato.Name = "PinFormato";
            this.PinFormato.Size = new System.Drawing.Size(13, 41);
            this.PinFormato.TabIndex = 3;
            // 
            // Formato
            // 
            this.Formato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Formato.FlatAppearance.BorderSize = 0;
            this.Formato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Formato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Formato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Formato.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formato.ForeColor = System.Drawing.Color.White;
            this.Formato.Location = new System.Drawing.Point(126, 0);
            this.Formato.Name = "Formato";
            this.Formato.Size = new System.Drawing.Size(106, 41);
            this.Formato.TabIndex = 2;
            this.Formato.Text = "Formato";
            this.Formato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Formato.UseVisualStyleBackColor = false;
            this.Formato.Click += new System.EventHandler(this.Formato_Click);
            // 
            // PinArchivo
            // 
            this.PinArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.PinArchivo.Location = new System.Drawing.Point(0, 0);
            this.PinArchivo.Name = "PinArchivo";
            this.PinArchivo.Size = new System.Drawing.Size(13, 41);
            this.PinArchivo.TabIndex = 1;
            // 
            // Archivo
            // 
            this.Archivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Archivo.FlatAppearance.BorderSize = 0;
            this.Archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Archivo.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archivo.ForeColor = System.Drawing.Color.White;
            this.Archivo.Location = new System.Drawing.Point(12, 0);
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(108, 41);
            this.Archivo.TabIndex = 0;
            this.Archivo.Text = "Archivo";
            this.Archivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Archivo.UseVisualStyleBackColor = false;
            this.Archivo.Click += new System.EventHandler(this.Archivo_Click);
            // 
            // GrupoArchivo
            // 
            this.GrupoArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GrupoArchivo.Controls.Add(this.Salir);
            this.GrupoArchivo.Controls.Add(this.GuardarComo);
            this.GrupoArchivo.Controls.Add(this.Guardar);
            this.GrupoArchivo.Controls.Add(this.Abrir);
            this.GrupoArchivo.Location = new System.Drawing.Point(12, 89);
            this.GrupoArchivo.Name = "GrupoArchivo";
            this.GrupoArchivo.Size = new System.Drawing.Size(183, 183);
            this.GrupoArchivo.TabIndex = 4;
            this.GrupoArchivo.Visible = false;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(0, 141);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(186, 41);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "  Salir";
            this.Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // GuardarComo
            // 
            this.GuardarComo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GuardarComo.FlatAppearance.BorderSize = 0;
            this.GuardarComo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GuardarComo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.GuardarComo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarComo.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarComo.ForeColor = System.Drawing.Color.White;
            this.GuardarComo.Location = new System.Drawing.Point(0, 94);
            this.GuardarComo.Name = "GuardarComo";
            this.GuardarComo.Size = new System.Drawing.Size(183, 41);
            this.GuardarComo.TabIndex = 3;
            this.GuardarComo.Text = "  Guardar Cómo";
            this.GuardarComo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarComo.UseVisualStyleBackColor = false;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(0, 47);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(186, 41);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "  Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.UseVisualStyleBackColor = false;
            // 
            // Abrir
            // 
            this.Abrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Abrir.FlatAppearance.BorderSize = 0;
            this.Abrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abrir.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abrir.ForeColor = System.Drawing.Color.White;
            this.Abrir.Location = new System.Drawing.Point(0, 0);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(181, 41);
            this.Abrir.TabIndex = 1;
            this.Abrir.Text = "  Abrir";
            this.Abrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abrir.UseVisualStyleBackColor = false;
            // 
            // GrupoFormato
            // 
            this.GrupoFormato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GrupoFormato.Controls.Add(this.Temas);
            this.GrupoFormato.Controls.Add(this.Fuente);
            this.GrupoFormato.Location = new System.Drawing.Point(12, 303);
            this.GrupoFormato.Name = "GrupoFormato";
            this.GrupoFormato.Size = new System.Drawing.Size(183, 88);
            this.GrupoFormato.TabIndex = 5;
            this.GrupoFormato.Visible = false;
            // 
            // Temas
            // 
            this.Temas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Temas.FlatAppearance.BorderSize = 0;
            this.Temas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Temas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Temas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temas.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temas.ForeColor = System.Drawing.Color.White;
            this.Temas.Location = new System.Drawing.Point(0, 47);
            this.Temas.Name = "Temas";
            this.Temas.Size = new System.Drawing.Size(186, 41);
            this.Temas.TabIndex = 2;
            this.Temas.Text = "  Temas";
            this.Temas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Temas.UseVisualStyleBackColor = false;
            this.Temas.Click += new System.EventHandler(this.Temas_Click);
            // 
            // Fuente
            // 
            this.Fuente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Fuente.FlatAppearance.BorderSize = 0;
            this.Fuente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Fuente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Fuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fuente.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fuente.ForeColor = System.Drawing.Color.White;
            this.Fuente.Location = new System.Drawing.Point(0, 0);
            this.Fuente.Name = "Fuente";
            this.Fuente.Size = new System.Drawing.Size(183, 41);
            this.Fuente.TabIndex = 1;
            this.Fuente.Text = "  Fuente";
            this.Fuente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fuente.UseVisualStyleBackColor = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.GrupoLenguajes);
            this.PanelContenedor.Controls.Add(this.GrupoFormato);
            this.PanelContenedor.Controls.Add(this.GrupoArchivo);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 600);
            this.PanelContenedor.TabIndex = 6;
            // 
            // PinLenguajes
            // 
            this.PinLenguajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.PinLenguajes.Location = new System.Drawing.Point(226, 0);
            this.PinLenguajes.Name = "PinLenguajes";
            this.PinLenguajes.Size = new System.Drawing.Size(13, 41);
            this.PinLenguajes.TabIndex = 7;
            // 
            // Lenguajes
            // 
            this.Lenguajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Lenguajes.FlatAppearance.BorderSize = 0;
            this.Lenguajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.Lenguajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Lenguajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lenguajes.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lenguajes.ForeColor = System.Drawing.Color.White;
            this.Lenguajes.Location = new System.Drawing.Point(238, 0);
            this.Lenguajes.Name = "Lenguajes";
            this.Lenguajes.Size = new System.Drawing.Size(120, 41);
            this.Lenguajes.TabIndex = 6;
            this.Lenguajes.Text = "Lenguajes";
            this.Lenguajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lenguajes.UseVisualStyleBackColor = false;
            this.Lenguajes.Click += new System.EventHandler(this.Lenguajes_Click);
            // 
            // GrupoLenguajes
            // 
            this.GrupoLenguajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GrupoLenguajes.Controls.Add(this.LengAndroid);
            this.GrupoLenguajes.Controls.Add(this.LengSQL);
            this.GrupoLenguajes.Controls.Add(this.LengJavaScript);
            this.GrupoLenguajes.Controls.Add(this.LengCss);
            this.GrupoLenguajes.Controls.Add(this.LengHtml);
            this.GrupoLenguajes.Controls.Add(this.LengCsharp);
            this.GrupoLenguajes.Controls.Add(this.LengJava);
            this.GrupoLenguajes.Controls.Add(this.LengDev);
            this.GrupoLenguajes.Controls.Add(this.LengC);
            this.GrupoLenguajes.Controls.Add(this.LengPSeint);
            this.GrupoLenguajes.Location = new System.Drawing.Point(267, 74);
            this.GrupoLenguajes.Name = "GrupoLenguajes";
            this.GrupoLenguajes.Size = new System.Drawing.Size(180, 461);
            this.GrupoLenguajes.TabIndex = 6;
            this.GrupoLenguajes.Visible = false;
            // 
            // LengJava
            // 
            this.LengJava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengJava.FlatAppearance.BorderSize = 0;
            this.LengJava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengJava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengJava.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengJava.ForeColor = System.Drawing.Color.White;
            this.LengJava.Location = new System.Drawing.Point(0, 141);
            this.LengJava.Name = "LengJava";
            this.LengJava.Size = new System.Drawing.Size(186, 41);
            this.LengJava.TabIndex = 4;
            this.LengJava.Text = "  Java";
            this.LengJava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengJava.UseVisualStyleBackColor = false;
            // 
            // LengDev
            // 
            this.LengDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengDev.FlatAppearance.BorderSize = 0;
            this.LengDev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengDev.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengDev.ForeColor = System.Drawing.Color.White;
            this.LengDev.Location = new System.Drawing.Point(0, 94);
            this.LengDev.Name = "LengDev";
            this.LengDev.Size = new System.Drawing.Size(183, 41);
            this.LengDev.TabIndex = 3;
            this.LengDev.Text = "  Dev C++";
            this.LengDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengDev.UseVisualStyleBackColor = false;
            // 
            // LengC
            // 
            this.LengC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengC.FlatAppearance.BorderSize = 0;
            this.LengC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengC.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengC.ForeColor = System.Drawing.Color.White;
            this.LengC.Location = new System.Drawing.Point(0, 47);
            this.LengC.Name = "LengC";
            this.LengC.Size = new System.Drawing.Size(186, 41);
            this.LengC.TabIndex = 2;
            this.LengC.Text = "  Lenguaje C";
            this.LengC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengC.UseVisualStyleBackColor = false;
            // 
            // LengPSeint
            // 
            this.LengPSeint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengPSeint.FlatAppearance.BorderSize = 0;
            this.LengPSeint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengPSeint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengPSeint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengPSeint.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengPSeint.ForeColor = System.Drawing.Color.White;
            this.LengPSeint.Location = new System.Drawing.Point(0, 0);
            this.LengPSeint.Name = "LengPSeint";
            this.LengPSeint.Size = new System.Drawing.Size(181, 41);
            this.LengPSeint.TabIndex = 1;
            this.LengPSeint.Text = "  PSeint";
            this.LengPSeint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengPSeint.UseVisualStyleBackColor = false;
            this.LengPSeint.Click += new System.EventHandler(this.LengPSeint_Click);
            // 
            // LengCsharp
            // 
            this.LengCsharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengCsharp.FlatAppearance.BorderSize = 0;
            this.LengCsharp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengCsharp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengCsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengCsharp.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengCsharp.ForeColor = System.Drawing.Color.White;
            this.LengCsharp.Location = new System.Drawing.Point(0, 187);
            this.LengCsharp.Name = "LengCsharp";
            this.LengCsharp.Size = new System.Drawing.Size(186, 41);
            this.LengCsharp.TabIndex = 5;
            this.LengCsharp.Text = "  C#";
            this.LengCsharp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengCsharp.UseVisualStyleBackColor = false;
            // 
            // LengHtml
            // 
            this.LengHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengHtml.FlatAppearance.BorderSize = 0;
            this.LengHtml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengHtml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengHtml.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengHtml.ForeColor = System.Drawing.Color.White;
            this.LengHtml.Location = new System.Drawing.Point(0, 234);
            this.LengHtml.Name = "LengHtml";
            this.LengHtml.Size = new System.Drawing.Size(186, 41);
            this.LengHtml.TabIndex = 6;
            this.LengHtml.Text = "  HTML";
            this.LengHtml.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengHtml.UseVisualStyleBackColor = false;
            // 
            // LengCss
            // 
            this.LengCss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengCss.FlatAppearance.BorderSize = 0;
            this.LengCss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengCss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengCss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengCss.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengCss.ForeColor = System.Drawing.Color.White;
            this.LengCss.Location = new System.Drawing.Point(0, 281);
            this.LengCss.Name = "LengCss";
            this.LengCss.Size = new System.Drawing.Size(186, 41);
            this.LengCss.TabIndex = 7;
            this.LengCss.Text = "  CSS";
            this.LengCss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengCss.UseVisualStyleBackColor = false;
            // 
            // LengJavaScript
            // 
            this.LengJavaScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengJavaScript.FlatAppearance.BorderSize = 0;
            this.LengJavaScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengJavaScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengJavaScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengJavaScript.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengJavaScript.ForeColor = System.Drawing.Color.White;
            this.LengJavaScript.Location = new System.Drawing.Point(0, 328);
            this.LengJavaScript.Name = "LengJavaScript";
            this.LengJavaScript.Size = new System.Drawing.Size(186, 41);
            this.LengJavaScript.TabIndex = 8;
            this.LengJavaScript.Text = "  Java Script";
            this.LengJavaScript.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengJavaScript.UseVisualStyleBackColor = false;
            // 
            // LengSQL
            // 
            this.LengSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengSQL.FlatAppearance.BorderSize = 0;
            this.LengSQL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengSQL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengSQL.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengSQL.ForeColor = System.Drawing.Color.White;
            this.LengSQL.Location = new System.Drawing.Point(0, 375);
            this.LengSQL.Name = "LengSQL";
            this.LengSQL.Size = new System.Drawing.Size(186, 41);
            this.LengSQL.TabIndex = 9;
            this.LengSQL.Text = "  MySQL";
            this.LengSQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengSQL.UseVisualStyleBackColor = false;
            // 
            // LengAndroid
            // 
            this.LengAndroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengAndroid.FlatAppearance.BorderSize = 0;
            this.LengAndroid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LengAndroid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.LengAndroid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LengAndroid.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengAndroid.ForeColor = System.Drawing.Color.White;
            this.LengAndroid.Location = new System.Drawing.Point(0, 422);
            this.LengAndroid.Name = "LengAndroid";
            this.LengAndroid.Size = new System.Drawing.Size(186, 41);
            this.LengAndroid.TabIndex = 10;
            this.LengAndroid.Text = "  Android";
            this.LengAndroid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LengAndroid.UseVisualStyleBackColor = false;
            // 
            // InterfazVisualBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BarraDeTitulo);
            this.Controls.Add(this.PanelContenedor);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfazVisualBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz Base";
            this.Load += new System.EventHandler(this.InterfazVisualBase_Load);
            this.BarraDeTitulo.ResumeLayout(false);
            this.Pestañas.ResumeLayout(false);
            this.GrupoArchivo.ResumeLayout(false);
            this.GrupoFormato.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.GrupoLenguajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.Panel Pestañas;
        private System.Windows.Forms.Button Archivo;
        private System.Windows.Forms.Panel PinArchivo;
        private System.Windows.Forms.Panel PinFormato;
        private System.Windows.Forms.Button Formato;
        private System.Windows.Forms.Panel GrupoArchivo;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button GuardarComo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Abrir;
        private System.Windows.Forms.Panel GrupoFormato;
        private System.Windows.Forms.Button Temas;
        private System.Windows.Forms.Button Fuente;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel PinLenguajes;
        private System.Windows.Forms.Button Lenguajes;
        private System.Windows.Forms.Panel GrupoLenguajes;
        private System.Windows.Forms.Button LengAndroid;
        private System.Windows.Forms.Button LengSQL;
        private System.Windows.Forms.Button LengJavaScript;
        private System.Windows.Forms.Button LengCss;
        private System.Windows.Forms.Button LengHtml;
        private System.Windows.Forms.Button LengCsharp;
        private System.Windows.Forms.Button LengJava;
        private System.Windows.Forms.Button LengDev;
        private System.Windows.Forms.Button LengC;
        private System.Windows.Forms.Button LengPSeint;
    }
}

