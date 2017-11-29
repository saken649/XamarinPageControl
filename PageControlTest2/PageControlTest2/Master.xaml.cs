using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageControlTest2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            //var menu = new[] { "main", "ぱんつのあほー？", "Tabbed", "Carousel" };
            //ListView listView = new ListView
            //{
            //    ItemsSource = menu,
            //    BackgroundColor = Color.AliceBlue,
            //};

            //Master = new ContentPage
            //{
            //    BackgroundColor = Color.Aquamarine,
            //    Padding = new Thickness(0, 20, 0, 0),
            //    Title = "menu",
            //    Content = listView
            //};

            //Detail = new NavigationPage(new MainPage());
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}