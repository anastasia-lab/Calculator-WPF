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
        double a;
        double b;
        double c;
        double x1;
        double x2;
        double result;

        public Equation()
        {
            InitializeComponent();
        }

        private void ButtonQuadratic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);
                c = Convert.ToInt32(textBoxC.Text);

                double dis = Math.Pow(b, 2) - (4 * a * c);

                if (dis >= 0)
                {
                    x1 = (-b - Math.Sqrt(dis)) / (2 * a);
                    x2 = (-b + Math.Sqrt(dis)) / (2 * a);

                    textBoxDis.Text = dis.ToString();
                    textBoxX1.Text = x1.ToString();
                    textBoxX2.Text = x2.ToString();
                }
                else if (dis < 0)
                    textBoxDis.Text = "Дискреминант меньше нуля";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxDis.Clear();
            textBoxResult.Clear();
            textBoxX1.Clear();
            textBoxX2.Clear();
        }

        private void ButtonLinear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);
                c = Convert.ToInt32(textBoxC.Text);

                result = (c - b) / a;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }
    }
    
}
