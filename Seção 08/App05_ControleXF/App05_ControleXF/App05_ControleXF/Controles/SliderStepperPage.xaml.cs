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
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}

        private void ActionValueChangedSlider(object sender, ValueChangedEventArgs args)
        { 
            lblValorSlider.Text = args.NewValue.ToString();
        }

        private void ActionValueChangedStepper(object sender, ValueChangedEventArgs args)
        {
            lblValorStepper.Text = args.NewValue.ToString();
        }
    }
}