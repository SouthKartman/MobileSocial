using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialMobilev2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Preloader : ContentPage
    {
        private const string targetUrl = "http://192.168.0.11/shopping/adminMobile/";
        private const int refreshIntervalSeconds = 2; // Интервал обновления в секундах
        private bool errorPageShown;

        public Preloader()
        {
            InitializeComponent();



            // Асинхронный метод для задержки и перехода к другой странице
            async Task ShowMainPageAfterDelay()
            {
                // Имитация задержки в 5 секунд
                await Task.Delay(20000);

                // Скрытие прелоадера
                preloader.IsRunning = false;

                // Переход к другой странице вашего приложения
                var MainPage = new AppShell();

                // Заменяем текущую страницу на новую
                Application.Current.MainPage = MainPage;
            }

            // Вызов метода для показа другой страницы после задержки
            ShowMainPageAfterDelay();

            RefreshWebViewHead();
            HttpHeadFirstQuery();
        }

        private async Task HttpHeadFirstQuery()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Создание объекта HttpRequestMessage для HEAD-запроса


                    if (Models.ResContainer.SharedData != null)
                    {
                        var request = new HttpRequestMessage(HttpMethod.Head, Models.ResContainer.SharedData);

                        // Отправка запроса и получение ответа
                        var response = await client.SendAsync(request);

                        // Проверка успешности запроса
                        response.EnsureSuccessStatusCode();

                        // Чтение заголовков из ответа (если это необходимо)
                        var contentTypeHeader = response.Content.Headers.ContentType;

                        // Обработка полученных данных, если это необходимо
                        // ...

                        // В данном примере просто выводим информацию в консоль
                        Console.WriteLine($"HEAD request successful. Content-Type: {contentTypeHeader}");

                        // Сброс флага об ошибке
                        errorPageShown = false;
                    }
                    else
                    {
                        var request = new HttpRequestMessage(HttpMethod.Head, targetUrl);

                        // Отправка запроса и получение ответа
                        var response = await client.SendAsync(request);

                        // Проверка успешности запроса
                        response.EnsureSuccessStatusCode();

                        // Чтение заголовков из ответа (если это необходимо)
                        var contentTypeHeader = response.Content.Headers.ContentType;

                        // Обработка полученных данных, если это необходимо
                        // ...

                        // В данном примере просто выводим информацию в консоль
                        Console.WriteLine($"HEAD request successful. Content-Type: {contentTypeHeader}");

                        // Сброс флага об ошибке
                        errorPageShown = false;
                    }




                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок и переход на другую страницу только если ошибка еще не была обработана
                if (!errorPageShown)
                {
                    Console.WriteLine($"Error refreshing WebView head: {ex.Message}");

                    // Устанавливаем флаг об ошибке, чтобы не открывать страницу снова
                    errorPageShown = true;

                    // Создаем новую страницу ошибки
                    var errorPage = new Views.ErrorPage();

                    // Заменяем текущую страницу на новую
                    Application.Current.MainPage = errorPage;
                }
            }
        }

        private async Task RefreshWebViewHead()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Создание объекта HttpRequestMessage для HEAD-запроса


                    if (Models.ResContainer.SharedData != null)
                    {
                        var request = new HttpRequestMessage(HttpMethod.Head, Models.ResContainer.SharedData);

                        // Отправка запроса и получение ответа
                        var response = await client.SendAsync(request);

                        // Проверка успешности запроса
                        response.EnsureSuccessStatusCode();

                        // Чтение заголовков из ответа (если это необходимо)
                        var contentTypeHeader = response.Content.Headers.ContentType;

                        // Обработка полученных данных, если это необходимо
                        // ...

                        // В данном примере просто выводим информацию в консоль
                        Console.WriteLine($"HEAD request successful. Content-Type: {contentTypeHeader}");

                        // Сброс флага об ошибке
                        errorPageShown = false;
                    }
                    else
                    {
                        var request = new HttpRequestMessage(HttpMethod.Head, targetUrl);

                        // Отправка запроса и получение ответа
                        var response = await client.SendAsync(request);

                        // Проверка успешности запроса
                        response.EnsureSuccessStatusCode();

                        // Чтение заголовков из ответа (если это необходимо)
                        var contentTypeHeader = response.Content.Headers.ContentType;

                        // Обработка полученных данных, если это необходимо
                        // ...

                        // В данном примере просто выводим информацию в консоль
                        Console.WriteLine($"HEAD request successful. Content-Type: {contentTypeHeader}");

                        // Сброс флага об ошибке
                        errorPageShown = false;
                    }




                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок и переход на другую страницу только если ошибка еще не была обработана
                if (!errorPageShown)
                {
                    Console.WriteLine($"Error refreshing WebView head: {ex.Message}");

                    // Устанавливаем флаг об ошибке, чтобы не открывать страницу снова
                    errorPageShown = true;

                    // Создаем новую страницу ошибки
                    var errorPage = new Views.ErrorPage();

                    // Заменяем текущую страницу на новую
                    Application.Current.MainPage = errorPage;
                }
            }


        }
    }
}