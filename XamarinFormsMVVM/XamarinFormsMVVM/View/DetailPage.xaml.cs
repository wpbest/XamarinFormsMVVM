using Xamarin.Forms;
using XamarinFormsMVVM.Model;

namespace XamarinFormsMVVM.View
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Person person)
        {
            InitializeComponent();
            var viewModel = App.Locator.Detail;
            viewModel.Person = person;

            BindingContext = viewModel;

            viewModel.ClickMeCallBackAction = () => DisplayAlert("Hello", viewModel.Person.FullName, "Ok");
        }
    }
}
