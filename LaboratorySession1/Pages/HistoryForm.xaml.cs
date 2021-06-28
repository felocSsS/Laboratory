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

namespace LaboratorySession1.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryForm.xaml
    /// </summary>
    public partial class HistoryForm : Page
    {

        public HistoryForm()
        {
            InitializeComponent();
            HistoryDataGrid.ItemsSource = DB.db.Activity.ToList();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.GoBack();
        }
    }
}
