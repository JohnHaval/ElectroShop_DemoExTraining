using ElectroShop.TypesForms;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace ElectroShop.Forms
{
    /// <summary>
    /// Логика взаимодействия для TypesPage.xaml
    /// </summary>
    public partial class TypesPage : Page
    {
        public TypesPage()
        {
            InitializeComponent();
            db = DBContext.GetDBContext();
            db.Types.Load();
            MainTypes.ItemsSource = db.Types.Local.ToBindingList();
        }
        ElectroShopEntities db;
        private void InsertObj_Click(object sender, RoutedEventArgs e)
        {
            var obj = new ChangeTypeForm();
            obj.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (obj.ShowDialog() == true)
            {
                db.Types.Add(obj.NewType);
                db.SaveChanges();
            }
        }

        private void UpdateObj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MainTypes.SelectedItems.Count != 0)
                {
                    var currentObj = (Types)MainTypes.SelectedItems[0];
                    var obj = new ChangeTypeForm(currentObj);
                    obj.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    if (obj.ShowDialog() == true)
                    {
                        currentObj.Name = obj.NewType.Name;
                        currentObj.Storage = obj.NewType.Storage;
                        MainTypes.Items.Refresh();
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
                if (MainTypes.SelectedItems.Count != 0)
                {
                    db.Types.Remove((Types)MainTypes.SelectedItems[0]);
                    db.SaveChanges();
                }
            }
            catch { }
        }

        private void RefreshObj_Click(object sender, RoutedEventArgs e)
        {
            MainTypes.Items.Refresh();
        }
    }
}
