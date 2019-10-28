using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace TileCalc
{
    public partial class MainWindow
    {
        private void CheckNumbers(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemComma || e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                e.Handled = true;
                TextBox res = (TextBox)sender;
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

        private void Calculating(TextBox main, TextBox depended, TextBox toHide, OperationType operation)
        {
            //toHide.IsEnabled = main.Text == "" ? toHide.IsEnabled = true : toHide.IsEnabled = false;
            if (main.Text != "Заблокировано")
            {
                if (main.Text == string.Empty)
                {
                    toHide.IsEnabled = true;
                    toHide.Text = string.Empty;
                    ResultTotalCost.Text = string.Empty;
                }
                else
                {
                    toHide.IsEnabled = false;
                    toHide.Text = "Заблокировано";
                    if (depended.Text != string.Empty )
                        ResultTotalCost.Text = (Convert.ToDecimal(main.Text) * Convert.ToDecimal(depended.Text)).ToString();

                }
            }
        }

        private void CalculatingTotal(TextBox main)
        {
            if (main.Text == string.Empty)
                ResultTotalCost.Text = string.Empty;
            else if (SourceCostPerMetr.IsEnabled && SourceCostPerMetr.Text != string.Empty && SourceTileSize1.Text != string.Empty && SourceTileSize2.Text != string.Empty)
                ResultTotalCost.Text = (Convert.ToDecimal(main.Text) * Convert.ToDecimal(SourceCostPerMetr.Text)).ToString();
            else if (SourceCostPerUnit.IsEnabled && SourceCostPerUnit.Text != string.Empty && SourceTileSize1.Text != string.Empty && SourceTileSize2.Text != string.Empty)
                ResultTotalCost.Text = (Convert.ToDecimal(main.Text) * Convert.ToDecimal(SourceCostPerUnit.Text)).ToString();

        }

    }
}
