using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlsApp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        private ObservableCollection<Person> _persons;
        private ObservableCollection<PersonGroup> _groups;
        public BlankPage1()
        {
            this.InitializeComponent();
            _persons = new ObservableCollection<Person>
                {
                    new Person {LastName = "Boyko", FirstName = "Dima", Age = 21},
                    new Person {LastName = "Senatorova", FirstName = "Olga", Age = 21, VerticalSize = 2, HorizontalSize = 2},
                    new Person {LastName = "Trubitsyn", FirstName = "Artem", Age = 22,VerticalSize = 1, HorizontalSize = 2},
                    new Person {LastName = "Dihtyarenko", FirstName = "Vasiliy", Age = 71, HorizontalSize = 1,VerticalSize = 2}, 
                    new Person {LastName = "Dihtyarenko", FirstName = "Elena", Age = 65},
                    new Person {LastName = "Gustin", FirstName = "Art", Age = 72, VerticalSize = 2, HorizontalSize = 2},
                    new Person {LastName = "Huggin", FirstName = "Pat", Age = 65},
                    new Person {LastName = "Gregor", FirstName = "Luc", Age = 25},
                    new Person {LastName = "Gustin", FirstName = "Chris", Age = 45},
                    new Person {LastName = "Gustin", FirstName = "Tammy", Age = 50},
                    new Person {LastName = "Dihtyarenko", FirstName = "Vasiliy", Age = 71}, 
                    new Person {LastName = "Dihtyarenko", FirstName = "Elena", Age = 65, VerticalSize = 2},
                    new Person {LastName = "Rud", FirstName = "Ivan", Age = 21},
                    new Person {LastName = "Trubitsyna", FirstName = "Anna", Age = 15},
                    new Person {LastName = "Trubitsyna", FirstName = "Irina", Age = 44, HorizontalSize = 2},
                    new Person {LastName = "Trubitsyn", FirstName = "Vladimir", Age = 45},
                    new Person {LastName = "Gregor", FirstName = "Luc", Age = 25}                    
                };

            _groups = new ObservableCollection<PersonGroup>();

            var developers = new PersonGroup { GroupName = "Разработчики" };
            var designers = new PersonGroup { GroupName = "Дизайнеры" };
            var managers = new PersonGroup { GroupName = "Менеджеры" };

            _groups.Add(developers);
            _groups.Add(designers);
            _groups.Add(managers);

            for (var i = 0; i < _persons.Count / 3; i++)
                developers.Persons.Add(_persons[i]);
            for (var i = _persons.Count / 3; i < 2 * (_persons.Count / 3); i++)
                designers.Persons.Add(_persons[i]);
            for (var i = 2 * (_persons.Count / 3); i < _persons.Count; i++)
                managers.Persons.Add(_persons[i]);

            cvsMain.Source = _groups;
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные о событиях, описывающие, каким образом была достигнута эта страница.  Свойство Parameter
        /// обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void GoToAnotherPage_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (MainPage));
        }
    }
}
