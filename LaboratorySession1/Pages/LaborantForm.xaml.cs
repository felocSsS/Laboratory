using LaboratorySession1.DataBase;
using LaboratorySession1.SupClasses;
using LaboratorySession1.Windows;
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

namespace LaboratorySession1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LaborantForm.xaml
    /// </summary>
    public partial class LaborantForm : Page
    {
        public LaborantForm(int ID)
        {
            InitializeComponent();
            var info = DB.db.User.FirstOrDefault(x => x.Id == ID);
            tbName.Text = info.Name.ToString() + "  Возраст: " + info.Age.ToString();
            
        }


        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.Show();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.GoBack();
        }
    }
}
