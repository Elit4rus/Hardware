using Hardware.AppData;
using System.Windows;

namespace Hardware.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        public CaptchaWindow()
        {
            InitializeComponent();
            CaptchaTbl.Text = AuthorizationHelper.captcha;
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CaptchaTb.Text == AuthorizationHelper.captcha)
            {
                MessageBox.Show("Вы не робот");

                // Возвращаем результат диалового окна
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Вы робот");
                // Возвращаем результат диалового окна
                DialogResult = true;
            }
        }
    }
}
