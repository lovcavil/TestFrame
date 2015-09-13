using System.Windows.Media.Imaging;

namespace StupidMonkey
{
  public interface ICalculatorExtensionMetadata
  {
    string Title { get; }
    string Description { get; }

    string ImageUri { get; }
  }
}
