using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using Repro.ViewModels;
using Repro.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Repro
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //HomeTutor
            containerRegistry.RegisterForNavigation<HomeTutor, HomeTutorViewModel>();

            //Store
            containerRegistry.RegisterForNavigation<Store, StoreViewModel>();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("HomeTutor");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
