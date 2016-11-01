namespace XamarinFormsMVVM.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new XamarinFormsMVVM.App());
        }
    }
}
