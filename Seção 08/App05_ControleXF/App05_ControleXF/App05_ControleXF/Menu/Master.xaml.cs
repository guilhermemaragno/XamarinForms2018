using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoToActivityIndicatorPage (object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ActivityIndicatorPage());
            IsPresented = false;
        }

        private void GoToProgressBarPage (object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ProgressBarPage());
            IsPresented = false;
        }

        private void GoToBoxViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.BoxViewPage());
            IsPresented = false;
        }

        private void GoToLabelPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.LabelPage());
            IsPresented = false;
        }

        private void GoToButtonPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ButtonPage());
            IsPresented = false;
        }

        private void GoToEntryEditorPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.EntryEditorPage());
            IsPresented = false;
        }

        private void GoToDatePickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.DatePickerPage());
            IsPresented = false;
        }

        private void GoToTimePickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TimePickerPage());
            IsPresented = false;
        }

        private void GoToPickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.PickerPage());
            IsPresented = false;
        }

        private void GoToSearchBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SearchBarPage());
            IsPresented = false;
        }

        private void GoToSliderStepperPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SliderStepperPage());
            IsPresented = false;
        }

        private void GoToSwitchPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SwitchPage());
            IsPresented = false;
        }

        private void GoToImagePage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ImagePage());
            IsPresented = false;
        }

        private void GoToListViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ListViewPage());
            IsPresented = false;
        }

        private void GoToTableViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TableViewPage());
            IsPresented = false;
        }

        private void GoToWebViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.WebViewPage());
            IsPresented = false;
        }


    }
}