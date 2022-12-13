using System.Linq;
using System.Windows;

namespace ElectroShop
{
    /// <summary>
    /// Логика взаимодействия для Queries.xaml
    /// </summary>
    public partial class Queries : Window
    {
        public Queries()
        {
            InitializeComponent();
        }

        private void CostView_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in DBContext.GetDBContext().Storage
                        select new { p.ID, p.Name, Cost = p.Count * p.ProductPrices.Price };
            MainTable.ItemsSource = query.ToList();
        }
    }
}
