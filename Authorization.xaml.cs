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
using System.Windows.Shapes;

namespace Bank
{
    
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        Entities db = new Entities();
        public int level_out;
        public int exit_switch = 0;
        
        public Authorization()
        {
            InitializeComponent();
        }

        

        private void btn_auth_client_Click(object sender, RoutedEventArgs e)
        {
            if (exit_switch == 0)
            {
                Account acc = db.Account.SingleOrDefault(t => t.Login == login_client.Text && t.Password == Password_client.Password);
                if (acc == null)
                {
                    MessageBox.Show("Debil");
                }
                else if (acc != null)
                {
                    int client_out = acc.ID_account;

                    MainWindowClient m = new MainWindowClient(client_out);
                    m.Show();
                    Close();
                }
            }
            else if (exit_switch == 1)
            {
                Employers emp = db.Employers.SingleOrDefault(t => t.login == login_client.Text && t.password == Password_client.Password);
                if (emp == null)
                {
                    MessageBox.Show("Debil");
                }
                else if (emp.type_of_employee == 1)
                {
                    MainWindowAdmin m = new MainWindowAdmin();
                    m.Show();
                    Close();
                }
                else if (emp.type_of_employee == 2)
                {
                    MainWindowModerator m = new MainWindowModerator();
                    m.Show();
                    Close();
                }
                else if (emp.type_of_employee == 3)
                {
                    MainWindowOperator m = new MainWindowOperator();
                    m.Show();
                    Close();
                }
            }
            
        }

        private void btn_switch_Click(object sender, RoutedEventArgs e)
        {
            if (exit_switch == 1)
            {
                btn_switch.Content = "Войти как клиент";
                exit_switch = 0;
            }
            else if (exit_switch == 0)
            {
                btn_switch.Content = "Войти как сотрудник";
                exit_switch = 1;
            }
           
        }

        private void btn_forgot_pass_Click(object sender, RoutedEventArgs e)
        {
                System.Diagnostics.Process.Start("https://steamuserimages-a.akamaihd.net/ugc/781853393499969252/26030625A363AFB677F475A413569B0CBB9CAFE5/");
        }
    }
}
