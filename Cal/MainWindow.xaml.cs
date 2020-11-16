using System;
using System.Windows;

namespace Cal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSum_Click(object sender, RoutedEventArgs e) // сумма переменных
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);

                result = a + b;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonDifference_Click(object sender, RoutedEventArgs e) // разность переменных
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);

                result = a - b;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonMyltiply_Click(object sender, RoutedEventArgs e) // произведение переменных
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);

                result = a * b;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e) // деление переменных
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);

                result = a / b;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonCos_Click(object sender, RoutedEventArgs e) // косинус угла
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);

                result = Math.Cos(a);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonSin_Click(object sender, RoutedEventArgs e) // синус угла
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);

                result = Math.Sin(a);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonTg_Click(object sender, RoutedEventArgs e) // тангенс угла
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);

                result = Math.Tan(a);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonCtg_Click(object sender, RoutedEventArgs e) // котангенс угла
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);

                result = Math.Cos(a) / Math.Sin(a);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonSqrt_Click(object sender, RoutedEventArgs e) // квадратный корень
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);

                result = Math.Sqrt(a);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e) // логорифм переменной а по основанию b
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);

                result = Math.Log(a, b);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonE_Click(object sender, RoutedEventArgs e) // значение е в степени а
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);

                result = Math.Exp(a);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonDegree_Click(object sender, RoutedEventArgs e) // возведение в степень
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);

                result = Math.Pow(a, b);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonEquation_Click(object sender, RoutedEventArgs e) // окно "решить уравнение"
        {
            try
            {
                Equation equation = new Equation(); // открыть окно "решить уравнение"
                equation.Show();

                this.Close(); // закрыть главное окно
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e) // очистка всех полей
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxResult.Clear();
        }

        private void ButtonFactorial_Click(object sender, RoutedEventArgs e) // факториал числа а
        {
            try
            {
                a = Convert.ToDouble(textBoxA.Text);

                result = FactorialFibonachi.Factorial(a);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void ButtonFibonachi_Click(object sender, RoutedEventArgs e) // число из последовательности фибовани
        {
            a = Convert.ToDouble(textBoxA.Text);

            result = FactorialFibonachi.Fibonachi(a);
            textBoxResult.Text = result.ToString();
        }
    }
}
