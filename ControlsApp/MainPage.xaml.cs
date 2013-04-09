using System.Collections.ObjectModel;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlsApp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage
    {
        private ObservableCollection<Person> _persons;

        public MainPage()
        {
            InitializeComponent();

            _persons = new ObservableCollection<Person>
                {
                    new Person {LastName = "Boyko", FirstName = "Dima", Age = 21},
                    new Person {LastName = "Senatorova", FirstName = "Olga", Age = 21},
                    new Person {LastName = "Trubitsyn", FirstName = "Artem", Age = 22},
                    new Person {LastName = "Dihtyarenko", FirstName = "Vasiliy", Age = 71}, 
                    new Person {LastName = "Dihtyarenko", FirstName = "Elena", Age = 65},
                    new Person {LastName = "Gustin", FirstName = "Art", Age = 72},
                    new Person {LastName = "Huggin", FirstName = "Pat", Age = 65},
                    new Person {LastName = "Gregor", FirstName = "Luc", Age = 25},
                    new Person {LastName = "Gustin", FirstName = "Chris", Age = 45},
                    new Person {LastName = "Gustin", FirstName = "Tammy", Age = 50},
                    new Person {LastName = "Dihtyarenko", FirstName = "Vasiliy", Age = 71}, 
                    new Person {LastName = "Dihtyarenko", FirstName = "Elena", Age = 65},
                    new Person {LastName = "Rud", FirstName = "Ivan", Age = 21},
                    new Person {LastName = "Trubitsyna", FirstName = "Anna", Age = 15},
                    new Person {LastName = "Trubitsyna", FirstName = "Irina", Age = 44},
                    new Person {LastName = "Trubitsyn", FirstName = "Vladimir", Age = 45},
                    new Person {LastName = "Gregor", FirstName = "Luc", Age = 25}                    
                };

            gvMain.ItemsSource = _persons;
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные о событиях, описывающие, каким образом была достигнута эта страница.  Свойство Parameter
        /// обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
