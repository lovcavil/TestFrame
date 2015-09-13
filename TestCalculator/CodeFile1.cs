using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TestCalculator;

namespace StupidMonkey
{
    [CalculatorExtensionExport(typeof(ICalculatorExtension),
      Title = "Test Conversion",
      Description = "Test Celsius to Fahrenheit and Fahrenheit to Celsius",
      ImageUri = "Test.png")]
    public class TestCalculatorExtension : ICalculatorExtension
    {

        private TestCal control;
        public FrameworkElement UI
        {
            get
            {
                return control ?? (control = new TestCal());
            }
        }


        private BitmapImage image;
        public BitmapImage Image
        {
            get
            {
                if (image == null)
                {
                    image = new BitmapImage();
                    image.BeginInit();
                    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StupidMonkey.Images.Test.png");
                    image.StreamSource = stream;
                    image.EndInit();
                }
                return image;
            }
        }
    }
}
