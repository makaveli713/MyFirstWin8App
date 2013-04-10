using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace DownloadApp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные о событиях, описывающие, каким образом была достигнута эта страница.  Свойство Parameter
        /// обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void btnStartDownload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Адрес файла 
                var source = new Uri("http://www.адрес_файла.ru/file.dat");

                StorageFile destinationFile = await ApplicationData.Current.LocalFolder.CreateFileAsync("file.dat");

                var downloader = new BackgroundDownloader();
                DownloadOperation download = downloader.CreateDownload(source, destinationFile);

                var asyncOperation = download.StartAsync();

                var task = asyncOperation.AsTask(_cancellationTokenSource.Token, 
                    new Progress<DownloadOperation>(DownloadProgress));
            }
            catch (Exception ex)
            {
                // Обработка ошибок 
            }
        }

        private void DownloadProgress(DownloadOperation obj)
        {
            var progress = (int)(obj.Progress.BytesReceived * 100 /
            obj.Progress.TotalBytesToReceive);

            tbDownloadProgress.Text = String.Format("{0}% {1}", progress,
                                      obj.ResultFile.Name);
        }
    }
}
