using System;
using System.Linq;
using System.Windows;

namespace ElectroShop.StorageForms
{
    /// <summary>
    /// Логика взаимодействия для ChangeStoragePage.xaml
    /// </summary>
    public partial class ChangeStoragePage : Window
    {
        public ChangeStoragePage()
        {
            InitializeComponent();
        }
        public ChangeStoragePage(Storage storage)
        {
            InitializeComponent();
            ID.IsReadOnly = true;
            UpdateCompanyProperties(storage.ID, storage.Name, storage.Count, storage.CompanyID, storage.TypeID, storage.ProductPrices.Price);
            ID.Text = storage.ID.ToString();
            Name.Text = storage.Name;
            Count.Text = storage.Count.ToString();
            CompanyID.Text = storage.CompanyID.ToString();
            TypeID.Text = storage.TypeID.ToString();
            Money.Text = storage.ProductPrices.Price.ToString();
            InsertNew.Content = "Изменить";
        }
        public Storage NewStorage;
        public ProductPrices NewPrice;

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InsertNew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateCompanyProperties(Convert.ToInt32(ID.Text), Name.Text, Convert.ToInt32(Count.Text), Convert.ToInt32(CompanyID.Text), Convert.ToInt32(TypeID.Text), Convert.ToDecimal(Money.Text));
                DialogResult = true;
            }
            catch
            {
                MessageBox.Show("Некорректно введено значение ID!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void UpdateCompanyProperties(int id, string name, int count, int companyID, int typeID, decimal price)
        {
            NewStorage = new Storage();
            NewPrice = new ProductPrices();
            var countID = from p in DBContext.GetDBContext().Storage
                          where p.ID == id
                          select p;
            if (countID.Count() != 0 && !ID.IsReadOnly) throw new Exception();
            NewPrice.ID = NewStorage.ID = id;
            NewPrice.Price = price;
            NewStorage.Name = name;
            NewStorage.Count = count;
            countID = from p in DBContext.GetDBContext().Storage
                          where p.CompanyID == companyID
                          select p;
            if (countID.Count() == 0) throw new Exception();
            countID = from p in DBContext.GetDBContext().Storage
                      where p.TypeID == typeID
                      select p;
            if (countID.Count() == 0) throw new Exception();
            NewStorage.CompanyID = companyID;
            NewStorage.TypeID = typeID;
        }
    }
}
