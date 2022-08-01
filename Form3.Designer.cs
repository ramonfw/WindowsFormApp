namespace WinFormsSQLite1
{
    using System.Data.SQLite;

    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private const string ConnectionString = "..\\..\\..\\..\\DatabasesSQLite\\Data Source=chinook.db; Version = 3; New = True; Compress = True; ";

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
            this.dataGridInvoices = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInvoices
            // 
            this.dataGridInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInvoices.Location = new System.Drawing.Point(25, 37);
            this.dataGridInvoices.Name = "dataGridInvoices";
            this.dataGridInvoices.RowHeadersWidth = 51;
            this.dataGridInvoices.RowTemplate.Height = 29;
            this.dataGridInvoices.Size = new System.Drawing.Size(1028, 358);
            this.dataGridInvoices.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(123, 430);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(362, 31);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar a formulario principal";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Location = new System.Drawing.Point(633, 428);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(267, 38);
            this.btnCloseApp.TabIndex = 2;
            this.btnCloseApp.Text = "Cerrar aplicacion";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 478);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridInvoices);
            this.Name = "Form3";
            this.Text = "RESUMEN DE FACTURAS POR CLIENTE";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection(Form1.ConnectionString);
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        private DataGridView dataGridInvoices;
        private Button btnRegresar;
        private Button btnCloseApp;
    }
}