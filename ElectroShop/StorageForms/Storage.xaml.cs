using ElectroShop.StorageForms;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace ElectroShop.Forms
{
    /// <summary>
    /// Логика взаимодействия для Storage.xaml
    /// </summary>
    public partial class Storage : Page
    {
        public Storage()
        {
            InitializeComponent();
            db = DBContext.GetDBContext();
            db.Storage.Load();
            db.ProductPrices.Load();
            MainStorage.ItemsSource = db.Storage.Local.ToBindingList();
        }
        ElectroShopEntities db;
        private void InsertObj_Click(object sender, RoutedEventArgs e)
        {
            var obj = new ChangeStoragePage();
            obj.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (obj.ShowDialog() == true)
            {
                db.Storage.Add(obj.NewStorage);
                db.SaveChanges();
                db.ProductPrices.Add(obj.NewPrice);
                db.SaveChanges();
            }
        }

        private void UpdateObj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MainStorage.SelectedItems.Count != 0)
                {
                    var currentObj = (ElectroShop.Storage)MainStorage.SelectedItems[0];
                    var obj = new ChangeStoragePage(currentObj);
                    obj.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    if (obj.ShowDialog() == true)
                    {
                        currentObj.Name = obj.NewStorage.Name;
                        currentObj.Count = obj.NewStorage.Count;
                        currentObj.ProductPrices.Price = obj.NewPrice.Price;
                        currentObj.CompanyID = obj.NewStorage.CompanyID;
                        currentObj.TypeID = obj.NewStorage.TypeID;
                        MainStorage.Items.Refresh();
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
                if (MainStorage.SelectedItems.Count != 0)
                {
                    db.Storage.Remove((ElectroShop.Storage)MainStorage.SelectedItems[0]);
                    db.SaveChanges();
                }
            }
            catch { }
        }

        private void RefreshObj_Click(object sender, RoutedEventArgs e)
        {
            MainStorage.Items.Refresh();
        }
    }
}
