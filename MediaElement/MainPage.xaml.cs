using Xamarin.Forms;

namespace MediaElement
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnAppearing(object sender, System.EventArgs e)
        {
            base.OnAppearing();
            ((MainViewModel)BindingContext).OnAppearing();
        }

        void ContentPage_Disappearing(System.Object sender, System.EventArgs e)
        {
            base.OnDisappearing();
            ((MainViewModel)BindingContext).Disappearing();

        }
    }
}
