using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EtecFlix.Filmes;

namespace EtecFlix
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class inicio : ContentPage
	{
		public inicio ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Btn_f1 (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new capv());
        }

        private void F1_Clicked(object sender, EventArgs e)
        {

        }
    }
}