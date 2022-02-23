using Marked_It_Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Marked_It_Mobile.Views
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