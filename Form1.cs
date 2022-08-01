namespace WinFormsSQLite1
{

//    using System.Data.SQLite;

    public partial class Form1 : Form
    {
//       SQLiteConnection sqlite_conn;

       public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnLoadDataDb_Click(object sender, EventArgs e)
        {
        }

        private void btnPopulateDb_Click(object sender, EventArgs e)
        {
        }

        private void btnAccionesCRUD_Click(object sender, EventArgs e)
        {
//            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResumeInvoices_Click(object sender, EventArgs e)
        {
//            this.Hide();
            Form3 frm = new Form3();
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}