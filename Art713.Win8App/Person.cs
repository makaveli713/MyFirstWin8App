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

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value; 
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get 
            {
                return _lastName; 
            } 
            set
            {
                _lastName = value; 
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get
            {
                return _email;
            } 
            set
            {
                _email = value; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
