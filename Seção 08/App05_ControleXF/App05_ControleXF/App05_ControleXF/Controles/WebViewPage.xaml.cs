using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}

        public void GoPage(object sender, EventArgs args)
        {
            webNavegador.Source = EnderecoSite.Text;
        }

        public void GoNext(object sender, EventArgs args)
        {
            if (webNavegador.CanGoForward)
            {
                webNavegador.GoForward();
            }
        }

        public void GoBack(object sender, EventArgs args)
        {
            if (webNavegador.CanGoBack)
            {
                webNavegador.GoBack();
            }
        }

        public void ActionLoading(object sender, EventArgs args)
        {
            lblStatus.Text = "Loading...";
        }

        public void ActionLoaded(object sender, EventArgs args)
        {
            lblStatus.Text = "Loaded!";
        }
	}
}