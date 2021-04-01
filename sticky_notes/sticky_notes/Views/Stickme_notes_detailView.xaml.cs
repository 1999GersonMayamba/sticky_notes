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
    public partial class Stickme_notes_detailView : ContentPage
    {
        public Stickme_notes_detailView()
        {
            InitializeComponent();
        }

        public Stickme_notes_detailView(string note)
        {
            InitializeComponent();
            Note.Text = note;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Stickme_notes();
        }
    }
}