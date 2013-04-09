using System.Collections.ObjectModel;

namespace ControlsApp
{
    class PersonGroup
    {
        public string GroupName { get; set; }
        public ObservableCollection<Person> Persons { get; set; }

        public PersonGroup()
        {
            Persons = new ObservableCollection<Person>();
        }
    }
}
