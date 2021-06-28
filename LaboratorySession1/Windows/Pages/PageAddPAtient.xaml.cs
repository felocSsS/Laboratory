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
    /// Логика взаимодействия для PageAddPAtient.xaml
    /// </summary>
    public partial class PageAddPAtient : Page
    {
        public PageAddPAtient()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm1.GoBack();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Patient patient = new DataBase.Patient()
            {
                Name = tbName.Text,
                Passport = tbPassport.Text,
                PhoneNumber = tbPhone.Text,
                Email = tbEmail.Text,
                IPN = Convert.ToInt32(tbNumberStrazovania.Text),
                TypeOfIPN = 1
            };
            try
            {
                DB.db.Patient.Add(patient);
                DB.db.SaveChanges();
                MessageBox.Show("Пациент добавлен", "Успех", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
