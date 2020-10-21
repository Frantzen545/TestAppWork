using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ApiService.Service;
using System.Diagnostics;
using System.Linq;

namespace Cloudingo.Views
{
    public partial class FilterDashboardPage : ContentPage
    {
        public FilterDashboardPage()
        {
            InitializeComponent();
            var service = new CloudingoService();
            var filterResult = service.GetFilters();
            filters.ItemsSource = filterResult.Filters;
        }
    }
}
