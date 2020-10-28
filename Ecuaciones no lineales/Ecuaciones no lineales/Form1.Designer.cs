namespace Ecuaciones_no_lineales
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.Panel_Titulo_Principal = new System.Windows.Forms.Panel();
            this.PictureBox_Minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox_Salir = new System.Windows.Forms.PictureBox();
            this.Lbl_Titulo_Principal = new System.Windows.Forms.Label();
            this._Principal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Metodo_de_la_Secante = new System.Windows.Forms.Button();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.Panel_Titulo_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Salir)).BeginInit();
            this._Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Titulo_Principal
            // 
            this.Panel_Titulo_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Panel_Titulo_Principal.Controls.Add(this.PictureBox_Minimizar);
            this.Panel_Titulo_Principal.Controls.Add(this.pictureBox_Salir);
            this.Panel_Titulo_Principal.Controls.Add(this.Lbl_Titulo_Principal);
            this.Panel_Titulo_Principal.Location = new System.Drawing.Point(1, 2);
            this.Panel_Titulo_Principal.Name = "Panel_Titulo_Principal";
            this.Panel_Titulo_Principal.Size = new System.Drawing.Size(1515, 55);
            this.Panel_Titulo_Principal.TabIndex = 0;
            this.Panel_Titulo_Principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Titulo_Principal_MouseDown);
            // 
            // PictureBox_Minimizar
            // 
            this.PictureBox_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Minimizar.Image")));
            this.PictureBox_Minimizar.Location = new System.Drawing.Point(1396, 21);
            this.PictureBox_Minimizar.Name = "PictureBox_Minimizar";
            this.PictureBox_Minimizar.Size = new System.Drawing.Size(60, 31);
            this.PictureBox_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Minimizar.TabIndex = 2;
            this.PictureBox_Minimizar.TabStop = false;
            this.PictureBox_Minimizar.Click += new System.EventHandler(this.PictureBox_Minimizar_Click);
            // 
            // pictureBox_Salir
            // 
            this.pictureBox_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Salir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Salir.Image")));
            this.pictureBox_Salir.Location = new System.Drawing.Point(1462, 5);
            this.pictureBox_Salir.Name = "pictureBox_Salir";
            this.pictureBox_Salir.Size = new System.Drawing.Size(53, 47);
            this.pictureBox_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Salir.TabIndex = 1;
            this.pictureBox_Salir.TabStop = false;
            this.pictureBox_Salir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lbl_Titulo_Principal
            // 
            this.Lbl_Titulo_Principal.AutoSize = true;
            this.Lbl_Titulo_Principal.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo_Principal.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo_Principal.Location = new System.Drawing.Point(507, 5);
            this.Lbl_Titulo_Principal.Name = "Lbl_Titulo_Principal";
            this.Lbl_Titulo_Principal.Size = new System.Drawing.Size(703, 45);
            this.Lbl_Titulo_Principal.TabIndex = 0;
            this.Lbl_Titulo_Principal.Text = "Calculadora de Ecuaciones no lineales ";
            this.Lbl_Titulo_Principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Titulo_Principal_MouseDown);
            // 
            // _Principal
            // 
            this._Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this._Principal.Controls.Add(this.button1);
            this._Principal.Controls.Add(this.Btn_Metodo_de_la_Secante);
            this._Principal.Location = new System.Drawing.Point(1, 55);
            this._Principal.Name = "_Principal";
            this._Principal.Size = new System.Drawing.Size(1515, 40);
            this._Principal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pagina de inicio";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_Metodo_de_la_Secante
            // 
            this.Btn_Metodo_de_la_Secante.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Metodo_de_la_Secante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Metodo_de_la_Secante.FlatAppearance.BorderSize = 0;
            this.Btn_Metodo_de_la_Secante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Metodo_de_la_Secante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Metodo_de_la_Secante.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Metodo_de_la_Secante.ForeColor = System.Drawing.Color.White;
            this.Btn_Metodo_de_la_Secante.Location = new System.Drawing.Point(243, 0);
            this.Btn_Metodo_de_la_Secante.Name = "Btn_Metodo_de_la_Secante";
            this.Btn_Metodo_de_la_Secante.Size = new System.Drawing.Size(237, 40);
            this.Btn_Metodo_de_la_Secante.TabIndex = 1;
            this.Btn_Metodo_de_la_Secante.Text = "Metodo de la Secante";
            this.Btn_Metodo_de_la_Secante.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Metodo_de_la_Secante.UseVisualStyleBackColor = false;
            this.Btn_Metodo_de_la_Secante.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.Location = new System.Drawing.Point(1, 98);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(1515, 810);
            this.Panel_Contenedor.TabIndex = 2;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1516, 908);
            this.Controls.Add(this.Panel_Contenedor);
            this.Controls.Add(this._Principal);
            this.Controls.Add(this.Panel_Titulo_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.Panel_Titulo_Principal.ResumeLayout(false);
            this.Panel_Titulo_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Salir)).EndInit();
            this._Principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Titulo_Principal;
        private System.Windows.Forms.Label Lbl_Titulo_Principal;
        private System.Windows.Forms.Panel _Principal;
        private System.Windows.Forms.PictureBox pictureBox_Salir;
        private System.Windows.Forms.PictureBox PictureBox_Minimizar;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.Button Btn_Metodo_de_la_Secante;
        private System.Windows.Forms.Button button1;
    }
}

