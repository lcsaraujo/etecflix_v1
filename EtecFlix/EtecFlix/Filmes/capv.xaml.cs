using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Filmes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class capv : ContentPage
	{
		public capv ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
		}

        private async void Btn_voltar(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
	}
}