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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EGE
{
    /// <summary>
    /// Логика взаимодействия для TestForFrameDark.xaml
    /// </summary>
    public partial class TestForFrameDark2 : Page
    {
        public TestForFrameDark2()
        {
            InitializeComponent();
        }
        private void Var1_Click(object sender, RoutedEventArgs e)
        {
            answerframe.Text = "Ответ неверный :(";
        }

        private void Var2_Click(object sender, RoutedEventArgs e)
        {
            answerframe.Text = "Ответ неверный :(";
        }

        private void Var3_Click(object sender, RoutedEventArgs e)
        {
            answerframe.Text = "Ответ неверный :(";
            var image = new BitmapImage();
        }

        private void Var4_Click(object sender, RoutedEventArgs e)
        {
            answerframe.Text = "Ответ неверный :(";
        }

        private void Good_Click(object sender, RoutedEventArgs e)
        {
            answerframe.Text = "Ответ правильный! :) Вы молодец!";
        }
    }
}
