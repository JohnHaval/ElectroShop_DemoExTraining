using ElectroShop.CompaniesForms;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace ElectroShop.Forms
{
    /// <summary>
    /// Логика взаимодействия для CompaniesPage.xaml
    /// </summary>
    public partial class CompaniesPage : Page
    {
        public CompaniesPage()
        {
            InitializeComponent();
            db = DBContext.GetDBContext();
            db.Companies.Load();
            MainCompanies.ItemsSource = db.Companies.Local.ToBindingList();
        }
        ElectroShopEntities db;

        private void InsertObj_Click(object sender, RoutedEventArgs e)
        {
            var obj = new InsertCompany();
            obj.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (obj.ShowDialog() == true)
            {
                db.Companies.Add(obj.NewCompany);
                db.SaveChanges();
            }
        }

        private void UpdateObj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MainCompanies.SelectedItems.Count != 0)
                {
                    var currentObj = (Companies)MainCompanies.SelectedItems[0];
                    var obj = new InsertCompany(currentObj);
                    obj.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    if (obj.ShowDialog() == true)
                    {
                        currentObj.Name = obj.NewCompany.Name;
                        currentObj.Storage = obj.NewCompany.Storage;
                        MainCompanies.Items.Refresh();
                        db.SaveChanges();
                    }
                }
            }
            catch { }
        }

        private void RemoveObj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MainCompanies.SelectedItems.Count != 0)
                {
                    db.Companies.Remove((Companies)MainCompanies.SelectedItems[0]);
                    db.SaveChanges();
                }
            }
            catch { }
        }

        private void RefreshObj_Click(object sender, RoutedEventArgs e)
        {
            MainCompanies.Items.Refresh();
        }
    }
}
