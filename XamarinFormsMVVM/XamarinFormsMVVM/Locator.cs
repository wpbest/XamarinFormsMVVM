using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using XamarinFormsMVVM.Services.Person;
using XamarinFormsMVVM.Services.Person.Impl;
using XamarinFormsMVVM.ViewModel;

namespace XamarinFormsMVVM
{
    public class Locator
    {
        /// <summary>
        /// Register all the used ViewModels, Services et. al. witht the IoC Container
        /// </summary>
        public Locator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // ViewModels
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<DetailViewModel>();

            // Services
            SimpleIoc.Default.Register<IPeopleService, PeopleServiceStub>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        /// <summary>
        /// Gets the Detail property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public DetailViewModel Detail
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DetailViewModel>();
            }
        }
    }
}
