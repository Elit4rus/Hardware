using Hardware.Model;
using Hardware.View.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Hardware.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        List<Order> orders = App.context.Order.ToList();
        public CustomerPage()
        {
            InitializeComponent();
            OrdersLv.ItemsSource = orders;
        }

        private void AddBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow();
            addOrderWindow.ShowDialog();
        }
    }
}
