using PiServControl.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PiServControl.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}