using Animalink.Business.Nfts;
using Animalink.Data.Pocos.Nfts;
using Animalink.Services;
using Animalink.WebApp.Models.Nfts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApp.Models;

namespace Animalink.WebApp.Controllers
{
    public class AllNftsController : Controller
    {
        
        [HttpGet]
        public async Task<IActionResult> ShowAllNfts(string nftType)
        {
            //var allNftsModel = new AllNftsViewModel();
            //var allNftsBo = new AllNftsBo();
            //var nftTemplatesListOperation = await  allNftsBo.ListNftTemplates(nftType);

            //foreach (var item in template)
            //{

            //        var nftTemplateData = new NftDataPoco();

            //        nftTemplateData.Id = item.Id;
            //        nftTemplateData.NftName = item.NftName;
            //        var value = item.Price;
            //        nftTemplateData.Price = Math.Round(value, 2);
            //        nftTemplateData.NumberAvailable = item.NumberAvailable;
            //        nftTemplateData.ImageReference = item.ImageReference;
            //        allNftsModel.AllNftsDataPocos.Add(nftTemplateData);

            //}


            //var atomicAssets = new AtomicAssets();
            //var result = atomicAssets.GetTemplateById("mavp4thearte", 151352);
            //var atomicAssetsData = new Root<Services.AssetData>();
            //atomicAssetsData = JsonSerializer.Deserialize<Root<Services.AssetData>>(result.Result);
            

            var allNftsModel = new AllNftsViewModel();


            //foreach (var item in atomicAssetsData.data)
            //{
            //    var nftTemplateData = new TemplateDataPoco();

            //    nftTemplateData.AtomicAssetsTemplateId = (int)Int64.Parse(item.asset_id);
            //    nftTemplateData.NftName = item.data.name;
            //    nftTemplateData.Price = 1111;
            //    nftTemplateData.NumberAvailable = Int32.Parse(item.template.max_supply) - Int32.Parse(item.template.issued_supply);
            //    nftTemplateData.ImageReference = item.data.img;
            //    allNftsModel.AllNftsDataPocos.Add(nftTemplateData);
            //}


            return View(allNftsModel);
        }


        [HttpPost]
        public async Task<IActionResult> ShowAllNfts(AllNftsViewModel vm, string nftType)
        {
            var allNftsModel = new AllNftsViewModel();
            var allNftsBo = new AllNftsBo();
            var nftTemplatesInfo = await allNftsBo.ListTemplatesByType(nftType);

            foreach (var item in nftTemplatesInfo.Result)
            {
                    var nftTemplateData = new TemplateDataPoco();

                    nftTemplateData.Id = item.Id;
                    nftTemplateData.NftName = item.NftName;
                    nftTemplateData.Price = item.Price;
                    nftTemplateData.NumberAvailable = item.NumberAvailable;
                    nftTemplateData.ImageReference = item.ImageReference;
                    allNftsModel.AllTemplatesDataPocos.Add(nftTemplateData);
            }

            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
