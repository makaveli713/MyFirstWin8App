﻿using System;
using System.Collections.ObjectModel;
using Windows.Foundation;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace Art713.Win8App
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage
    {
        public ObservableCollection<Person> Persons { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Persons = new ObservableCollection<Person>();
            DataContext = this;
            var ivanov = new Person
                {
                    LastName = "Иванов",
                    FirstName = "Иван",
                    Email = "ivan.ivanov@foo.com"
                };
                Persons.Add(ivanov);
            var petrov = new Person {LastName = "Петров", FirstName = "Петр", Email = "petr.petrov@foo.com"};
            Persons.Add(petrov); 
 
        var sidorov = new Person {LastName = "Сидоров", FirstName = "Сергей", Email = "sergey.sidorov@foo.com"};
            Persons.Add(sidorov); 
                
            var person = new Person
                {
                    FirstName = "Artem",
                    LastName = "Trubitsyn",
                    Email = "cherubim713@gmail.com"
                };
            Persons.Add(person);

            //spPerson.DataContext = person;
            //person.Email = "1171913@mail.ru";
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные о событиях, описывающие, каким образом была достигнута эта страница.  Свойство Parameter
        /// обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new MessageDialog("Hello, world", "Greeting");
            //dlg.ShowAsync();
            
            dlg.Commands.Add(new UICommand("Комманда 1", parameters => 
            {
                //
            }));
            dlg.Commands.Add(new UICommand("Комманда 2"));
            dlg.Commands.Add(new UICommand("Комманда 3"){Id = 3});

            dlg.DefaultCommandIndex = 1;
            dlg.CancelCommandIndex = 2;

            await dlg.ShowAsync();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (SecondPage),"string parameter");
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof (SecondPage));
            var ui = new CameraCaptureUI();
            ui.PhotoSettings.CroppedAspectRatio = new Size(16,9);

            var file = await ui.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (file!=null)
            {
                var bitmap = new BitmapImage();

                bitmap.SetSource(await file.OpenAsync(FileAccessMode.Read));
                Photo.Source = bitmap;
            }
        }
    }
}
