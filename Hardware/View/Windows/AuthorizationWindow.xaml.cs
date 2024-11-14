using Hardware.AppData;
using System.Windows;

namespace Hardware.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorizationHelper.CheckData(LoginTb.Text, PasswordPb.Password) == true)
            {
                // успешная авторизация
                Close();
            }
            else
            {
                if (BlockSystemHelper.IncreaseIncorrectInput() == 3)
                {

                    BlockWindow blockWindow = new BlockWindow();
                    if (blockWindow.ShowDialog() == true)
                    {
                        BlockSystemHelper.incorrectInput = 0;
                    }
                }
                else
                {
                    // неуспешная авторизация
                    MessageBox.Show("Пользователь не найден");
                }
            }
        }

        private void RegHl_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }
    }
}
