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
    public partial class Exercise2 : Window {
        public Exercise2() {
            InitializeComponent();
        }

        private void increment_button_Click(object sender, RoutedEventArgs e) {
            if(int.TryParse(counter.Content.ToString(), out int count))
                counter.Content = (count + 1).ToString();
        }

        private void decrease_button_Click(object sender, RoutedEventArgs e) {
            if(int.TryParse(counter.Content.ToString(), out int count))
                counter.Content = (count - 1).ToString();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            if(int.TryParse(counter.Content.ToString(), out int count))
                counter.Content = (count + 1).ToString();
        }
    }
}
