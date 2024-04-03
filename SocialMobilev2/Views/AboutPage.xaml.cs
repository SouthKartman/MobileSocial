using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialMobilev2.Views
{
    public partial class AboutPage : ContentPage
    {
        private const string targetUrl = "http://192.168.0.11/shopping/adminMobile/";
        private const int refreshIntervalSeconds = 2; // Интервал обновления в секундах
        private bool errorPageShown;

        public AboutPage()
        {
            InitializeComponent();

            HttpHeadFirstQuery();



            //Scroll
            // Включаем прокрутку здесь

            ScrollView.VerticalScrollBarVisibility = ScrollBarVisibility.Always;
            ScrollView.HorizontalScrollBarVisibility = ScrollBarVisibility.Always;


            //HTTP Конструкт Запросов - реализация таймера

            if (Models.ResContainer.SharedData != null)
            {
                webview.Source = Models.ResContainer.SharedData;

                Device.StartTimer(TimeSpan.FromSeconds(refreshIntervalSeconds), () =>
                {
                    RefreshWebViewHead();
                    return true;
                });

            }
            else
            {
                webview.Source = targetUrl;

                Device.StartTimer(TimeSpan.FromSeconds(refreshIntervalSeconds), () =>
                {
                    RefreshWebViewHead();
                    return true;
                });

            }

           
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