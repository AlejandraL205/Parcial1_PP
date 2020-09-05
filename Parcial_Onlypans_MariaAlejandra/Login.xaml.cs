using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial_Onlypans_MariaAlejandra
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)

        {

            if (txtUsername.Text == "Administrador" && txtPassword.Password == "1234")

            {
                    MainWindow w = (MainWindow)Window.GetWindow(this);

                    w.mainFrame.NavigationService.Navigate(new Home1());
            }

            else if (txtUsername.Text == "Otros" && txtPassword.Password == "1234")

            {
                    MainWindow w = (MainWindow)Window.GetWindow(this);

                    w.mainFrame.NavigationService.Navigate(new Home2());
            }

            else

            {
                    MessageBox.Show("Invalid.");
            }

        }
        
    }
}