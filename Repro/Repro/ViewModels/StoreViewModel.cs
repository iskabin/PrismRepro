using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repro.ViewModels
{
    class StoreViewModel
    {
        INavigationService _navigationService;

        IPageDialogService _pageDialogService;

        public DelegateCommand OnBackTappedCommand { get; set; }

        public StoreViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;

            _pageDialogService = pageDialogService;

            OnBackTappedCommand = new DelegateCommand(OnBackTapped);
        }

        async void OnBackTapped()
        {
            await _pageDialogService.DisplayAlertAsync("Back Tapped", _navigationService.GetNavigationUriPath() ,"Ok");
            //await _navigationService.GoBackAsync(useModalNavigation:false);
            await _navigationService.NavigateAsync("../", useModalNavigation: false);
        }
    }
}
