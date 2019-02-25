using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreLIB;

namespace BookStoreGUI
{
    public partial class LibHome : Form
    {
        BookOrder bookOrder;
        DALReviewItem reviewItem;
        DBQueries dbQ = new DBQueries();
        DataSet ds = new DataSet();
        public LibHome()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.LibHome_Load);
        }
        private void LibHome_Load(object sender, EventArgs e)
        {
            bookOrder = new BookOrder();
            dbQ = new DBQueries();
            ds = new DataSet();

            ds = dbQ.SELECT_FROM_TABLE("SELECT Title, Author, Price, Year FROM BookData");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables[0]; // dataset
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = 40; 
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.FillWeight = 20;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.FillWeight = 10;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.FillWeight = 10;
            this.dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            dbQ = new DBQueries();
            ds = new DataSet();

            ds = dbQ.SELECT_FROM_TABLE("SELECT Title, Author, Price, Year FROM BookData WHERE Title LIKE '%" + search_Box.Text + "%'");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables[0]; // dataset
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = 40;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.FillWeight = 20;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.FillWeight = 10;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.FillWeight = 10;
            this.dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBQueries dbQ = new DBQueries();
            DataSet ds = new DataSet();

            int selectedComboItem = comboBox1.SelectedIndex + 1;

            ds = dbQ.SELECT_FROM_TABLE("SELECT Title, Author, Price, Year FROM BookData WHERE CategoryID = '" + selectedComboItem + "'");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables[0]; // dataset
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = 40;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.FillWeight = 20;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.FillWeight = 10;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.FillWeight = 10;
            this.dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            OrderItemDialog orderItemDialog = new OrderItemDialog();

            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                dbQ = new DBQueries();
                ds = new DataSet();
                ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM BookData WHERE Title = '" +
                    dataGridView1.SelectedCells[0].Value.ToString() + "'");

                orderItemDialog.isbnTextBox.Text = ds.Tables[0].Rows[0]["ISBN"].ToString();
                orderItemDialog.titleTextBox.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                orderItemDialog.priceTextBox.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                orderItemDialog.descriptionTextBox.Text = ds.Tables[0].Rows[0]["Description"].ToString();

                //orderItemDialog.Owner = this;
                orderItemDialog.ShowDialog();
                if (orderItemDialog.DialogResult == true)
                {
                    string isbn = orderItemDialog.isbnTextBox.Text;
                    string title = orderItemDialog.titleTextBox.Text;
                    double unitPrice = double.Parse(orderItemDialog.priceTextBox.Text);
                    int quantity = int.Parse(orderItemDialog.quantityTextBox.Text);
                    string description = orderItemDialog.descriptionTextBox.Text;

                    bookOrder.AddItem(new OrderItem(isbn, title, unitPrice, quantity, description));
                }
            }
            else
            {
                MessageBox.Show("Please make sure a book is selected");
            }
        }

        private void LibHome_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksAgile6DB17DataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.booksAgile6DB17DataSet1.Category);

        }
    }
}
