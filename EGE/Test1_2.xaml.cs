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
    public partial class Test1_2 : Window
    {
        public Test1_2()
        {
            InitializeComponent();
        }

        private void Hint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1)  запятая выделяет вводное.\r\n\r\n2)  запятая между основами в сложном предложении.\r\n\r\n5)  и 7) запятые между однородными дополнениями.\r\n\r\n8)  запятая между однородными определениями: определения являются однородными, потому что это эпитеты (однородными являются художественные определения (эпитеты)!)");
        }


        private void check2_Click(object sender, RoutedEventArgs e)
        {
            int a=0;
            int Ans = 0;
            try
            {
                Ans = int.Parse(Answer2.Text);
            }
            catch
            {
                MessageBox.Show("Ответ должен быть введен цифрами!");
                Answer2.Text = string.Empty;
                Answer2.Focus();
                Answer2.Background = Brushes.OrangeRed;
            }
            if (Ans == 12578)
            {
                new Test1_3().Show();
                a++;
            }
            else
            {
                MessageBox.Show("Ответ неверный");
            }
        }

        private void skip_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
