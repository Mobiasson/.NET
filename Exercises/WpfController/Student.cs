using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XAML;
public class Student : INotifyPropertyChanged {

    public event PropertyChangedEventHandler? PropertyChanged;

    private string _firstName;
    public string FirstName {
        get => _firstName;
        set {
            _firstName = value;
            RaisePropertyChanged();
            RaisePropertyChanged(nameof(FullName));
        }
    }
    private string _lastName;
    public string LastName {
        get => _lastName;
        set {
            _lastName = value;
            RaisePropertyChanged();
            RaisePropertyChanged(nameof(FullName));
        }
    }
    private string _email;
    public string Email {
        get => _email;
        set {
            _email = value;
            RaisePropertyChanged();
        }
    }
    public string FullName => $"{FirstName} {LastName}";

    private void RaisePropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}