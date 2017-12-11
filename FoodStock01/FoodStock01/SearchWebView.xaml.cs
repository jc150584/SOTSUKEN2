using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchWebView : WebView
	{
		public SearchWebView ()
		{
            new UrlWebViewSource
            {
                Url = "https://cookpad.com/search/",
            };
        }
    }
}