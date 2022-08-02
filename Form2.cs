using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsSQLite1
{
    public partial class Form2 : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteDataReader data_reader;

        String[] arrDatosEmployeeIni;
        long[] arrReportsTo;

        public Form2()
        {
            InitializeComponent();
            sqlite_conn = CreateConnection();
            data_reader = ReadDataEmployees(sqlite_conn,"EmployeeId", 1);

            arrDatosEmployeeIni = new String[15];
            List<long> arrReportsTo = new List<long>();

            CargaDatosDeDataReader();

            CargaListadoReportsTo();

        }

        private void CargaListadoReportsTo()
        {
            SQLiteDataReader sqlite_datareaderList;
            SQLiteCommand sqlite_cmd_list;
            sqlite_cmd_list = sqlite_conn.CreateCommand();

            sqlite_cmd_list.CommandText = "SELECT *,(FirstName || ' ' || LastName) as FullName FROM employees";

            sqlite_datareaderList = sqlite_cmd_list.ExecuteReader();

            List<long> miLista = new List<long>();
            miLista.Add(0);

            lstBReportsTo.Items.Add("No");
            while (sqlite_datareaderList.Read())
            {
                lstBReportsTo.Items.Add(sqlite_datareaderList.GetString(2) + " " + sqlite_datareaderList.GetString(1));
                miLista.Add(sqlite_datareaderList.GetInt64(0));
            }
            arrReportsTo = miLista.ToArray();
        }

        private void CargaDatosDeDataReader()
        {
            if (!data_reader.HasRows)
            {
                string message = "Datos del ID "+txBuscar.Text+" no encontrados";
                string caption = "Error obteniendo datos";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                
                MessageBox.Show(message, caption, buttons);
                return;
            }

            long vIdEmployee = data_reader.GetInt64(0);
            lbIdEmployee.Text = vIdEmployee.ToString();
            arrDatosEmployeeIni[0] = lbIdEmployee.Text;

            String vApellidos = data_reader.GetString(1);
            txApellidos.Text = vApellidos;
            arrDatosEmployeeIni[1] = vApellidos;

            String vNombres = data_reader.GetString(2);
            txNombres.Text = vNombres;
            arrDatosEmployeeIni[2] = vNombres;

            String vTitle = data_reader.GetString(3);
            txTitle.Text = vTitle;
            arrDatosEmployeeIni[3] = vTitle;

            Object objReportsTo = data_reader.GetValue(4);
            if (objReportsTo is System.DBNull)
            {
                txReportsToStr.Text = "No";
                arrDatosEmployeeIni[4] = "No";
                txReportsTo.Text = "No";
                if (lstBReportsTo.SelectedIndex> 0)
                    lstBReportsTo.SelectedIndex = 0;
            }
            else
            {
                String vNombresR = data_reader.GetString(15);
                String vApellidosR = data_reader.GetString(16);
                txReportsToStr.Text = vNombresR+" "+ vApellidosR;
                txReportsTo.Text = objReportsTo.ToString();
                arrDatosEmployeeIni[4] = objReportsTo.ToString();

                int listItem = int.Parse(objReportsTo.ToString());
                lstBReportsTo.SelectedIndex = listItem;
            }

            String vBirthDate = data_reader.GetDateTime(5).ToString("yyyy-MM-dd");
            txBirthDate.Text = vBirthDate;
            arrDatosEmployeeIni[5] = vBirthDate;

            String vHireDate = data_reader.GetDateTime(6).ToString("yyyy-MM-dd");
            txHireDate.Text = vHireDate;
            arrDatosEmployeeIni[6] = vHireDate;

            String vAddress = data_reader.GetString(7);
            txAddress.Text = vAddress;
            arrDatosEmployeeIni[7] = vAddress;

            String vCity = data_reader.GetString(8);
            txCity.Text = vCity;
            arrDatosEmployeeIni[8] = vCity;

            String vState = data_reader.GetString(9);
            txState.Text = vState;
            arrDatosEmployeeIni[9] = vState;

            String vCountry = data_reader.GetString(10);
            txCountry.Text = vCountry;
            arrDatosEmployeeIni[10] = vCountry;

            String vPostalCode = data_reader.GetString(11);
            txPostalCode.Text = vPostalCode;
            arrDatosEmployeeIni[11] = vPostalCode;

            String vPhone = data_reader.GetString(12);
            txPhone.Text = vPhone;
            arrDatosEmployeeIni[12] = vPhone;

            String vFax = data_reader.GetString(13);
            txFax.Text = vFax;
            arrDatosEmployeeIni[13] = vFax;

            String vEmail = data_reader.GetString(14);
            txEmail.Text = vEmail;
            arrDatosEmployeeIni[14] = vEmail;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int64 vFieldValue = Int64.Parse(txBuscar.Text);
            data_reader = ReadDataEmployees(sqlite_conn, "EmployeeId", vFieldValue);

            CargaDatosDeDataReader();

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccio_Click(object sender, EventArgs e)
        {
            string message = "Datos del ID " + txBuscar.Text + " no encontrados";
            string caption = "Error obteniendo datos";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            String[] arrDatosEmployee = new String[15];
            arrDatosEmployee[0] = lbIdEmployee.Text;
            arrDatosEmployee[1] = txApellidos.Text;
            arrDatosEmployee[2] = txNombres.Text;
            arrDatosEmployee[3] = txTitle.Text;
            arrDatosEmployee[4] = txReportsTo.Text;
            arrDatosEmployee[5] = txBirthDate.Text;
            arrDatosEmployee[6] = txHireDate.Text;
            arrDatosEmployee[7] = txAddress.Text;
            arrDatosEmployee[8] = txCity.Text;
            arrDatosEmployee[9] = txState.Text;
            arrDatosEmployee[10] = txCountry.Text;
            arrDatosEmployee[11] = txPostalCode.Text;
            arrDatosEmployee[12] = txPhone.Text;
            arrDatosEmployee[13] = txFax.Text;
            arrDatosEmployee[14] = txEmail.Text;

            if (rbAccion1.Checked)
            {
                caption = "Actualizando Empleado";
                bool ArrValido = ValidateDataArray(arrDatosEmployee);
                bool HayCambios = ValidaHayCambios(arrDatosEmployee, arrDatosEmployeeIni);

                if (ArrValido && HayCambios)
                {
                    if (UpdateEmployee(sqlite_conn, arrDatosEmployee, arrDatosEmployeeIni))
                    {
                        message = "Empleado actualizado satisfactoriamente";
                    }
                    else
                    {
                        message = "Error, el empleado no ha sido actualizado";
                    }
                }
                else
                {
                    message = "Error validando datos, el empleado no ha sido actualizado";
                }
                MessageBox.Show(message, caption, buttons);
            }

            if (rbAccion2.Checked)
            {
                caption = "Insertando Empleado";
                if (ValidateDataArray(arrDatosEmployee))
                {
                    if (InsertEmployee(sqlite_conn, arrDatosEmployee))
                    {
                        message = "Empleado adicionado satisfactoriamente";
                    }
                    else
                    {
                        message = "Error, el empleado no ha sido adicionado";
                    }
                }
                else
                {
                    message = "Error validando datos, el empleado no ha sido adicionado";
                }
                MessageBox.Show(message, caption, buttons);
            }

            if (rbAccion3.Checked)
            {
                caption = "Borrando Empleado";

                int resultado = DeleteEmployee(sqlite_conn, Int64.Parse(lbIdEmployee.Text));
                if (resultado>0)
                {
                    message = "Empleado borrado satisfactoriamente";

                    data_reader = ReadDataEmployees(sqlite_conn, "EmployeeId", 1);
                    CargaDatosDeDataReader();
                }
                else if (resultado < 0)
                {
                    message = "Error, el empleado no se puede borrar pues alguien reporta a el. Cambie  ese dato en los correspondientes empleados";
                }
                else
                {
                    message = "Error, el empleado no ha sido borrado";
                }
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void rbAccion1_CheckedChanged(object sender, EventArgs e)
        {
            btnAccio.Text = "Actualizar";
        }

        private void rbAccion2_CheckedChanged(object sender, EventArgs e)
        {
            btnAccio.Text = "Insertar";
        }

        private void rbAccion3_CheckedChanged(object sender, EventArgs e)
        {
            btnAccio.Text = "Eliminar";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lstBReportsTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txReportsTo.Text = arrReportsTo[lstBReportsTo.SelectedIndex].ToString();
        }
    }
}
