namespace WinFormsSQLite1
{

    partial class Form1
    {
        public const string ConnectionString = "DataSource=..\\..\\..\\chinook.db; Version = 3; New = True; Compress = True;";
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAccionesCRUD = new System.Windows.Forms.Button();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.btnResumeInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccionesCRUD
            // 
            this.btnAccionesCRUD.Location = new System.Drawing.Point(32, 29);
            this.btnAccionesCRUD.Name = "btnAccionesCRUD";
            this.btnAccionesCRUD.Size = new System.Drawing.Size(296, 42);
            this.btnAccionesCRUD.TabIndex = 5;
            this.btnAccionesCRUD.Text = "Acciones CRUD sobre tabla Employees";
            this.btnAccionesCRUD.UseVisualStyleBackColor = true;
            this.btnAccionesCRUD.Click += new System.EventHandler(this.btnAccionesCRUD_Click);
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(571, 383);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(209, 47);
            this.btnCerrarAplicacion.TabIndex = 6;
            this.btnCerrarAplicacion.Text = "Cerrar Aplicación";
            this.btnCerrarAplicacion.UseVisualStyleBackColor = true;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            // 
            // btnResumeInvoices
            // 
            this.btnResumeInvoices.Location = new System.Drawing.Point(32, 96);
            this.btnResumeInvoices.Name = "btnResumeInvoices";
            this.btnResumeInvoices.Size = new System.Drawing.Size(297, 44);
            this.btnResumeInvoices.TabIndex = 7;
            this.btnResumeInvoices.Text = "Resumenes de facturas por Clientes";
            this.btnResumeInvoices.UseVisualStyleBackColor = true;
            this.btnResumeInvoices.Click += new System.EventHandler(this.btnResumeInvoices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResumeInvoices);
            this.Controls.Add(this.btnCerrarAplicacion);
            this.Controls.Add(this.btnAccionesCRUD);
            this.Name = "Form1";
            this.Text = "PRUEBA TECNICA C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAccionesCRUD;
        private Button btnCerrarAplicacion;
        private Button btnResumeInvoices;
    }
}

