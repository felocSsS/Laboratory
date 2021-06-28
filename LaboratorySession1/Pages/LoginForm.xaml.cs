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
    /// Логика взаимодействия для LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Page
    {
        bool SuccessLoginIn = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Login = DB.db.User.FirstOrDefault(
                    x => x.Login == tbLogin.Text && x.Password == pbPassword.Password); 
                if(Login != null) // проверка на правильность логина и пароля
                {
                    IdUser.ID = Login.Id;
                    SuccessLoginIn = true;
                    switch (Login.Role)
                    {
                        case "1":
                            FrameClass.frm.Navigate(new LaborantForm(Login.Id));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Не правильный пароль или логин", "BAD NEWS", MessageBoxButton.OK);
                }

                DataBase.Activity activity = new DataBase.Activity()
                {
                    Login = tbLogin.Text,
                    TimeLogin = DateTime.Now,
                    SuccessLoginIN = SuccessLoginIn
                };
                DB.db.Activity.Add(activity);
                try
                {
                    DB.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception exBig)
            {
                MessageBox.Show(exBig.ToString()); // вывод ошибки
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // закрытие приложения
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new HistoryForm());
        }
    }
}
