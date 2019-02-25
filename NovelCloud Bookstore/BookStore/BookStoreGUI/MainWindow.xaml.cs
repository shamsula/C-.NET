/* **********************************************************************************
 * For use by students taking 60-422 (Fall, 2014) to work on assignments and project.
 * Permission required material. Contact: xyuan@uwindsor.ca 
 * **********************************************************************************/
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
using System.Data;
using BookStoreLIB;
using System.Collections.ObjectModel;

namespace BookStoreGUI
{
    /// Interaction logic for MainWindow.xaml
    public partial class MainWindow : Window
    {
        DataSet dsBookCat;
        UserData userData;
        BookOrder bookOrder;
        DALReviewItem reviewItem;
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginDialog dlg = new LoginDialog();
            dlg.Owner = this;
            dlg.ShowDialog();
            // Process data entered by user if dialog box is accepted
            if (dlg.DialogResult == true)
            {
                if (userData.LogIn(dlg.nameTextBox.Text, dlg.passwordTextBox.Password) == true)
                    this.statusTextBlock.Text = "You are logged in as User #" +
                    userData.UserID + ".";
                else
                    this.statusTextBlock.Text = "Your login failed. Please try again.";
            }
        }
        private void exitButton_Click(object sender, RoutedEventArgs e) { this.Close(); }
        public MainWindow() { InitializeComponent(); }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookCatalog bookCat = new BookCatalog();
            dsBookCat = bookCat.GetBookInfo();
            //this.DataContext = dsBookCat.Tables["Category"];
            bookOrder = new BookOrder();
            userData = new UserData();
           // this.orderListView.ItemsSource = bookOrder.OrderItemList;
        }
        private void books_Library_Button_Click(object sender, RoutedEventArgs e)
        {
                Library bm = new Library(userData.UserID);
                bm.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LibHome lh = new LibHome();
            lh.ShowDialog();
        }
    }
}
