using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterPage
{
    public partial class Outra : ContentPage
    {
        public Outra()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Titulo", "Message", "OK");
        }
    }
}
