using Hardware.View.Windows;
using System;
using System.Linq;
using System.Windows;

namespace Hardware.AppData
{
    public class AuthorizationHelper
    {
        public static string captcha;
        public static bool CheckData(string login, string password)
        {
            // НАВИГАЦИЯ
            // Получаем одну запись по условиям по таблицам БД
            App.currentUser = App.context.User.FirstOrDefault(u => u.Login == login && u.Password == password);
            // продолжение
            if (App.currentUser != null)
            {
                // Генерируем капчу
                if (GenerateCaptcha() == true)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    FrameHelper.mainFrame.Navigate(new View.Pages.CustomerPage());
                    return true;
                }
                // Иначе, то...
                else
                {
                    MessageBox.Show("Капча введена не правильно");
                }
            }
            return false;
        }
        public static bool GenerateCaptcha()
        {
            // Создаем генератор случайных чисел
            Random random = new Random();

            // Очищаем поле с капчей
            captcha = string.Empty; // captcha = "";

            for (int i = 1; i <= 4; i++)
            {
                // Генерируем число и конвертируем его в символ
                char character = Convert.ToChar(random.Next(65, 91));

                // Складываем символы
                captcha += character;
            }

            // Открываем окно
            CaptchaWindow captchaWindow = new CaptchaWindow();
            if (captchaWindow.ShowDialog() == true)
            {
                return true;
            }
            return false;
        }
    }
}
