using Hardware.AppData;
using Hardware.View.Windows;
using System.Windows;

namespace Hardware
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHelper.mainFrame = MainFrame;
            NameTbl.Text = App.currentUser.Surname + " " + App.currentUser.Name + " " + App.currentUser.Patronymic;
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }
    }
}
