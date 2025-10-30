using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XAML {
    public class MainViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();

        private Student _selectedStudent;
        public Student SelectedStudent {
            get => _selectedStudent;
            set {
                _selectedStudent = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel() {
            Students.Add(new Student { FirstName = "Mikael", LastName = "Ros Tobiasson", Email = "mikaeltobiasson@hotmail.com" });
            Students.Add(new Student { FirstName = "Signe", LastName = "Blix Herrlander", Email = "Signeblixh@gmail.se" });
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


