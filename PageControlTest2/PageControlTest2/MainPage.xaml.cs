using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PageControlTest2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnNextPage.Clicked += (sender, e) =>
            {
                this.Navigation.PushAsync(new SecondPage());
            };
		}
	}
}
