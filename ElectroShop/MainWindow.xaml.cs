using ElectroShop.Forms;
using System.Windows;

namespace ElectroShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToStorage_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Forms.Storage());
        }

        private void ToCompanies_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new CompaniesPage());
        }

        private void ToTypes_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new TypesPage());
        }

        private void Queries_Click(object sender, RoutedEventArgs e)
        {
            var win = new Queries()
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            win.ShowDialog();
        }
    }
}
