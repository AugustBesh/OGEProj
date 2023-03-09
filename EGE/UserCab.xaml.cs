using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using XamlApp;

namespace EGE
{
    /// <summary>
    /// Логика взаимодействия для UserCab.xaml
    /// </summary>
    public partial class UserCab : Window
    {
        public UserCab(string login)
        {
            InitializeComponent();
            UserName.Text = $"Имя:{login}";
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
            Random rand = new Random();
            int ind = rand.Next(1, 102); //случайное число от 1 до 102

            using (TreningContext db = new TreningContext())
            {
                // получаем объекты из бд
                var allrules = db.Rules.ToList();
                Rule rule = allrules.FirstOrDefault(x => x.IdRules == ind);
                txtRules.Text = rule.Ruledescription.ToString();
                //foreach(Rule r in allrules)
                //{
                //    MessageBox.Show(r.Ruledescription);
                //}
                
            }
        }
        int a = 0;
        
        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {

        }

        private void Test1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = 1;
            buttonAnimation.To = 590;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1);
            Test2.BeginAnimation(Button.WidthProperty, buttonAnimation);
            new Test1().Show();
            a++;
            Uroki.Text = $"Пройденных уроков: {a}";
            pg.Value += 15;
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
        }

        private void Test2_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = 1;
            buttonAnimation.To = 590;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1);
            Test3.BeginAnimation(Button.WidthProperty, buttonAnimation);
            a++;
            Uroki.Text = $"Пройденных уроков: {a}";
            pg.Value += 15;
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
        }

        private void Test3_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = 1;
            buttonAnimation.To = 590;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1);
            Test4.BeginAnimation(Button.WidthProperty, buttonAnimation);
            a++;
            Uroki.Text = $"Пройденных уроков: {a}";
            pg.Value += 15;
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
            
        }

        private void Test4_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = 1;
            buttonAnimation.To = 590;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1);
            Test5.BeginAnimation(Button.WidthProperty, buttonAnimation);
            a++;
            Uroki.Text = $"Пройденных уроков: {a}";
            pg.Value += 15;
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
        }

        private void Test5_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = 1;
            buttonAnimation.To = 590;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1);
            Test6.BeginAnimation(Button.WidthProperty, buttonAnimation);
            a++;
            Uroki.Text = $"Пройденных уроков: {a}";
            pg.Value += 15;
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
        }

        private void Test6_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = 1;
            buttonAnimation.To = 590;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1);
            Test7.BeginAnimation(Button.WidthProperty, buttonAnimation);
            a++;
            Uroki.Text = $"Пройденных уроков: {a}";
            pg.Value += 15;
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
        }

        private void Test7_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Вы прошли все тесты, отличная работа, вы полностью готовы к сдаче экзаменов!");
            a++;
            Uroki.Text = $"Пройденных уроков: {a}";
            pg.Value += 10;
            pgtext.Text = $"Прогресс по тестам = {pg.Value}%";
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Email для обращения - 4eggsteam@mail.ru");
        }

        private void Image_BadgeChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void Avatar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter =
                "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;

            if (ofdPicture.ShowDialog() == true)
                imgPicture.Source =
                    new BitmapImage(new Uri(ofdPicture.FileName));
        }

        private void logo_Checked(object sender, RoutedEventArgs e)
        {

            Wcab.Background = Brushes.Gray;
            Test1.Background = Brushes.Indigo;
            Test2.Background = Brushes.Indigo;
            Test3.Background = Brushes.Indigo;
            Test4.Background = Brushes.Indigo;
            Test5.Background = Brushes.Indigo;
            Test6.Background = Brushes.Indigo;
            Test7.Background = Brushes.Indigo;
            Quit.Background = Brushes.Indigo;
            Help.Background = Brushes.Indigo;
            Site.Background = Brushes.Indigo;
            testi.Effect = base.Effect;
            Random RandTest = new Random();
            int XTest = RandTest.Next(1, 10);
            TestFrame.Navigate(new TestForFrameDark());
            if (XTest == 1)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 2)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 3)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 4)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 5)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 6)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 7)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 8)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 9)
                TestFrame.Navigate(new TestForFrameDark());
            else if (XTest == 10)
                TestFrame.Navigate(new TestForFrameDark());
        }

        private void logo_Unchecked(object sender, RoutedEventArgs e)
        {
            Wcab.Background = Brushes.AliceBlue;
            Test1.Background = Brushes.SlateGray;
            Test2.Background = Brushes.SlateGray;
            Test3.Background = Brushes.SlateGray;
            Test4.Background = Brushes.SlateGray;
            Test5.Background = Brushes.SlateGray;
            Test6.Background = Brushes.SlateGray;
            Test7.Background = Brushes.SlateGray;
            Quit.Background = Brushes.SlateGray;
            Help.Background = Brushes.SlateGray;
            Site.Background = Brushes.SlateGray;
            Random RandTest = new Random();
            int XTest = RandTest.Next(1, 10);

            if (XTest == 1)
            TestFrame.Navigate(new TestForFrame());
            else if (XTest ==2)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 3)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 4)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 5)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 6)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 7)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 8)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 9)
                TestFrame.Navigate(new TestForFrame());
            else if (XTest == 10)
                TestFrame.Navigate(new TestForFrame());
        }

        private void Site_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
