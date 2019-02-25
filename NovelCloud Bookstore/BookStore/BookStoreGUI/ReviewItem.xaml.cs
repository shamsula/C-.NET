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

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ReviewItem : Window
    {
        public string Isbn { get; }

        public ReviewItem(string isbn)
        {
            InitializeComponent();
            Isbn = isbn;
        }
        private void addReviewButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void ReviewListButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("isbn is"+Isbn);
            //ReviewList reviewList = new ReviewList(Isbn);
            //reviewList.ShowDialog();
            this.DialogResult = false;
            
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

    }
}
