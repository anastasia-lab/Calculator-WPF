using System;
using System.Windows;

namespace Cal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstValue; // первое значение
        double SecondValue; // второе значение
        double result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSum_Click(object sender, RoutedEventArgs e) // сумма переменных
        {
            try
            {
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);

                result = FirstValue + SecondValue;
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
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);

                result = FirstValue - SecondValue;
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
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);

                result = FirstValue * SecondValue;
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
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);

                result = FirstValue / SecondValue;
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
                FirstValue = Convert.ToInt32(textBoxA.Text);

                result = Math.Cos(FirstValue);
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
                FirstValue = Convert.ToInt32(textBoxA.Text);

                result = Math.Sin(FirstValue);
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
                FirstValue = Convert.ToInt32(textBoxA.Text);

                result = Math.Tan(FirstValue);
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
                FirstValue = Convert.ToInt32(textBoxA.Text);

                result = Math.Cos(FirstValue) / Math.Sin(FirstValue);
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
                FirstValue = Convert.ToInt32(textBoxA.Text);

                result = Math.Sqrt(FirstValue);
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
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);

                result = Math.Log(FirstValue, SecondValue);
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
                FirstValue = Convert.ToInt32(textBoxA.Text);

                result = Math.Exp(FirstValue);
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
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);

                result = Math.Pow(FirstValue, SecondValue);
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
                FirstValue = Convert.ToDouble(textBoxA.Text);

                result = FactorialFibonachi.Factorial(FirstValue);
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonFibonachi_Click(object sender, RoutedEventArgs e) // число из последовательности фибовани
        {
            FirstValue = Convert.ToDouble(textBoxA.Text);

            result = FactorialFibonachi.Fibonachi(FirstValue);
            textBoxResult.Text = result.ToString();
        }
    }
}
