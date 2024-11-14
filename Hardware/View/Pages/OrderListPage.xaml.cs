using Hardware.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Hardware.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderListPage.xaml
    /// </summary>
    public partial class OrderListPage : Page
    {
        List<Order> orders = App.context.Order.ToList();
        public OrderListPage()
        {
            InitializeComponent();
            OrdersLv.ItemsSource = orders;
        }
    }
}
