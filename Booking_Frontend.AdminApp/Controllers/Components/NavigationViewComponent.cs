using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Frontend.AdminApp.Models;
using Booking_Frontend.APIIntegration.Language;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly ILanguageClientService _languageClientService;

        public NavigationViewComponent(ILanguageClientService languageClientService)
        {
            _languageClientService = languageClientService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageClientService.GetAllLanguage();
            var navigationViewModel = new NavigationViewModel()
            {
                CurrentLanguageId = HttpContext.Session.GetString("DefaultLanguageId"),
                Languages = languages.ResultOject
            };
            return View("Default", navigationViewModel);
        }
    }
}