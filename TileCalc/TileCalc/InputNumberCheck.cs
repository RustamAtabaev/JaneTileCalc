using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace TileCalc
{
  public  partial class MainWindow
  {
    private void CheckNumbers(object sender, KeyEventArgs e)
    {
      if (e.Key == Key.OemComma || e.Key == Key.OemPeriod || e.Key == Key.Decimal)
      {
        e.Handled = true;
        TextBox res = (TextBox) sender;
        if (!res.Text.Contains(','))
        {
          int cursorPosition = res.SelectionStart;
          res.Text = res.Text.Insert(cursorPosition, ",");
          res.SelectionStart = cursorPosition + 1;
        }
      }
      else if (!(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 ||
                 e.Key == Key.Delete || e.Key == Key.Back || e.Key == Key.Left || e.Key == Key.Right))
      {
        e.Handled = true;
      }
    }

    private void Calculating(TextBox main, TextBox depended)
    {
      if (main != null && main.Text != "")
      {
        if (depended != null && depended.Text != "")
          ResultTotalCost.Text = (Convert.ToDecimal(main.Text) * Convert.ToDecimal(depended.Text)).ToString();
      }
    }
  }
}
