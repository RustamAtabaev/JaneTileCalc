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

namespace TileCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum OperationType
        {
            CalculationPerMetr,
            CalculationPerUnit
        }

        OperationType operationType;

        public MainWindow()
        {
            InitializeComponent();

            // Создаем масив операций
            ListBoxItem operation = new ListBoxItem();
            operation.Content = "Первая операция";
            OperationList.Items.Add(operation);

            // Определяем конфигурации
            
        }

        /// <summary>
        /// Метод определения стоимости вызываемый с общей стоимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceTotalArea_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CalculatingTotal((TextBox)sender);
        }

        /// <summary>
        /// Метод определения стоимости для параметра: стоимость за метр квадратный
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceCostPerMetr_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculating((TextBox)sender, SourceTotalArea, SourceCostPerUnit, operationType);
        }

        /// <summary>
        /// Метод определения стоимости для параметра: стоимость за одну плитку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceCostPerUnit_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculating((TextBox)sender, SourceTotalArea, SourceCostPerMetr, OperationType.CalculationPerUnit);
        }

        private void SourceTileSize1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SourceTileSize2_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
