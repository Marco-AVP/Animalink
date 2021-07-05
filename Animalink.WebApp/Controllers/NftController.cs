using Animalink.Business.Nfts;
using Animalink.Data.Pocos.Nfts;
using Animalink.WebApp.Models.Nfts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace Animalink.WebApp.Controllers
{
    public class NftController : Controller
    {
        [HttpGet("Id")]
        public async Task<IActionResult> NftInfo(Guid nftId)
        {
            var nftModel = new NftViewModel();
            var allNftsBo = new TemplatesBo();
            var nftTemplateListOperation = await allNftsBo.GetFullTemplateById(nftId);
            var template = nftTemplateListOperation.Result;

                var nftTemplateData = new FullTemplateDataPoco();

                nftTemplateData.Id = template.Id;
                nftTemplateData.Name = template.Name;
                nftTemplateData.TemplateType = template.TemplateType;
                nftTemplateData.Rarity = template.Rarity;
                nftTemplateData.RarityLevel = template.RarityLevel;
                nftTemplateData.Species = template.Species;
                nftTemplateData.Taxonomy = template.Taxonomy;
                nftTemplateData.Habitat = template.Habitat;
                nftTemplateData.IUCN = template.IUCN;
                nftTemplateData.IUCNAcronym = template.IUCNAcronym;
                nftTemplateData.Schema = template.Schema;
                nftTemplateData.Collection = template.Collection;
                nftTemplateData.MaxSupply = template.MaxSupply;
                nftTemplateData.NumberAvailable = template.NumberAvailable;
                nftTemplateData.IsBurnable = template.IsBurnable;
                nftTemplateData.IsTransferable = template.IsTransferable;
                nftTemplateData.ImageReference = template.ImageReference;
                nftTemplateData.Description = template.Description;

                var value = template.Price;
                nftTemplateData.Price = Math.Round(value, 2);
                
                

                nftModel.NftDataPocos.Add(nftTemplateData);

            return View(nftModel);

        }
            
        


        [HttpPost]
        public async Task<IActionResult> ShowNftInfo(AllNftsViewModel vm, Guid nftId)
        {
            var nftModel = new NftViewModel();
            var allNftsBo = new TemplatesBo();
            var nftTemplateListOperation = await allNftsBo.GetFullTemplateById(nftId);
            var template = nftTemplateListOperation.Result;


                var nftTemplateData = new FullTemplateDataPoco();

                nftTemplateData.Id = template.Id;
                nftTemplateData.Name = template.Name;
                var value = template.Price;
                nftTemplateData.Price = Math.Round(value, 2);
                nftTemplateData.NumberAvailable = template.NumberAvailable;
                nftTemplateData.ImageReference = template.ImageReference;
                nftModel.NftDataPocos.Add(nftTemplateData);

            return View(nftModel);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
