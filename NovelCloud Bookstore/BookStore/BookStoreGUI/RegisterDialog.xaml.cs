using BookStoreLIB;
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

namespace BookStoreGUI
{
    /// <summary>
    /// Interaction logic for RegisterDialog.xaml
    /// </summary>
    public partial class RegisterDialog : Window
    {
        public RegisterDialog()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            UserRegister reg = new UserRegister();

            if (reg.Register(this.nameTextBox.Text, this.passwordTextBox.Password, this.passwordVerifyTextBox.Password, this.fullNameTextBox.Text))
            {
                this.registrationStatusLabel.Content = "";
                this.DialogResult = true;
            }
            else
            {
                this.registrationStatusLabel.Content = reg.ErrorMessage;
                return;
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
