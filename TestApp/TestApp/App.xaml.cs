using Prism.Unity;
using TestApp.Views;
using Xamarin.Forms;

namespace TestApp
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("NavigationPage/MainTabbedPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainTabbedPage>();
			Container.RegisterTypeForNavigation<MySecondTabbedPage>();
		}
	}
}
