using LaboratorySession1.DataBase;
using LaboratorySession1.SupClasses;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        private void HistoryDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            dynamic row = e.Row.Item;
            // для 1 элемента
            if ((row.Id + 1) != 0 && (row.Id + 1) % 3 != 0)
            {
                e.Row.Background = new SolidColorBrush(Colors.Red);
            }
            else if ((row.Id + 1) == 0 && (row.Id + 1) % 3 != 0)
            {
                e.Row.Background = new SolidColorBrush(Colors.Red);
            }
            // для 3 элемента
            if ((row.Id + 1) != 0 && (row.Id + 1) % 3 == 0)
            {
                e.Row.Background = new SolidColorBrush(Colors.Blue);
            }
            else if ((row.Id + 1) == 0 && (row.Id + 1) % 3 == 0)
            {
                e.Row.Background = new SolidColorBrush(Colors.Blue);
            }
            // для 2 элемента 
            if ((row.Id + 1) != 0 && (row.Id + 2) % 3 == 0)
            {
                e.Row.Background = new SolidColorBrush(Colors.Yellow);
            }
            else if ((row.Id + 1) == 0 && (row.Id + 2) % 3 != 0)
            {
                e.Row.Background = new SolidColorBrush(Colors.Yellow);
            }
        }
    }
}
