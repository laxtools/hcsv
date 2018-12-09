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

namespace HandlingText
{
    /// <summary>
    /// Console.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Console : Window
    {
        public Console()
        {
            InitializeComponent();
        }

        private void OnTextBlockLoaded(object sender, RoutedEventArgs e)
        {
            // Get TextBlock reference.
            var block = sender as TextBlock;
            // Set text.
            block.Text = "This is some longer text in the TextBlock. " +
                "We see how it wraps in this example. " +
                "TextBlock is meant for longer text.";
        }
    }
}
