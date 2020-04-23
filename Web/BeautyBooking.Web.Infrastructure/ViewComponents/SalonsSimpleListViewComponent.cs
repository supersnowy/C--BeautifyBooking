﻿namespace BeautyBooking.Web.Infrastructure.ViewComponents
{
    using System.Threading.Tasks;

    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Web.ViewModels.Salons;
    using Microsoft.AspNetCore.Mvc;

    [ViewComponent(Name = "SalonsSimpleList")]
    public class SalonsSimpleListViewComponent : ViewComponent
    {
        private readonly ISalonsService salonsService;

        public SalonsSimpleListViewComponent(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // This is used as a Menu in Salon Manager Area
            // Now only the Admin can Add Salons and only the Manager can manage it
            // When Registering a Salon becomes option for every user, UserId (OwnerId for Salons) would be checked here
            var viewModel = new SalonsSimpleListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonSimpleViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}