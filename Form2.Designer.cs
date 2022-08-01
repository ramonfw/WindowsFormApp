namespace WinFormsSQLite1
{

    using System.Data.SQLite;

    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdEmployee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txTotalEmployeers = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rbAccion2 = new System.Windows.Forms.RadioButton();
            this.rbAccion3 = new System.Windows.Forms.RadioButton();
            this.rbAccion1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBReportsTo = new System.Windows.Forms.ComboBox();
            this.txReportsTo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txPostalCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txFax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txHireDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txBirthDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txReportsToStr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txApellidos = new System.Windows.Forms.TextBox();
            this.lbAccionAplicar = new System.Windows.Forms.Label();
            this.btnAccio = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbIdEmployee
            // 
            this.lbIdEmployee.AutoSize = true;
            this.lbIdEmployee.Location = new System.Drawing.Point(151, 17);
            this.lbIdEmployee.Name = "lbIdEmployee";
            this.lbIdEmployee.Size = new System.Drawing.Size(101, 20);
            this.lbIdEmployee.TabIndex = 1;
            this.lbIdEmployee.Text = "lbIdEmployee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar por Id de empleado";
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(630, 15);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(77, 27);
            this.txBuscar.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txTotalEmployeers);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.rbAccion2);
            this.groupBox1.Controls.Add(this.rbAccion3);
            this.groupBox1.Controls.Add(this.rbAccion1);
            this.groupBox1.Location = new System.Drawing.Point(51, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // txTotalEmployeers
            // 
            this.txTotalEmployeers.Location = new System.Drawing.Point(610, 27);
            this.txTotalEmployeers.Name = "txTotalEmployeers";
            this.txTotalEmployeers.Size = new System.Drawing.Size(66, 27);
            this.txTotalEmployeers.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(484, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Total Empleados";
            // 
            // rbAccion2
            // 
            this.rbAccion2.AutoSize = true;
            this.rbAccion2.Location = new System.Drawing.Point(142, 26);
            this.rbAccion2.Name = "rbAccion2";
            this.rbAccion2.Size = new System.Drawing.Size(79, 24);
            this.rbAccion2.TabIndex = 4;
            this.rbAccion2.Text = "Insertar";
            this.rbAccion2.UseVisualStyleBackColor = true;
            this.rbAccion2.CheckedChanged += new System.EventHandler(this.rbAccion2_CheckedChanged);
            // 
            // rbAccion3
            // 
            this.rbAccion3.AutoSize = true;
            this.rbAccion3.Location = new System.Drawing.Point(242, 26);
            this.rbAccion3.Name = "rbAccion3";
            this.rbAccion3.Size = new System.Drawing.Size(84, 24);
            this.rbAccion3.TabIndex = 3;
            this.rbAccion3.Text = "Eliminar";
            this.rbAccion3.UseVisualStyleBackColor = true;
            this.rbAccion3.CheckedChanged += new System.EventHandler(this.rbAccion3_CheckedChanged);
            // 
            // rbAccion1
            // 
            this.rbAccion1.AutoSize = true;
            this.rbAccion1.Checked = true;
            this.rbAccion1.Location = new System.Drawing.Point(21, 28);
            this.rbAccion1.Name = "rbAccion1";
            this.rbAccion1.Size = new System.Drawing.Size(96, 24);
            this.rbAccion1.TabIndex = 2;
            this.rbAccion1.TabStop = true;
            this.rbAccion1.Text = "Actualizar";
            this.rbAccion1.UseVisualStyleBackColor = true;
            this.rbAccion1.CheckedChanged += new System.EventHandler(this.rbAccion1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBReportsTo);
            this.groupBox2.Controls.Add(this.txReportsTo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txPhone);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txPostalCode);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txEmail);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txFax);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txCountry);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txState);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txCity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txHireDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txBirthDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txTitle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txReportsToStr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txNombres);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txApellidos);
            this.groupBox2.Location = new System.Drawing.Point(51, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 362);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lstBReportsTo
            // 
            this.lstBReportsTo.FormattingEnabled = true;
            this.lstBReportsTo.Location = new System.Drawing.Point(448, 61);
            this.lstBReportsTo.Name = "lstBReportsTo";
            this.lstBReportsTo.Size = new System.Drawing.Size(235, 28);
            this.lstBReportsTo.TabIndex = 31;
            // 
            // txReportsTo
            // 
            this.txReportsTo.Location = new System.Drawing.Point(630, 23);
            this.txReportsTo.Name = "txReportsTo";
            this.txReportsTo.Size = new System.Drawing.Size(46, 27);
            this.txReportsTo.TabIndex = 28;
            this.txReportsTo.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Telefono";
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(22, 313);
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(118, 27);
            this.txPhone.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Código Postal";
            // 
            // txPostalCode
            // 
            this.txPostalCode.Location = new System.Drawing.Point(162, 254);
            this.txPostalCode.Name = "txPostalCode";
            this.txPostalCode.Size = new System.Drawing.Size(103, 27);
            this.txPostalCode.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Email";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(296, 313);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(226, 27);
            this.txEmail.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Fax";
            // 
            // txFax
            // 
            this.txFax.Location = new System.Drawing.Point(162, 313);
            this.txFax.Name = "txFax";
            this.txFax.Size = new System.Drawing.Size(113, 27);
            this.txFax.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Pais";
            // 
            // txCountry
            // 
            this.txCountry.Location = new System.Drawing.Point(22, 254);
            this.txCountry.Name = "txCountry";
            this.txCountry.Size = new System.Drawing.Size(118, 27);
            this.txCountry.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estado";
            // 
            // txState
            // 
            this.txState.Location = new System.Drawing.Point(565, 185);
            this.txState.Name = "txState";
            this.txState.Size = new System.Drawing.Size(111, 27);
            this.txState.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ciudad";
            // 
            // txCity
            // 
            this.txCity.Location = new System.Drawing.Point(435, 185);
            this.txCity.Name = "txCity";
            this.txCity.Size = new System.Drawing.Size(113, 27);
            this.txCity.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Direccion";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(22, 185);
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(399, 27);
            this.txAddress.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Contrato";
            // 
            // txHireDate
            // 
            this.txHireDate.Location = new System.Drawing.Point(567, 120);
            this.txHireDate.Name = "txHireDate";
            this.txHireDate.Size = new System.Drawing.Size(109, 27);
            this.txHireDate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha Nac";
            // 
            // txBirthDate
            // 
            this.txBirthDate.Location = new System.Drawing.Point(435, 120);
            this.txBirthDate.Name = "txBirthDate";
            this.txBirthDate.Size = new System.Drawing.Size(113, 27);
            this.txBirthDate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Titulo";
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(22, 120);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(399, 27);
            this.txTitle.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reporta a";
            // 
            // txReportsToStr
            // 
            this.txReportsToStr.Location = new System.Drawing.Point(438, 240);
            this.txReportsToStr.Name = "txReportsToStr";
            this.txReportsToStr.Size = new System.Drawing.Size(238, 27);
            this.txReportsToStr.TabIndex = 4;
            this.txReportsToStr.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombres";
            // 
            // txNombres
            // 
            this.txNombres.Location = new System.Drawing.Point(231, 57);
            this.txNombres.Name = "txNombres";
            this.txNombres.Size = new System.Drawing.Size(190, 27);
            this.txNombres.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos";
            // 
            // txApellidos
            // 
            this.txApellidos.Location = new System.Drawing.Point(24, 57);
            this.txApellidos.Name = "txApellidos";
            this.txApellidos.Size = new System.Drawing.Size(190, 27);
            this.txApellidos.TabIndex = 0;
            this.txApellidos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbAccionAplicar
            // 
            this.lbAccionAplicar.AutoSize = true;
            this.lbAccionAplicar.Location = new System.Drawing.Point(51, 498);
            this.lbAccionAplicar.Name = "lbAccionAplicar";
            this.lbAccionAplicar.Size = new System.Drawing.Size(115, 20);
            this.lbAccionAplicar.TabIndex = 6;
            this.lbAccionAplicar.Text = "Acción a aplicar";
            // 
            // btnAccio
            // 
            this.btnAccio.Location = new System.Drawing.Point(172, 495);
            this.btnAccio.Name = "btnAccio";
            this.btnAccio.Size = new System.Drawing.Size(116, 27);
            this.btnAccio.TabIndex = 7;
            this.btnAccio.Text = "Actualizar";
            this.btnAccio.UseVisualStyleBackColor = true;
            this.btnAccio.Click += new System.EventHandler(this.btnAccio_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(125, 550);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(268, 25);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar a Formulario principal";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(720, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Location = new System.Drawing.Point(448, 549);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(208, 25);
            this.btnCloseApp.TabIndex = 10;
            this.btnCloseApp.Text = "Cerrar Aplicación";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WinFormsSQLite1.Form1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAccio);
            this.Controls.Add(this.lbAccionAplicar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbIdEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "OPERACIONES [CRUD] SOBRE TABLA EMPLOYEES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
//            sqlite_conn = new SQLiteConnection("Data Source=chinook.db; Version = 3; New = True; Compress = True; ");
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

        static bool ValidateDataArray(String[] pArrDatosEmployee)
        {
            int vNoValido = 0;
            for (int i=0; i< pArrDatosEmployee.Length; i++)
            {
                if (pArrDatosEmployee[i].Trim() == "")
                    vNoValido++;
            }

            return vNoValido == 0;
        }

        static bool ValidaHayCambios(String[] pArrDatosEmployee, String[] pArrDatosEmployeeIni)
        {
            int vCambio = 0;
            for (int i = 0; i < pArrDatosEmployee.Length; i++)
            {
                if (pArrDatosEmployee[i].Trim() != pArrDatosEmployeeIni[i].Trim())
                    vCambio++;
            }

            return vCambio > 0;
        }

        static bool UpdateEmployee(SQLiteConnection conn, String[] pArrDatosEmployee, String[] pArrDatosEmployeeIni)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "UPDATE employees SET ";

            String[] ArrCampos = { "EmployeeId", "LastName", "FirstName", "Title", "ReportsTo", "BirthDate", "HireDate", "Address", "City", "State", "Country", "PostalCode", "Phone", "Fax", "Email" };
            string Cadena = "";
            string Datos = "";
            for (int i=1; i<ArrCampos.Length;i++)
            {
                if (pArrDatosEmployee[i] != pArrDatosEmployeeIni[i])
                {
                    Datos += ArrCampos[i] + ":" + pArrDatosEmployee[i] + "," + pArrDatosEmployeeIni[i] + "][";
                    if (Cadena != "")
                        Cadena += ", ";
                    Cadena += ArrCampos[i] + "= ?";
                    sqlite_cmd.Parameters.AddWithValue(ArrCampos[i], pArrDatosEmployee[i]);
                }
            }

            sqlite_cmd.CommandText += Cadena + " WHERE EmployeeId = ?";
            sqlite_cmd.Parameters.AddWithValue("EmployeeId", pArrDatosEmployee[0]);

            if (Cadena != "")
            {
                sqlite_cmd.ExecuteNonQuery();
                return true;
            }
            else
                return false;
        }

        static bool InsertEmployee(SQLiteConnection conn, String[] pArrDatosEmployee)
        {
            SQLiteCommand sqlite_cmd;
            String[] ArrCampos = { "EmployeeId", "LastName", "FirstName", "Title", "ReportsTo", "BirthDate", "HireDate", "Address", "City", "State", "Country", "PostalCode", "Phone", "Fax", "Email" };

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO employees ";
            String Columnas = "(LastName,FirstName,Title,ReportsTo,BirthDate,HireDate,Address, " +
                "City, State, Country,PostalCode,Phone,Fax,Email)";
            String Valores = "(?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

            sqlite_cmd.CommandText += Columnas + " VALUES " + Valores;

            for (int i = 1; i < ArrCampos.Length; i++)
            {
                sqlite_cmd.Parameters.AddWithValue(ArrCampos[i], pArrDatosEmployee[i]);
            }

            sqlite_cmd.ExecuteNonQuery();

            return true;
        }


        static void InsertDataEmployees(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO employees (Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        static bool DeleteEmployee(SQLiteConnection conn, Int64 pEmployeeId)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM employees where EmployeeId = ?";

            sqlite_cmd.Parameters.AddWithValue("EmployeeId", pEmployeeId);
            sqlite_cmd.ExecuteNonQuery();

            return true;
        }

        static SQLiteDataReader ReadDataEmployees(SQLiteConnection conn, String FieldName, Int64 FieldValue)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            // Creamos la consulta SELECT
            sqlite_cmd.CommandText = "SELECT E1.*, E2.FirstName, E2.LastName FROM employees E1 left join employees E2 on E1.ReportsTo = E2.EmployeeId where E1." + FieldName + " = ?" ;

            // Añadimos el parámetro E1.FieldName
            sqlite_cmd.Parameters.AddWithValue("E1." + FieldName, FieldValue.ToString());

            // Ejecutamos la sentencia SELECT
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            sqlite_datareader.Read();

            return sqlite_datareader;
        }

        private Label label1;
        private Label lbIdEmployee;
        private Label label4;
        private TextBox txBuscar;
        private GroupBox groupBox1;
        private RadioButton rbAccion2;
        private RadioButton rbAccion3;
        private RadioButton rbAccion1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txApellidos;
        private Label label6;
        private TextBox txReportsToStr;
        private Label label5;
        private TextBox txNombres;
        private Label lbAccionAplicar;
        private Button btnAccio;
        private Button btnRegresar;
        private Label label2;
        private TextBox txHireDate;
        private Label label7;
        private TextBox txBirthDate;
        private Label label8;
        private TextBox txTitle;
        private Label label16;
        private TextBox txPhone;
        private Label label15;
        private TextBox txPostalCode;
        private Label label12;
        private TextBox txEmail;
        private Label label13;
        private TextBox txFax;
        private Label label14;
        private TextBox txCountry;
        private Label label9;
        private TextBox txState;
        private Label label10;
        private TextBox txCity;
        private Label label11;
        private TextBox txAddress;
        private Button btnBuscar;
        private TextBox txTotalEmployeers;
        private Label label17;
        private Button btnCloseApp;
        private TextBox txReportsTo;
        private BindingSource bindingSource1;
        private ComboBox lstBReportsTo;
    }
}