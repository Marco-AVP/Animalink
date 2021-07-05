using Animalink.Business.Partners;
using Animalink.Data.Pocos.Partners;
using Animalink.WebApp.Models.Partners;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace Animalink.WebApp.Controllers
{
    public class PartnersController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> AllPartners()  
        {
            var allPartnersModel = new AllPartnersViewModel();
            var partnersBo = new PartnersBo();
            var allPartnersInfo = await partnersBo.ListAllPartners();

            foreach (var item in allPartnersInfo.Result)
            {
                if (!item.IsDeleted)
                {
                    var partnerData = new PartnerDataPoco();

                    partnerData.Name = item.Name;
                    partnerData.Description = item.Description;
                    partnerData.ImageReference = item.ImageReference;
                    partnerData.WebsiteURL = item.WebsiteURL;

                    allPartnersModel.PartnersDataPocos.Add(partnerData);
                }
            }

            return View(allPartnersModel);
        }


        [HttpPost]
        public async Task<IActionResult> AllPartners(AllPartnersViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var allPartnersModel = new AllPartnersViewModel();
                var partnersBo = new PartnersBo();
                var allPartnersInfo = await partnersBo.ListAllPartners();

                foreach (var item in allPartnersInfo.Result)
                {
                    if (!item.IsDeleted)
                    {
                        var partnerData = new PartnerDataPoco();

                        partnerData.Name = item.Name;
                        partnerData.Description = item.Description;
                        partnerData.ImageReference = item.ImageReference;
                        partnerData.WebsiteURL = item.WebsiteURL;
                    }
                }
                return View();
            }
            else
            {
                // mecanismo de alertas de erros
                return View();
            }



        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
