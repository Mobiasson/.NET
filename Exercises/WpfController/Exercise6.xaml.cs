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
    public partial class Exercise6 : Window {

        public Exercise6() {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
        private void add_button_Click(object sender, RoutedEventArgs e) {
            var newStudent = new Student {
                FirstName = "New",
                LastName = null,
                Email = null
            };
            ((MainViewModel)DataContext).Students.Add(newStudent);
        }
        private void remove_button_Click(object sender, RoutedEventArgs e) {
            if(student_list.SelectedItem is Student student) {
                ((MainViewModel)DataContext).Students.Remove(student);
            }
        }
        private void student_list_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            remove_button.IsEnabled = student_list.SelectedItem != null;
            menuItem_remove.IsEnabled = student_list.SelectedItem != null;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

    }
}
