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
    public partial class ThirdTabbedPage : TabbedPage
    {
        public ThirdTabbedPage ()
        {
            InitializeComponent();

            btnNextCarouselPage.Clicked += (sender, e) =>
            {
                this.Navigation.PushAsync(new PageControlTest2.FourthCarouselPage());
            };
        }
    }
}