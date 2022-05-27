using revenue_control.Model;
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

namespace revenue_control.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Transaction> transactionList = new List<Transaction>();  
        public MainWindow()
        {

            InitializeComponent();

            transactionList.Add(new Transaction() 
                                                    { Id = 1, 
                                                    Name = "Покупка продуктов",    
                                                    Value = -2500, 
                                                    Date = new DateTime(2022, 05, 07)});
            transactionList.Add(new Transaction()
                                                    { Id = 2,
                                                        Name = "Покупка одежды",
                                                        Value = -1600,
                                                        Date = new DateTime(2022, 05, 06)
                                                    });
            transactionList.Add(new Transaction()
                                                    {
                                                        Id = 3,
                                                        Name = "Поступление зарплаты",
                                                        Value = 16000,
                                                        Date = new DateTime(2022, 05, 07)
                                                    });

            dgTransactions.ItemsSource = transactionList;



            lst_income.ItemsSource = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(0, "Основная работа"),
                new KeyValuePair<int, string>(1, "Подработка"),
                new KeyValuePair<int, string>(2, "Хобби"),
                new KeyValuePair<int, string>(3, "Подарки"),
                new KeyValuePair<int, string>(4, "Другое"),
            };

            lst_expence.ItemsSource = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(0, "Еда"),
                new KeyValuePair<int, string>(1, "Проживание"),
                new KeyValuePair<int, string>(2, "Транспорт"),
                new KeyValuePair<int, string>(3, "Одежда"),
                new KeyValuePair<int, string>(4, "Косметика и уход"),
                new KeyValuePair<int, string>(5, "Другое"),
            };

            List<string> year_list = new List<string>();

            for (int i = 2000; i <= int.Parse(DateTime.Now.Year.ToString()); i++)
            {
                year_list.Add(i.ToString());
            }     

            cb_year.ItemsSource = year_list;

            List<string> month_list = new List<string>()
            {
                "январь","февраль","март","апрель","май","июнь","июль","август","сентябрь","октябрь","ноябрь","декабрь"
            };

            cb_month.ItemsSource = month_list;

            List<KeyValuePair<int, string>> temp_list = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(0, "Основная работа"),
                new KeyValuePair<int, string>(1, "Подработка"),
                new KeyValuePair<int, string>(2, "Хобби"),
                new KeyValuePair<int, string>(3, "Подарки"),
                new KeyValuePair<int, string>(4, "Другое"),
                new KeyValuePair<int, string>(0, "Еда"),
                new KeyValuePair<int, string>(1, "Проживание"),
                new KeyValuePair<int, string>(2, "Транспорт"),
                new KeyValuePair<int, string>(3, "Одежда"),
                new KeyValuePair<int, string>(4, "Косметика и уход"),
                new KeyValuePair<int, string>(5, "Другое"),

            };
        }

        private void bt_addTransaction_Click(object sender, RoutedEventArgs e)
        {
            WindowAddNewTransaction windowAddNewTransaction = new WindowAddNewTransaction();
            windowAddNewTransaction.Owner = this;
            windowAddNewTransaction.ShowDialog();
        }
    }
}
