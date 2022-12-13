using System;
using System.Linq;
using System.Windows;

namespace ElectroShop.CompaniesForms
{
    /// <summary>
    /// Логика взаимодействия для InsertCompany.xaml
    /// </summary>
    public partial class InsertCompany : Window
    {
        public InsertCompany()
        {
            InitializeComponent();
        }
        public InsertCompany(Companies company)
        {
            InitializeComponent();
            ID.IsReadOnly = true;
            UpdateCompanyProperties(company.ID, company.Name, company.Address);
            ID.Text = company.ID.ToString();
            Name.Text = company.Name;
            Address.Text = company.Address;
            InsertNew.Content = "Изменить";
        }
        public Companies NewCompany;

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InsertNew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateCompanyProperties(Convert.ToInt32(ID.Text), Name.Text, Address.Text);
                DialogResult = true;
            }
            catch
            {
                MessageBox.Show("Некорректно введено значение ID!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ID.Focus();
            }
        }
        private void UpdateCompanyProperties(int id, string name, string address)
        {
            NewCompany = new Companies();
            var countID = from p in DBContext.GetDBContext().Companies.ToList()
                          where p.ID == id
                          select p;
            if (countID.Count() != 0 && !ID.IsReadOnly) throw new Exception();
            NewCompany.ID = id;
            NewCompany.Name = name;
            NewCompany.Address = address;
        }
    }
}
