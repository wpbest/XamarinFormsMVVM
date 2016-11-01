namespace XamarinFormsMVVM.Windows
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
