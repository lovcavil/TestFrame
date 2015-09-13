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

namespace TestCalculator
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class TestCal : UserControl
    {
        public TestCal()
        {
            InitializeComponent();
        }

        private void OnCalculate(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {

                textOutput.Text = "12131314";

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }



}
