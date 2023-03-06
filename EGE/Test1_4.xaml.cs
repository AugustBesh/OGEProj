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
    /// Логика взаимодействия для Test1_4.xaml
    /// </summary>
    public partial class Test1_4 : Window
    {
        public Test1_4()
        {
            InitializeComponent();
        }

        private void Hint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполним синтаксический анализ.\r\n\r\n(1) БЕСПОЛЕЗНЫЙ  — на конце приставки перед буквой, обозначающей глухой согласный звук, пишется буква С.\r\n\r\n" +
                "(2) ПОКРАШЕННЫЙ (забор)  — в суффиксе причастия пишется -НН-.\r\n\r\n" +
                "(3)  ВЫРАСТИТЬ (урожай)  — написание безударной чередующейся гласной в корне слова зависит конечного согласного корня: перед СТ пишем А.\r\n\r\n" +
                "(4) (охватывает) ДРОЖЬ  — в существительных III склонения после шипящего буква Ь пишется.\r\n\r\n" +
                "(5) (съел) ПОЛ-ЯГОДКИ  — слова, начинающиеся с гласного, с ПОЛ- пишутся через дефис.");
        }

        private void check3_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int Ans = 0;
            try
            {
                Ans = int.Parse(Answer4.Text);
            }
            catch
            {
                MessageBox.Show("Ответ должен быть введен цифрами!");
                Answer4.Text = string.Empty;
                Answer4.Focus();
                Answer4.Background = Brushes.OrangeRed;
            }
            if (Ans == 14 || Ans == 41)
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
