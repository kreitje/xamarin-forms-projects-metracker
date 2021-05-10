using System;
using MeTracker.Repositories;
using MeTracker.Services;
using Xamarin.Essentials;

namespace MeTracker.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly ILocationTrackingService locationTrackingService;
        private readonly ILocationRepository locationRepository;


        public MainViewModel(ILocationTrackingService locationTrackingService, ILocationRepository locationRepository)
        {
            this.locationTrackingService = locationTrackingService;
            this.locationRepository = locationRepository;

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                locationTrackingService.StartTracking();
            });
        }
    }
}
