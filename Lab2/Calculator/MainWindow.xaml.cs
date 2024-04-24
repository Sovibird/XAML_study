using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
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

        double a = 0, b = 0;
        enum Action {Add, Take, Mult, Div};
        Action taken;
        string action = "";
        bool clicked;
        List<string> operations;

        private void b0_click(object sender, RoutedEventArgs e)
        {
            output.Text += "0";
        }
        private void b1_click(object sender, RoutedEventArgs e)
        {
            output.Text += "1";
        }
        private void b2_click(object sender, RoutedEventArgs e)
        {
            output.Text += "2";
        }
        private void b3_click(object sender, RoutedEventArgs e)
        {
            output.Text += "3";
        }
        private void b4_click(object sender, RoutedEventArgs e)
        {
            output.Text += "4";
        }
        private void b5_click(object sender, RoutedEventArgs e)
        {
            output.Text += "5";
        }
        private void b6_click(object sender, RoutedEventArgs e)
        {
            output.Text += "6";
        }
        private void b7_click(object sender, RoutedEventArgs e)
        {
            output.Text += "7";
        }
        private void b8_click(object sender, RoutedEventArgs e)
        {
            output.Text += "8";
        }
        private void b9_click(object sender, RoutedEventArgs e)
        {
            output.Text += "9";
        }
        private void bDecimal_click(object sender, RoutedEventArgs e)
        {
            output.Text += ",";
        }
        private void bAdd_click(object sender, RoutedEventArgs e)
        {
            a += double.Parse(output.Text);
            action += output.Text + "+";
            output.Text = "";
            taken = Action.Add;
        }
        private void bTake_click(object sender, RoutedEventArgs e)
        {
            a += double.Parse(output.Text);
            action += output.Text + "-";
            output.Text = "";
            taken = Action.Take;
        }
        private void bMult_click(object sender, RoutedEventArgs e)
        {
            a += double.Parse(output.Text);
            action += output.Text + "*";
            output.Text = "";
            taken = Action.Mult;
        }
        private void bDiv_click(object sender, RoutedEventArgs e)
        {
            a += double.Parse(output.Text);
            action += output.Text + "/";
            output.Text = "";
            taken = Action.Div;
        }
        private void checkWrite(object sender, RoutedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            clicked = true;
        }
        private void bEqual_click(object sender, RoutedEventArgs e)
        {
            action += output.Text;
            switch (taken) {
                case Action.Add:
                    b = a + double.Parse(output.Text);
                    break;
                case Action.Take:
                    b = a - double.Parse(output.Text);
                    break;
                case Action.Mult:
                    b = a * double.Parse(output.Text);
                    break;
                case Action.Div:
                    b = a / double.Parse(output.Text);
                    break;
            };
            a = 0;
            output.Text = b.ToString();
            action = action + "=" + output.Text;
            while (clicked == true)
            {
                listOperations.Items.Add(action);
                break;
            }
            
        }
        private void c_click(object sender, RoutedEventArgs e)
        {
            listOperations.Items.Clear();
            output.Text = "";
        }
        private void clast_click(object sender, RoutedEventArgs e)
        {
            listOperations.Items.RemoveAt(listOperations.Items.Count - 1);
        }
        private void checkShow(object sender, RoutedEventArgs e)
        {
            var rb = (RadioButton)sender;
            if (rb.IsChecked == true && rb == showSettings)
            {
                settings.Visibility = Visibility.Visible;
            }
            else settings.Visibility = Visibility.Collapsed;
        }
    }
}
