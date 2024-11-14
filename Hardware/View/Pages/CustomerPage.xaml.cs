using Hardware.AppData;
using Hardware.View.Windows;
using System.Windows.Controls;

namespace Hardware.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();
            FrameHelper.mainFrame = ListFrame;
        }

        private void AddBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow();
            addOrderWindow.ShowDialog();
        }

        private void MaterialBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ListFrame.Navigate(new View.Pages.MaterialListPage());
        }

        private void AccessoryBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ListFrame.Navigate(new View.Pages.AccessoryListPage());
        }

        private void OrderBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ListFrame.Navigate(new View.Pages.OrderListPage());
        }
    }
}
