using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BookStoreLIB;
using System.Data;
using System.Data.SqlClient;

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for ReviewList.xaml
    /// </summary>
    public partial class ReviewList : Window
    {
        DataTable dsReviews;

        public string Isbn;
        public int UserID;
        public String Title;

        public ReviewList(String isbn, String title, int userID)
        {
            InitializeComponent();
            Isbn = isbn;
            UserID = userID;
            Title = title;
            //MessageBox.Show("The logged in user ID is "+UserID);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DALGetUserReviews review = new DALGetUserReviews();
            dsReviews = review.GetUserReviews(Isbn);
            if (dsReviews != null)
            {
                ReviewsDataGrid.DataContext = dsReviews.DefaultView;
                
            }
            else MessageBox.Show("Query Failed");

           
        }

        private void addReviewButton_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new ReviewItem(Isbn);
            DALReviewItem reviewItem = new DALReviewItem();

            dlg.isbnTextBox.Text = Isbn;
            dlg.titleTextBox.Text = Title;
            //dlg.Owner = this;


            DBQueries dbQ = new DBQueries();
            DataSet ds = new DataSet();

            String s1 = "select t1.OrderID, t1.UserID from Orders " +
                "t1 INNER JOIN OrderItem t2 ON t1.OrderID = t2.OrderID Where t2.ISBN = '" + Isbn + "' And t1.UserID = '" + UserID + "'";


            // ds = dbQ.SELECT_FROM_TABLE("SELECT * FROM BookData WHERE Title = '" +
            //   dataGridView1.SelectedCells[0].Value.ToString() + "'");
            ds = dbQ.SELECT_FROM_TABLE(s1);

            if (ds.Tables[0].Rows.Count > 0)
            {

                var orderID = ds.Tables[0].Rows[0]["OrderID"].ToString();
                //MessageBox.Show("fetched orderID is" + orderID);
                //var title = ds.Tables[0].Rows[0]["Title"].ToString();
                dlg.orderNoTextBox.Text = orderID;

                dlg.ShowDialog();
                if (dlg.DialogResult == true)
                {



                    if (reviewItem.Review(Isbn, int.Parse(orderID), int.Parse(dlg.ratingsbutton.Text), dlg.commentsTextBox.Text))
                    {
                        MessageBox.Show("Your Review Has been submitted.");

                    }
                    else
                    {
                        MessageBox.Show("Your Review Could not be added");
                    }

                }
            }
            else
            {
                MessageBox.Show("You need to purchase a book to be able to review it.");
            }
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void viewReviewButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
