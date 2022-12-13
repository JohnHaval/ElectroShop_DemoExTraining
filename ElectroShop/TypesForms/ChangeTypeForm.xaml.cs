using System;
using System.Linq;
using System.Windows;

namespace ElectroShop.TypesForms
{
    /// <summary>
    /// Логика взаимодействия для ChangeTypeForm.xaml
    /// </summary>
    public partial class ChangeTypeForm : Window
    {
        public ChangeTypeForm()
        {
            InitializeComponent();
        }
        public ChangeTypeForm(Types type)
        {
            InitializeComponent();
            ID.IsReadOnly = true;
            UpdateCompanyProperties(type.ID, type.Name);
            ID.Text = type.ID.ToString();
            Name.Text = type.Name;
            InsertNew.Content = "Изменить";
        }
        public Types NewType;

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InsertNew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateCompanyProperties(Convert.ToInt32(ID.Text), Name.Text);
                DialogResult = true;
            }
            catch
            {
                MessageBox.Show("Некорректно введено значение ID!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ID.Focus();
            }
        }
        private void UpdateCompanyProperties(int id, string name)
        {
            NewType = new Types();
            var countID = from p in DBContext.GetDBContext().Types.ToList()
                          where p.ID == id
                          select p;
            if (countID.Count() != 0 && !ID.IsReadOnly) throw new Exception();
            NewType.ID = id;
            NewType.Name = name;
        }
    }
}
