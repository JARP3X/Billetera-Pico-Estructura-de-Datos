namespace BilleteraPico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.iconoMaximizar = new System.Windows.Forms.PictureBox();
            this.iconoRestaurar = new System.Windows.Forms.PictureBox();
            this.iconoMinimizar = new System.Windows.Forms.PictureBox();
            this.RegistrarEncolar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.RegistrarEncolar);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(333, 648);
            this.MenuVertical.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.iconoMinimizar);
            this.BarraTitulo.Controls.Add(this.iconoRestaurar);
            this.BarraTitulo.Controls.Add(this.iconoMaximizar);
            this.BarraTitulo.Controls.Add(this.iconoCerrar);
            this.BarraTitulo.Controls.Add(this.btnslide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(333, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(773, 61);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(333, 61);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(773, 587);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(6, 12);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(47, 43);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            this.iconoCerrar.Location = new System.Drawing.Point(741, 12);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrar.TabIndex = 1;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // iconoMaximizar
            // 
            this.iconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMaximizar.Image")));
            this.iconoMaximizar.Location = new System.Drawing.Point(706, 12);
            this.iconoMaximizar.Name = "iconoMaximizar";
            this.iconoMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMaximizar.TabIndex = 2;
            this.iconoMaximizar.TabStop = false;
            this.iconoMaximizar.Click += new System.EventHandler(this.iconoMaximizar_Click);
            // 
            // iconoRestaurar
            // 
            this.iconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconoRestaurar.Image")));
            this.iconoRestaurar.Location = new System.Drawing.Point(706, 12);
            this.iconoRestaurar.Name = "iconoRestaurar";
            this.iconoRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoRestaurar.TabIndex = 3;
            this.iconoRestaurar.TabStop = false;
            this.iconoRestaurar.Visible = false;
            this.iconoRestaurar.Click += new System.EventHandler(this.iconoRestaurar_Click);
            // 
            // iconoMinimizar
            // 
            this.iconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMinimizar.Image")));
            this.iconoMinimizar.Location = new System.Drawing.Point(671, 12);
            this.iconoMinimizar.Name = "iconoMinimizar";
            this.iconoMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMinimizar.TabIndex = 4;
            this.iconoMinimizar.TabStop = false;
            this.iconoMinimizar.Click += new System.EventHandler(this.iconoMinimizar_Click);
            // 
            // RegistrarEncolar
            // 
            this.RegistrarEncolar.FlatAppearance.BorderSize = 0;
            this.RegistrarEncolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarEncolar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarEncolar.ForeColor = System.Drawing.SystemColors.Menu;
            this.RegistrarEncolar.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarEncolar.Image")));
            this.RegistrarEncolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrarEncolar.Location = new System.Drawing.Point(0, 180);
            this.RegistrarEncolar.Name = "RegistrarEncolar";
            this.RegistrarEncolar.Size = new System.Drawing.Size(333, 50);
            this.RegistrarEncolar.TabIndex = 1;
            this.RegistrarEncolar.Text = "Registrar y Encolar";
            this.RegistrarEncolar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Menu;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(333, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reversar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Menu;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(333, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Historial";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 648);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconoMinimizar;
        private System.Windows.Forms.PictureBox iconoRestaurar;
        private System.Windows.Forms.PictureBox iconoMaximizar;
        private System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.Button RegistrarEncolar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

