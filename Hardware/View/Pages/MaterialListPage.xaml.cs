using Hardware.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Hardware.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialListPage.xaml
    /// </summary>
    public partial class MaterialListPage : Page
    {
        List<Material> materials = App.context.Material.ToList();
        public MaterialListPage()
        {
            InitializeComponent();
            MaterialLv.ItemsSource = materials;
        }
    }
}
