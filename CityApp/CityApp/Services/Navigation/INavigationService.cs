﻿using System;
using System.Threading.Tasks;

namespace CityApp.Services
{
    public interface INavigationService
    {
        event EventHandler<bool> IsNavigatingChanged;

        event EventHandler Navigated;

        bool CanGoBack { get; }

        bool IsNavigating { get;}

        // Add Tasks to handle navigation menu
        Task NavigateToCompaniesAsync();
        Task NavigateToAccountAsync();
        Task NavigateToSettingsAsync();
        Task GoBackAsync();
    }
}
