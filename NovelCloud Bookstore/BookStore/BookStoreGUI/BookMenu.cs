using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreLIB;
using System.Collections.ObjectModel;

namespace BookStoreGUI
{
    public partial class Library : Form
    {
        BookOrder bookOrder;
        DALReviewItem reviewItem;
        DBQueries dbQ = new DBQueries();
        DataSet ds = new DataSet();
        int UserID;
        public Library(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void BookMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksAgile6DB17DataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.booksAgile6DB17DataSet1.Category);
            bookOrder = new BookOrder();
            dbQ = new DBQueries();
            ds = new DataSet();

            ds = dbQ.SELECT_FROM_TABLE("SELECT Title, Author, Price, Year FROM BookData");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables[0]; // dataset
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 800;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 357;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 150;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 150;
            this.dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dbQ = new DBQueries();
            ds = new DataSet();

            ds = dbQ.SELECT_FROM_TABLE("SELECT Title, Author, Price, Year FROM BookData WHERE Title LIKE '" + textBox1.Text + "%'");
            dataGridView1.AutoGenerateColumns = true;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 800;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 357;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 170;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 173;
            this.dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void addBook_Button_Click(object sender, EventArgs e)
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

        private void checkout_Button_Click(object sender, EventArgs e)
        {
            CheckoutCart chkC = new CheckoutCart();
            chkC.setOrderBooks(bookOrder.OrderItemList);
            chkC.ShowDialog();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBQueries dbQ = new DBQueries();
            DataSet ds = new DataSet();

            int selectedComboItem = comboBox1.SelectedIndex + 1;

            ds = dbQ.SELECT_FROM_TABLE("SELECT Title, Author, Price, Year FROM BookData WHERE CategoryID = '" + selectedComboItem + "'");
            dataGridView1.AutoGenerateColumns = true;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 800;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 357;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 170;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 173;
            this.dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {
            addBook_Button_Click(sender, e);
        }



        private void leave_Review_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                dbQ = new DBQueries();
                ds = new DataSet();

                ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM BookData WHERE Title = '" +
                    dataGridView1.SelectedCells[0].Value.ToString() + "'");

                var isbn = ds.Tables[0].Rows[0]["ISBN"].ToString();
                var title = ds.Tables[0].Rows[0]["Title"].ToString();

                var dlg = new ReviewList(isbn,title,UserID);
                dlg.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please add a book to review it.");
            }
        }
    }
}
