using Hardware.Model;
using System.Windows;

namespace Hardware
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HardwareEntities context = new HardwareEntities();
        public static User currentUser;
        public static User newCustomer;
    }
}
