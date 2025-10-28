using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace XAML {
    public partial class Exercise3 : Window {
        public Exercise3() {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            label.Content = $"X = {x_slider.Value:F0}, Y = {y_slider.Value:F0}";
            Canvas.SetLeft(movableLabel, x_slider.Value);
            Canvas.SetTop(movableLabel, y_slider.Value);
        }

    }
}
