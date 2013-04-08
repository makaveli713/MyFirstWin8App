using System.ComponentModel;
using System.Runtime.CompilerServices;
using Art713.Win8App.Annotations;

namespace Art713.Win8App
{
    class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _email;

        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyChanged("FirstName"); } }
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChanged("LastName"); } }
        public string Email { get { return _email; } set { _email = value; OnPropertyChanged("Email"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
