using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.ViewModels
{
	public class MainTabbedPageViewModel : BindableBase
	{
		INavigationService _navigationService;

		public DelegateCommand NavigateToACommand { get; set; }
		public MainTabbedPageViewModel(INavigationService navigationService)
		{
			//our prism services
			_navigationService = navigationService;

			NavigateToACommand = new DelegateCommand(NavigateToA);
		}

		void NavigateToA()
		{
			_navigationService.NavigateAsync("MySecondTabbedPage", useModalNavigation: true);
		}
	}
}
