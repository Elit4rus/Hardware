using Hardware.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Hardware.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        List<User> users = App.context.User.Where(u => u.RoleID == 3).ToList();
        List<Status> statuses = App.context.Status.ToList();
        public AddOrderWindow()
        {
            InitializeComponent();
            CustomerCmb.ItemsSource = users;
            StatusCmb.ItemsSource = statuses;
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Добавление записи в БД
                // 1) Создаем объект
                Order newOrder = new Order()
                {
                    DateStart = (DateTime)DateStartDp.SelectedDate,
                    StatusID = Convert.ToInt32(StatusCmb.SelectedValue),
                    Price = Convert.ToDecimal(PriceTb.Text),
                    UserCustomerID = Convert.ToInt32(CustomerCmb.SelectedValue),
                    DateDue = (DateTime)DateDueDp.SelectedDate,
                    UserManagerID = 12
                };

                // 2) Добавляем объект в таблицу
                App.context.Order.Add(newOrder);

                // 3) Сохраняем изменения
                App.context.SaveChanges();

                // 4) Уведомить пользователя о добавлении новой записи
                MessageBox.Show("Заказ успешно добавлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                DialogResult = true;
                Close();
            }
            catch
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
