using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sticky_notes.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stickme_notes : ContentPage
    {
        public Stickme_notes()
        {
            InitializeComponent();
        }

        private  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var Note =  ((TappedEventArgs)e).Parameter.ToString();
            Application.Current.MainPage = new Stickme_notes_detailView(Note);
           // await Navigation.PushAsync(new Stickme_notes_detailView(Note));
        }
    }
}