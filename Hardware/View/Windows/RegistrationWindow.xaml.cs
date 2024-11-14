using Hardware.Model;
using System.Windows;

namespace Hardware.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(SurnameTb.Text))
            {
                mes += "Введите мероприятие\n";
            }
            if (string.IsNullOrWhiteSpace(NameTb.Text))
            {
                mes += "Выберите вид мероприятия\n";
            }
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                mes += "Выберите вид мероприятия\n";
            }
            if (string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                mes += "Выберите вид мероприятия\n";
            }
            if (string.IsNullOrWhiteSpace(AcceptPasswordTb.Text))
            {
                mes += "Выберите вид мероприятия\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            if (PasswordTb.Text != AcceptPasswordTb.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    // Добавление нового заказчика
                    // 1) Создаём объект
                    App.newCustomer = new User()
                    {
                        Surname = SurnameTb.Text,
                        Name = NameTb.Text,
                        Patronymic = PatronymicTb.Text,
                        Login = LoginTb.Text,
                        Password = AcceptPasswordTb.Text,
                        RoleID = 3
                    };
                    // 2) Добавляем объект в таблицу
                    App.context.User.Add(App.newCustomer);
                    // 3) Сохраняем изменения
                    App.context.SaveChanges();
                    // 4) Уведомить пользователя о добавлении новой записи
                    MessageBox.Show("Успешная регистрация", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }
    }
}
