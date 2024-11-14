using Hardware.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Hardware.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AccessoryListPage.xaml
    /// </summary>
    public partial class AccessoryListPage : Page
    {
        List<Accessory> accessories = App.context.Accessory.ToList();
        public AccessoryListPage()
        {
            InitializeComponent();
            AccessoryLv.ItemsSource = accessories;
        }
    }
}
