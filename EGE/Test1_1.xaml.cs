using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EGE
{
    /// <summary>
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void Hint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполним синтаксический анализ.\r\n\r\n(1)[Современный человек испытывает жесточайшее давление не только со стороны моды, но и в нравственном плане] − Предложение простое, в нём одна основа.\r\n\r\n(2)Отрекаясь от собственного мнения, современники отказываются и от собственного нравственного выбора. − Предложение осложнено обособленным обстоятельством.\r\n\r\n(3) [Они должны признать хорошим то, (что общество словом и делом выдает за таковое), и осудить то], (что оно объявляет дурным). − Три основы (первая основа − они должны признать хорошим и осудить)\r\n\r\n(4)При этом они пытаются подавлять рождающиеся в душе сомнения, не проявляя их ни перед другими, ни перед самими собой. − Составное глагольное сказуемое, действительно, есть.\r\n\r\n(5)В результате нравственность человека оказывается подчинена требованиям масс. − Верно.");
        }

        private void check1_Click(object sender, RoutedEventArgs e)
        {
            int a=0;
            int Ans = 0;
            try
            {
                Ans = int.Parse(Answer1.Text);
            }
            catch
            {
                MessageBox.Show("Ответ должен быть введен цифрами!");
                Answer1.Text = string.Empty;
                Answer1.Focus();
                Answer1.Background = Brushes.OrangeRed;
            }
            if (Ans == 45 || Ans == 54)
            {
                new Test1_2().Show();
                a++;
            }
            else
            {
                MessageBox.Show("Ответ неверный");
            }

        }
    }
}
