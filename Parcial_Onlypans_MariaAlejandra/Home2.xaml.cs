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
    /// Lógica de interacción para Home2.xaml
    /// </summary>
    public partial class Home2 : Page
    {
        public Home2()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)

        {

            string Nombre = txtNombre.Text;
            string cedula = txtCedula.Text;
            string Tipos = cbxTipodepanes.Text;
            string Precios = lblPrecios.Content.ToString();
            string Cantidad = srCantidadPanes.Value.ToString();
            DateTime Now = DateTime.Now;

            txtpedidos.Items.Add("Fecha: " + DateTime.Now + "\n" + "Nombre: " + Nombre + "\n" + "Cedula: " + cedula + "\n" + "Tipo: " + Tipos + "\n" + "Precio: " + Precios + "\n" + "Cantidad: " + Cantidad);



        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)

        {

            RadioButton rb = sender as RadioButton;

            if (rb.IsChecked.Value)

            {

                lblPrecios.Content = rb.Content.ToString();

            }

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)

        {

            RadioButton rb = sender as RadioButton;

            if (rb.IsChecked.Value)

            {

                lblPrecios.Content = rb.Content.ToString();

            }

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)

        {

            RadioButton rb = sender as RadioButton;

            if (rb.IsChecked.Value)

            {

                lblPrecios.Content = rb.Content.ToString();

            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {

            ComboBox cb = sender as ComboBox;

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)

        {

            MainWindow w = (MainWindow)Window.GetWindow(this);

            w.mainFrame.NavigationService.Navigate(new Login());

        }


        private void srLevel_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)

        {

            lblCantidadPanes.Content = "Cantidad:" + srCantidadPanes.Value.ToString();

        }
    }
}
