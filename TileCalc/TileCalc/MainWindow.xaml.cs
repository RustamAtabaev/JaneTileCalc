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

namespace TileCalc
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      ListBoxItem operation = new ListBoxItem();
      operation.Content = "Первая операция";
      OperationList.Items.Add(operation);
    }

    private void SourceTotalArea_OnKeyDown(object sender, KeyEventArgs e)
    {
      CheckNumbers(sender, e);
    }
    private void SourceTotalArea_OnTextChanged(object sender, TextChangedEventArgs e)
    {
      Calculating((TextBox) sender, SourceCostPerMetr);
    }

    private void SourceCostPerMetr_OnKeyDown(object sender, KeyEventArgs e)
    {
      CheckNumbers(sender, e);
    }
    private void SourceCostPerMetr_TextChanged(object sender, TextChangedEventArgs e)
    {
      Calculating((TextBox)sender, SourceTotalArea);
    }

  }
}
