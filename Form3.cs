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
    public partial class Form3 : Form
    {
        SQLiteConnection sqlite_conn;

        public Form3()
        {
            InitializeComponent();
            sqlite_conn = CreateConnection();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargaResumenInvoices();
        }

        private void CargaResumenInvoices()
        {
            SQLiteCommand sqlite_cmd_list;
            sqlite_cmd_list = sqlite_conn.CreateCommand();

            string SelectGroupQuery = "";

            SelectGroupQuery = "Select ";    //   printf('%.2f', floatField)
            SelectGroupQuery += "    IVT.CustomerId as 'ID Cliente', printf('%.2f',sum(IVT.total)) as 'Suma Total', printf('%.2f',avg(IVT.total)) as 'Prom x Fact',count(IVT.CustomerId) as 'Total Fact',  ";
            SelectGroupQuery += "    sum(IVS.m1) as 'Fact Ene',sum(IVS.m2) as 'Fact Feb',sum(IVS.m3) as 'Fact Mar',sum(IVS.m4) as 'Fact Abr',";
            SelectGroupQuery += "    sum(IVS.m5) as 'Fact May',sum(IVS.m6) as 'Fact Jun', sum(IVS.m7) as 'Fact Jul',sum(IVS.m8) as 'Fact Ago',";
            SelectGroupQuery += "    sum(IVS.m9) as 'Fact Sep',sum(IVS.m10) as 'Fact Oct',sum(IVS.m11) as 'Fact Nov',sum(IVS.m12) as 'Fact Dic' ";
            SelectGroupQuery += " from ";
            SelectGroupQuery += "    invoices IVT JOIN";
            SelectGroupQuery += " (select ";
            SelectGroupQuery += "    CustomerId,";
            SelectGroupQuery += "    InvoiceId,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='01', 1, 0) as m1,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='02', 1, 0) as m2,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='03', 1, 0) as m3,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='04', 1, 0) as m4,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='05', 1, 0) as m5,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='06', 1, 0) as m6,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='07', 1, 0) as m7,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='08', 1, 0) as m8,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='09', 1, 0) as m9,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='10', 1, 0) as m10,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='11', 1, 0) as m11,";
            SelectGroupQuery += "    IIF(strftime('%m',InvoiceDate)='12', 1, 0) as m12";
            SelectGroupQuery += " from invoices) IVS on IVT.InvoiceId = IVS.InvoiceId";
            SelectGroupQuery += " group by IVT.CustomerId";

            sqlite_cmd_list.CommandText = SelectGroupQuery;

            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd_list);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridInvoices.ReadOnly = true;
            dataGridInvoices.DataSource = dt;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
