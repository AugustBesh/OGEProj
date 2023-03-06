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
    /// Логика взаимодействия для Test1_3.xaml
    /// </summary>
    public partial class Test1_3 : Window
    {
        public Test1_3()
        {
            InitializeComponent();
        }

        private void Hint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Примыкание − вид связи, при котором зависимое слово связывается с главным по смыслу.");
        }


        private void check2_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            string Ans = "";
            try
            {
                Ans = Answer3.Text;
            }
            catch
            {
                MessageBox.Show("Ответ должен быть введен раздельно и с маленькой буквы!");
                Answer3.Text = string.Empty;
                Answer3.Focus();
                Answer3.Background = Brushes.OrangeRed;
            }
            if (Ans == "встретить радостно" || Ans == "радостно встретить")
            {
                new Test1_4().Show();
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
