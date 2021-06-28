using LaboratorySession1.DataBase;
using LaboratorySession1.SupClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaboratorySession1.Windows.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMakeOrder.xaml
    /// </summary>
    public partial class PageMakeOrder : Page
    {
        public PageMakeOrder()
        {
            InitializeComponent();
            CmbName.SelectedValuePath = "Id";
            CmbName.DisplayMemberPath = "Name";
            CmbName.ItemsSource = DB.db.Patient.ToList();

            CmbService.SelectedValuePath = "Id";
            CmbService.DisplayMemberPath = "Name";
            CmbService.ItemsSource = DB.db.Service.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Order order = new DataBase.Order()
            {
                IdService = (int)CmbService.SelectedValue,
                Status = true,
                IdPetient = (int)CmbName.SelectedValue,
                IdLaboratoryAssistant = IdUser.ID,
                DeadLine = Convert.ToDateTime(tbData.Text),
                MeanDeviation = "1 день",
                NumberProbirki = Convert.ToInt32(tbProbirka.Text)
            };
            try
            {
                DB.db.Order.Add(order);
                DB.db.SaveChanges();
                MessageBox.Show("Заказ добавлен", "Успех", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm1.Navigate(new PageAddPAtient());
        }
    }
}
