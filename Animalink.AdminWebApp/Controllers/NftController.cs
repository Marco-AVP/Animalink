using Animalink.AdminWebApp.Models;
using Animalink.AdminWebApp.Models.Nfts;
using Animalink.Business.Nfts;
using Animalink.Data.Pocos.Nfts;
using Animalink.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Controllers
{
    public class NftController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(string nftType)
        {
            var atomicAssets = new AtomicAssets();
            var resultTemplate = atomicAssets.GetAllTemplatesInCollection("mavp4thearte");
            var atomicAssetsData = new Root<List<TemplateData>>();
            atomicAssetsData = JsonSerializer.Deserialize<Root<List<TemplateData>>>(resultTemplate.Result);
            var templatesModel = new TemplatesViewModel();

            var allNftsBo = new AllNftsBo();
            var nftTemplatesListOperation = await allNftsBo.ListTemplatesByType(nftType);

            if (!nftTemplatesListOperation.Success)
            {
                return null;
            }
            else
            {

                foreach (var item in nftTemplatesListOperation.Result)
                {

                    var templateData = new TemplateDataPoco();

                    foreach (var atomicItem in atomicAssetsData.data)
                    {
                        if ((int)Int32.Parse(atomicItem.template_id) == item.AtomicAssetsId)
                        {
                            templateData.AtomicAssetsId = (int)Int32.Parse(atomicItem.template_id);
                            if(atomicItem.MaxSupply != null && atomicItem.IssuedSupply != null)
                                templateData.NumberAvailable = atomicItem.MaxSupply.Value - atomicItem.IssuedSupply.Value;

                            templateData.Id = item.Id;
                            templateData.NftName = item.NftName;
                            templateData.Schema = item.Schema;
                            templateData.Collection = item.Collection;
                            templateData.Description = item.Description;
                            templateData.Price = item.Price;

                            templatesModel.AllTemplatesDataPocos.Add(templateData);
                        }
                    }
                }

                return View(templatesModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(TemplatesViewModel vm)
        {
            

            return View(vm);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TemplatesViewModel vm)
        {


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid templateId)
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TemplatesViewModel vm, Guid templateId)
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var allNftsBo = new AllNftsBo();
            var nftTemplatesListOperation = await allNftsBo.ListTemplatesById(id);
            var templatesModel = new TemplatesViewModel();

            if (!nftTemplatesListOperation.Success)
            {
                return null;
            }
            else
            {
                var template = nftTemplatesListOperation.Result;
                var atomicAssetsId = template.AtomicAssetsId.ToString();

                var atomicAssets = new AtomicAssets();
                var resultTemplate = atomicAssets.GetTemplateById("mavp4thearte", atomicAssetsId);
                var root = JsonSerializer.Deserialize<Root<TemplateData>>(resultTemplate.Result);
                


                var templateData = new TemplateDataPoco();

                    if (template.AtomicAssetsId == (int)Int64.Parse(root.data.template_id))
                    {
                        templateData.AtomicAssetsId = (int)Int64.Parse(root.data.template_id);
                    }

                    if (root.data.MaxSupply != null && root.data.IssuedSupply != null)
                    {
                        templateData.NumberAvailable = root.data.MaxSupply.Value - root.data.IssuedSupply.Value;
                    }

                    templateData.Id = template.Id;
                    templateData.NftName = template.NftName;
                    templateData.Schema = template.Schema;
                    templateData.Collection = template.Collection;
                    templateData.Description = template.Description;
                    templateData.Price = template.Price;
                    templateData.NftType = template.NftType;

                    templatesModel.AllTemplatesDataPocos.Add(templateData);
            }

                return View(templatesModel);
        }


        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var allNftsBo = new AllNftsBo();
            var nftTemplatesListOperation = await allNftsBo.ListTemplatesById(id);
            var templatesModel = new TemplatesViewModel();

            if (!nftTemplatesListOperation.Success)
            {
                return null;
            }

            else
            {
                var template = nftTemplatesListOperation.Result;
                var atomicAssetsId = template.AtomicAssetsId.ToString();

                var atomicAssets = new AtomicAssets();
                var resultTemplate = atomicAssets.GetTemplateById("mavp4thearte", atomicAssetsId);
                var root = JsonSerializer.Deserialize<Root<TemplateData>>(resultTemplate.Result);



                var templateData = new TemplateDataPoco();


                if (template.AtomicAssetsId == (int)Int64.Parse(root.data.template_id))
                {
                    templateData.AtomicAssetsId = (int)Int64.Parse(root.data.template_id);
                }

                if (root.data.MaxSupply != null && root.data.IssuedSupply != null)
                {
                    templateData.NumberAvailable = root.data.MaxSupply.Value - root.data.IssuedSupply.Value;
                }

                templateData.Id = template.Id;
                templateData.NftName = template.NftName;
                templateData.Schema = template.Schema;
                templateData.Collection = template.Collection;
                templateData.Description = template.Description;
                templateData.Price = template.Price;
                templateData.NftType = template.NftType;

                templatesModel.AllTemplatesDataPocos.Add(templateData);


            }
            return View(templatesModel);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }   
}
