using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repro.ViewModels
{
    class HomeTutorViewModel
    {
        INavigationService _navigationService;

        public DelegateCommand OnStoreTappedCommand { get; set; }

        public HomeTutorViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            OnStoreTappedCommand = new DelegateCommand(OnStoreTapped);
        }

        async void OnStoreTapped()
        {
            await _navigationService.NavigateAsync(new System.Uri("Store", System.UriKind.Relative), useModalNavigation: false);
            //await _navigationService.NavigateAsync("Store", useModalNavigation: false);
        }
    }
}
