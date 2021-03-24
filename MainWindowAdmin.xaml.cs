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
    /// Логика взаимодействия для MainWindowAdmin.xaml
    /// </summary>
    public partial class MainWindowAdmin : Window
    {
        Entities db = new Entities();
        public MainWindowAdmin()
        {
            InitializeComponent();
            Update();
        }


        public void Update()
        {
            DG_Account.ItemsSource = db.Bank_account_number.ToList();
            DG_History.ItemsSource = db.Transaction.ToList();
            DG_Clients.ItemsSource = db.Account.ToList();
            DG_Employee.ItemsSource = db.Employers.ToList();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Authorization m = new Authorization();
            m.Show();
            Close();
        }

        private void txbx_search_score_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbx_search_score.Text !="")
            {
                DG_Account.ItemsSource = db.Bank_account_number.Where(t => t.Account.Passport_data.last_name == txbx_search_score.Text).ToList();
            }
            else
            {
                Update();
            }
        }

        private void btn_search_score_reset_Click(object sender, RoutedEventArgs e)
        {
            txbx_search_score.Text = "";
        }

       

        private void txbx_search_history_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbx_search_history.Text != "")
            {
                DG_Account.ItemsSource = db.Transaction.Where(t => t.Sender.Passport_data.last_name == txbx_search_score.Text).ToList();
            }
            else
            {
                Update();
            }
        }

        private void btn_search_history_reset_Click(object sender, RoutedEventArgs e)
        {
           txbx_search_history.Text = "";
        }

        private void txbx_search_client_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbx_search_history.Text != "")
            {
                DG_Account.ItemsSource = db.Account.Where(t => t.Passport_data.last_name == txbx_search_score.Text).ToList();
            }
            else
            {
                Update();
            }
        }

        private void btn_search_client_reset_Click(object sender, RoutedEventArgs e)
        {
          txbx_search_client.Text = "";
        }

        private void txbx_search_employee_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbx_search_history.Text != "")
            {
                DG_Account.ItemsSource = db.Employers.Where(t => t.Passport_data.last_name == txbx_search_score.Text).ToList();
            }
            else
            {
                Update();
            }
        }

        private void btn_search_employee_reset_Click(object sender, RoutedEventArgs e)
        {
            txbx_search_employee.Text = "";
        }
    }
}
