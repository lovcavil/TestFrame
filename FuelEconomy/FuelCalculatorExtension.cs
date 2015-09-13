using System.ComponentModel.Composition;
using System.Windows;

namespace StupidMonkey
{
  [CalculatorExtensionExport(typeof(ICalculatorExtension),
    Title = "Fuel Economy",
    Description = "Calculate fuel economy",
    ImageUri = "Fuel.png")]
  // [Export(typeof(ICalculatorExtension))]
  public class FuelCalculatorExtension : ICalculatorExtension
  {
    private FrameworkElement control;
    public FrameworkElement UI
    {
      get
      {
        return control ?? (control = new FuelEconomyUC());
      }
    }
  }
}
