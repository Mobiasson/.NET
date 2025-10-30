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

namespace XAML {
    public partial class Exercise5 : Window {

        public Exercise5() {
            InitializeComponent();
        }

        private void xy_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            if(x_lock.IsChecked == false && y_lock.IsChecked == true) {
                Canvas.SetLeft(movableLabel, xy_slider.Value);
                Canvas.SetRight(movableLabel, xy_slider.Value);
            }
            else if(x_lock.IsChecked == true && y_lock.IsChecked == false) {
                Canvas.SetTop(movableLabel, xy_slider.Value);
                Canvas.SetBottom(movableLabel, xy_slider.Value);
            }
            else if(x_lock.IsChecked == false && y_lock.IsChecked == false) {
                Canvas.SetTop(movableLabel, xy_slider.Value);
                Canvas.SetBottom(movableLabel, xy_slider.Value);
                Canvas.SetLeft(movableLabel, xy_slider.Value);
                Canvas.SetRight(movableLabel, xy_slider.Value);
            }
            else if(x_lock.IsChecked == true && y_lock.IsChecked == true) {
                return;
            }
            label.Content = $"X{e.NewValue:F0}, Y{e.NewValue:F0}";
        }

    }
}
