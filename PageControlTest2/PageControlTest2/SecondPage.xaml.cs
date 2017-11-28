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
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();

            btnNextTabPage.Clicked += (sender, e) =>
            {
                // namespaceを指定しないとiOSの方がうまくいかない？
                this.Navigation.PushAsync(new PageControlTest2.ThirdTabbedPage());
            };
		}
	}
}