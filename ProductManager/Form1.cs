using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class Form1 : Form
    {

        private DataAcsess db = new DataAcsess();

        public Form1()
        {
            InitializeComponent();
            listBoxProductsList.DataSource = db.GetProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFirstEfDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dbFirstEfDataSet.Product);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string infoMessage = db.AddProduct(this.tBoxName.Text, this.tBoxCount.Text);

            MessageBox.Show(infoMessage);

            // refreshToListBox();

            refresBox();

            refreshToListBox();
        }

        private void refresBox()
        {
            listBoxProductsList.DataSource = db.GetProducts();

            //  listBoxProductsList.Refresh();
        }
        //tst
        private void refreshToListBox()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-SDM5MI2; Initial Catalog=DbFirstEf; Integrated Security=true;");

            try
            {
                sqlCon.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            string sqlSelectAll = "SELECT * from Product";
            SqlDataAdapter sqlAdp = new SqlDataAdapter(sqlSelectAll, sqlCon);

            DataTable table = new DataTable();

            try
            {
                sqlAdp.Fill(table);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            this.dataGridViewProducts.DataSource = bSource;

            sqlCon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = db.FindProduct(Convert.ToInt32(tBoxId.Text));

            db.DeleteProduct(product);

            refresBox();

            refreshToListBox();
        }

        private void DataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtCount.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnDeleteSelectedData_Click(object sender, EventArgs e)
        {
        
            int id = Convert.ToInt32(txtId.Text);
            Product product = db.FindProduct(id);
            db.DeleteProduct(product);

            refresBox();

            refreshToListBox();
        }
    }
}