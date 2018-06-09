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
	public partial class ProgressBarPage : ContentPage
	{
		public ProgressBarPage ()
		{
			InitializeComponent ();
		}

        private void AlterarValores(object sender, EventArgs args)
        {
            Random random = new Random();

            Bar01.Progress = random.NextDouble();

            Bar02.ProgressTo(random.NextDouble(), 3000, Easing.Linear);

            Bar03.ProgressTo(random.NextDouble(), 5000, Easing.CubicOut);
        }

    }
}