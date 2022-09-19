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

namespace Cal
{
    /// <summary>
    /// Логика взаимодействия для Equation.xaml
    /// </summary>
    public partial class Equation : Window
    {
        double FirstValue; // первое значение
        double SecondValue; // второе значение
        double ThirdValue; // третье значение
        double FirstRoot; // первый корень (х1)
        double SecondRoot; // второй корень (х2)
        double result;

        public Equation()
        {
            InitializeComponent();
        }

        private void ButtonQuadratic_Click(object sender, RoutedEventArgs e) // квадратное уравнение
        {
            try
            {
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);
                ThirdValue = Convert.ToInt32(textBoxC.Text);

                double dis = Math.Pow(SecondValue, 2) - (4 * FirstValue * ThirdValue); // дискреминант

                if (dis >= 0)
                {
                    FirstRoot = (-SecondValue - Math.Sqrt(dis)) / (2 * FirstValue);
                    SecondRoot = (-SecondValue + Math.Sqrt(dis)) / (2 * FirstValue);

                    textBoxDis.Text = dis.ToString();
                    textBoxX1.Text = FirstRoot.ToString();
                    textBoxX2.Text = SecondRoot.ToString();
                }
                else if (dis < 0)
                    textBoxDis.Text = "Дискреминант меньше нуля";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e) // очистить все поля
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxDis.Clear();
            textBoxResult.Clear();
            textBoxX1.Clear();
            textBoxX2.Clear();
        }

        private void ButtonLinear_Click(object sender, RoutedEventArgs e) // линейное уравнение
        {
            try
            {
                FirstValue = Convert.ToInt32(textBoxA.Text);
                SecondValue = Convert.ToInt32(textBoxB.Text);
                ThirdValue = Convert.ToInt32(textBoxC.Text);

                result = (ThirdValue - SecondValue) / FirstValue;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }
    }
    
}
