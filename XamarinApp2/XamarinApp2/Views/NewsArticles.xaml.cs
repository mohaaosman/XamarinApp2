using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp2.Models;

namespace XamarinApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsArticles : ContentPage
    {
        private HttpClient _client = new HttpClient();

        public NewsArticles()
        {
            InitializeComponent();
            GetNews();
        }

        private async void GetNews()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                // Call http
                var content = await _client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");

                var ar = JsonConvert.DeserializeObject<ObservableCollection<Article>>(content);

                ObservableCollection<Article> articles = new ObservableCollection<Article>();

                foreach (var item in ar)
                {
                    if (articles.All(a => a.Id != item.Id))
                    {
                        articles.Add(item);
                    }
                }



                articlelist.ItemsSource = articles;



            }
        }

        private void articlelist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}