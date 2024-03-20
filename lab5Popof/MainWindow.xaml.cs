using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab5Popof
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                double b = double.Parse(SideB.Text);
                double c = double.Parse(SideC.Text);
                double perimeter = a + b + c;
                Result.Text = $"Периметр треугольника равен {perimeter:F2}";
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Exception("Введите сторону A отличную от нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Exception("Введите сторону B отличную от нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Exception("Введите сторону C отличную от нуля");
                double perimetr = a + b + c;
                Result.Text = $"Периметр треугольника равен {perimetr:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Exception("Введите сторону A отличную от нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Exception("Введите сторону B отличную от нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Exception("Введите сторону C отличную от нуля");
                double perimetr = a + b + c;
                Result.Text = $"Периметр треугольника: {perimetr}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Perimetr("Введите сторону A отличную от нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Perimetr("Введите сторону B отличную от нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Perimetr("Введите сторону C отличную от нуля");
                double perimetr = a + b + c;
                Result.Text = $"Периметр треугольника: {perimetr}";
            }
            catch (Perimetr ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
               double a = double.Parse(SideA.Text);
               if (a == 0) throw new Perimetr("Введите сторону A отличную от нуля");
               double b = double.Parse(SideB.Text);
               if (b == 0) throw new Perimetr("Введите сторону B отличную от нуля");
               double c = double.Parse(SideC.Text);
               if (c == 0) throw new Perimetr("Введите сторону C отличную от нуля");
               if (a + b > c && a + c > b && b + c > a)
               {
                MessageBox.Show("Треугольник существует");
               }
               else
               {
                MessageBox.Show("Треугольник не существует");
               }
        }
    }
}