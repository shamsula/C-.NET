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
using System.Collections.ObjectModel;

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for CheckoutCart.xaml
    /// </summary>
    public partial class CheckoutCart : Window
    {
        ObservableCollection<OrderItem> orderBooksList;
        public CheckoutCart()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(CheckoutCart_Loaded);
        }

        private void CheckoutCart_Loaded(object sender, EventArgs e)
        {
            this.orderView.ItemsSource = getBooksInfo();
        }

        public void setOrderBooks(ObservableCollection<OrderItem> orderItemList) 
        {
            this.orderBooksList = orderItemList;
        }

        private ObservableCollection<OrderItem> getBooksInfo()
        {
            return this.orderBooksList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.orderView.SelectedItem != null)
            {
                var selectedOrderItem = this.orderView.SelectedItem as OrderItem;
                orderBooksList.Remove(selectedOrderItem);
                this.setOrderBooks(orderBooksList);
            }
            else
            {
                MessageBox.Show("Please select a book to remove");
            }
        }

        private void checkout_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
