using Animalink.AdminWebApp.Models;
using Animalink.AdminWebApp.Models.Creator;
using Animalink.AdminWebApp.Models.Templates;
using Animalink.Business.Base;
using Animalink.Business.Nfts;
using Animalink.Data;
using Animalink.Data.Context;
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
    public class TemplatesController : Controller
    {
        // test
        [HttpGet]
        public ActionResult ChosenDropDown()
        {
            AnimalinkDBContext db = new AnimalinkDBContext();

            Filters objCustomer = new Filters();
            objCustomer.GetTemplateTypeList = db.TemplateTypes.Select(x => new Filters {TemplateType = x.Name }).ToList();
            objCustomer.GetRarityList = db.Rarities.Select(x => new Filters {Rarity = x.Name }).ToList();
            objCustomer.GetSchemaList = db.Schemas.Select(x => new Filters {Schema = x.Name }).ToList();
            objCustomer.GetCollectionList = db.Collections.Select(x => new Filters {Collection = x.Name }).ToList();

            return View(objCustomer);
        }


        [HttpPost]
        public ActionResult ChosenDropDown(Filters objCustomer)
        {


            return RedirectToAction(nameof(ChosenDropDown));
        }
        //---



        #region new Index

        [HttpGet]
        public async Task<IActionResult> Index(string templateName, Guid? templateTypeId, Guid? rarityId, Guid? schemaId, Guid? collectionId)
        {
            AnimalinkDBContext db = new AnimalinkDBContext();
            var templatesModel = new TemplatesViewModel();

            templatesModel.GetTemplateNameList = db.Templates.Select(x => new TemplatesViewModel { TemplateName = x.Name }).ToList();
            templatesModel.GetTemplateTypeList = db.TemplateTypes.Select(x => new TemplatesViewModel { TemplateType = x.Name }).ToList();
            templatesModel.GetRarityList = db.Rarities.Select(x => new TemplatesViewModel { Rarity = x.Name }).ToList();
            templatesModel.GetSchemaList = db.Schemas.Select(x => new TemplatesViewModel { Schema = x.Name }).ToList();
            templatesModel.GetCollectionList = db.Collections.Select(x => new TemplatesViewModel { Collection = x.Name }).ToList();


            var atomicAssets = new AtomicAssets();
            var resultTemplate = atomicAssets.GetAllTemplatesInCollection("mavp4thearte");
            var atomicAssetsData = new Root<List<TemplateData>>();
            atomicAssetsData = JsonSerializer.Deserialize<Root<List<TemplateData>>>(resultTemplate.Result);


            var templatesBo = new TemplatesBo();
            var templatesListOperation = await templatesBo.ListFullTemplatesByFilters(templateName, templateTypeId, rarityId, schemaId, collectionId);

            if (!templatesListOperation.Success)
            {
                return null;
            }
            else
            {

                foreach (var item in templatesListOperation.Result)
                {

                    var templateData = new FullTemplateDataPoco();

                    foreach (var atomicItem in atomicAssetsData.data)
                    {
                        if ((int)Int32.Parse(atomicItem.template_id) == item.AtomicAssetsId)
                        {
                            templateData.AtomicAssetsId = (int)Int32.Parse(atomicItem.template_id);
                        }

                        if (atomicItem.MaxSupply != null && atomicItem.IssuedSupply != null)
                            templateData.NumberAvailable = atomicItem.MaxSupply.Value - atomicItem.IssuedSupply.Value;
                        }

                    templateData.Id = item.Id;
                    templateData.Name = item.Name;
                    templateData.Schema = item.Schema;
                    templateData.Collection = item.Collection;
                    templateData.Description = item.Description;
                    templateData.Price = item.Price;

                    templatesModel.AllTemplatesDataPocos.Add(templateData);
                }

                return View(templatesModel);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Index(TemplatesViewModel vm)
        {

            var atomicAssets = new AtomicAssets();
            var resultTemplate = atomicAssets.GetAllTemplatesInCollection("mavp4thearte");
            var atomicAssetsData = new Root<List<TemplateData>>();
            atomicAssetsData = JsonSerializer.Deserialize<Root<List<TemplateData>>>(resultTemplate.Result);

            var templatesModel = new TemplatesViewModel();

            var templatesBo = new TemplatesBo();
            var templatesListOperation = await templatesBo.ListFullTemplatesByFilters(vm.TemplateName, vm.TemplateTypeId, vm.RarityId, vm.SchemaId, vm.CollectionId);

            if (!templatesListOperation.Success)
            {
                return null;
            }
            else
            {

                foreach (var item in templatesListOperation.Result)
                {

                    var templateData = new FullTemplateDataPoco();

                    var atomicItem = atomicAssetsData.data.SingleOrDefault(i => Int32.Parse(i.template_id) == item.AtomicAssetsId);
                    if (atomicItem == null) continue;

                    templateData.AtomicAssetsId = (int)Int32.Parse(atomicItem.template_id);

                    if (atomicItem.MaxSupply != null && atomicItem.IssuedSupply != null)
                    {
                        templateData.NumberAvailable = atomicItem.MaxSupply.Value - atomicItem.IssuedSupply.Value;
                    }

                    templateData.Id = item.Id;
                    templateData.Name = item.Name;
                    templateData.Schema = item.Schema;
                    templateData.Collection = item.Collection;
                    templateData.Description = item.Description;
                    templateData.Price = item.Price;

                    templatesModel.AllTemplatesDataPocos.Add(templateData);

                }

                return View(templatesModel);
            }
        }


        #endregion


        #region old Index------

        //[HttpGet]
        //public async Task<IActionResult> Index(string nftType)
        //{
        //    var atomicAssets = new AtomicAssets();
        //    var resultTemplate = atomicAssets.GetAllTemplatesInCollection("mavp4thearte");
        //    var atomicAssetsData = new Root<List<TemplateData>>();
        //    atomicAssetsData = JsonSerializer.Deserialize<Root<List<TemplateData>>>(resultTemplate.Result);
        //    var templatesModel = new TemplatesViewModel();

        //    var templatesBo = new TemplatesBo();
        //    var templatesListOperation = await templatesBo.ListFullTemplatesByType(nftType);

        //    if (!templatesListOperation.Success)
        //    {
        //        return null;
        //    }
        //    else
        //    {

        //        foreach (var item in templatesListOperation.Result)
        //        {

        //            var templateData = new FullTemplateDataPoco();

        //            foreach (var atomicItem in atomicAssetsData.data)
        //            {
        //                if ((int)Int32.Parse(atomicItem.template_id) == item.AtomicAssetsId)
        //                {
        //                    templateData.AtomicAssetsId = (int)Int32.Parse(atomicItem.template_id);
        //                    if(atomicItem.MaxSupply != null && atomicItem.IssuedSupply != null)
        //                        templateData.NumberAvailable = atomicItem.MaxSupply.Value - atomicItem.IssuedSupply.Value;

        //                    templateData.Id = item.Id;
        //                    templateData.Name = item.Name;
        //                    templateData.Schema = item.Schema;
        //                    templateData.Collection = item.Collection;
        //                    templateData.Description = item.Description;
        //                    templateData.Price = item.Price;

        //                    templatesModel.AllTemplatesDataPocos.Add(templateData);
        //                }
        //            }
        //        }

        //        return View(templatesModel);
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> Index(TemplatesViewModel searchByObj)
        //{
        //    var search = searchByObj.SearchBy[1];

        //    var atomicAssets = new AtomicAssets();
        //    var resultTemplate = atomicAssets.GetAllTemplatesInCollection("mavp4thearte");
        //    var atomicAssetsData = new Root<List<TemplateData>>();
        //    atomicAssetsData = JsonSerializer.Deserialize<Root<List<TemplateData>>>(resultTemplate.Result);
        //    var templatesModel = new TemplatesViewModel();

        //    var templatesBo = new TemplatesBo();
        //    var templatesListOperation = await templatesBo.GetFullTemplatesByName(search);

        //    if (!templatesListOperation.Success)
        //    {
        //        return null;
        //    }
        //    else
        //    {

        //        foreach (var item in templatesListOperation.Result)
        //        {

        //            var templateData = new FullTemplateDataPoco();

        //            var atomicItem = atomicAssetsData.data.SingleOrDefault(i => Int32.Parse(i.template_id) == item.AtomicAssetsId);
        //            if (atomicItem == null) continue;

        //            templateData.AtomicAssetsId = (int)Int32.Parse(atomicItem.template_id);
        //            if (atomicItem.MaxSupply != null && atomicItem.IssuedSupply != null)
        //                templateData.NumberAvailable = atomicItem.MaxSupply.Value - atomicItem.IssuedSupply.Value;

        //            templateData.Id = item.Id;
        //            templateData.Name = item.Name;
        //            templateData.Schema = item.Schema;
        //            templateData.Collection = item.Collection;
        //            templateData.Description = item.Description;
        //            templateData.Price = item.Price;

        //            templatesModel.AllTemplatesDataPocos.Add(templateData);


        //        }

        //        return View(templatesModel);
        //    }
        //}

        #endregion


        #region Creator Page

        #region Index
        [HttpGet]
        public async Task<IActionResult> CreatorPage()
        {
            return View();
        }

        #endregion


        #region Create Template

        [HttpGet]
        public async Task<IActionResult> CreateTemplate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTemplate(EditTemplateViewModel vm)
        {

            if (ModelState.IsValid)
            {
                var templatesBo = new TemplatesBo();
                //var getTemplateOperation = await templatesBo.GetTemplate(vm.TemplateId);

                //if (!getTemplateOperation.Success)
                //{
                //    return null;
                //}
                //if (getTemplateOperation.Result == null)
                //{
                //    return NotFound();
                //}

                //else
                //{
                //    var template = new NftTemplate();
                //    var dBTemplate = getTemplateOperation.Result;

                //    vm.ToNftTemplate(dBTemplate);

                //    var updateOperation = await templatesBo.CreateTemplate(dBTemplate);
                //    if (!updateOperation.Success) return View("Error", new ErrorViewModel() { RequestId = updateOperation.Exception.Message });
                //}

                var template = new Data.Template();

                vm.ToTemplate(template);

                var updateOperation = await templatesBo.CreateTemplate(template);
                if (!updateOperation.Success) return View("Error", new ErrorViewModel() { RequestId = updateOperation.Exception.Message });

            }

            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region Add Animal

        [HttpGet]
        public async Task<IActionResult> AddAnimal()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAnimal(AnimalViewModel vm)
        {

            if (ModelState.IsValid)
            {
                var templatesBo = new TemplatesBo();
                
                var animal = new Data.Animal();

                vm.ToAnimal(animal);

                var updateOperation = await templatesBo.CreateAnimal(animal);
                if (!updateOperation.Success) return View("Error", new ErrorViewModel() { RequestId = updateOperation.Exception.Message });

            }

            return RedirectToAction(nameof(CreatorPage));
        }

        #endregion


        #region Add TemplateType
        [HttpGet]
        public async Task<IActionResult> AddTemplateType()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTemplateType(TemplateTypeViewModel vm)
        {

            if (ModelState.IsValid)
            {
                var templatesBo = new TemplatesBo();

                var templateType = new Data.TemplateType();

                vm.ToTemplateType(templateType);

                var updateOperation = await templatesBo.CreateTemplateType(templateType);
                if (!updateOperation.Success) return View("Error", new ErrorViewModel() { RequestId = updateOperation.Exception.Message });

            }

            return RedirectToAction(nameof(CreatorPage));
        }
        #endregion


        #region Add Rarity

        #endregion


        #region Add Schema

        #endregion


        #region Add Collection

        #endregion


        #endregion



        #region Edit
        [HttpGet]
        public async Task<IActionResult> Edit(Guid Id)
        {
            if (Id == null) return NotFound();
            var templatesBo = new TemplatesBo();
            var getTemplateOperation = await templatesBo.GetFullTemplateById(Id);

            if (!getTemplateOperation.Success) return null;

            if (getTemplateOperation.Result == null) return NotFound();

            var dBtemplate = getTemplateOperation.Result;

            var templateModel = new EditTemplateViewModel();
            templateModel.FromFullTemplate(dBtemplate);

            return View(templateModel);
        }


        //http get é para apresentar o formulário
        //http post é para receber os dados submetidos
        //http post só recebe o viewmodel como parâmetro
        //qualquer id que queiras guardar entre get e post, deve ser renderizado na view como hidden field
        //e deves ter a propriedade no view model para esse id

        [HttpPost]
        public async Task<IActionResult> Edit(EditTemplateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var templatesBo = new TemplatesBo();
                var getTemplateOperation = await templatesBo.GetTemplate(vm.TemplateId);

                if (!getTemplateOperation.Success)
                {
                    return null;
                }
                if (getTemplateOperation.Result == null)
                {
                    return NotFound();
                }

                else 
                {
                    var dBTemplate = getTemplateOperation.Result;

                    vm.ToTemplate(dBTemplate);

                    var updateOperation = await templatesBo.UpdateTemplate(dBTemplate);
                    if (!updateOperation.Success) return View("Error", new ErrorViewModel() { RequestId = updateOperation.Exception.Message });
                }
            }

            return RedirectToAction(nameof(Index));
        }

        #endregion


        #region Delete
        //[HttpPost]
        //public async Task<IActionResult> Delete(EditTemplateViewModel vm)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var templatesBo = new TemplatesBo();
        //        var getTemplateOperation = await templatesBo.GetTemplate(vm.TemplateId);

        //        if (!getTemplateOperation.Success)
        //        {
        //            return null;
        //        }
        //        if (getTemplateOperation.Result == null)
        //        {
        //            return NotFound();
        //        }

        //        else
        //        {
        //            var dBTemplate = getTemplateOperation.Result;

        //            vm.ToNftTemplate(dBTemplate);

        //            var updateOperation = await templatesBo.UpdateTemplate(dBTemplate);
        //            if (!updateOperation.Success) return View("Error", new ErrorViewModel() { RequestId = updateOperation.Exception.Message });
        //        }
        //    }

        //    return RedirectToAction(nameof(Index));
        //}

        #endregion


        #region Details
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var templatesBo = new TemplatesBo();
            var templateOperation = await templatesBo.GetFullTemplateById(id);
            var templateModel = new DetailsTemplateViewModel();

            if (!templateOperation.Success)
            {
                return null;
            }

            else
            {
                var dBtemplate = templateOperation.Result;
                var atomicAssetsId = dBtemplate.AtomicAssetsId.ToString();

                var atomicAssets = new AtomicAssets();
                var resultTemplate = atomicAssets.GetTemplateById("mavp4thearte", atomicAssetsId);
                var root = JsonSerializer.Deserialize<Root<TemplateData>>(resultTemplate.Result);



                if (dBtemplate.AtomicAssetsId == (int)Int64.Parse(root.data.template_id))
                {
                    templateModel.TemplateDataPoco.AtomicAssetsId = (int)Int64.Parse(root.data.template_id);
                }

                if (root.data.MaxSupply != null && root.data.IssuedSupply != null)
                {
                    templateModel.TemplateDataPoco.NumberAvailable = root.data.MaxSupply.Value - root.data.IssuedSupply.Value;
                }

                templateModel.TemplateDataPoco.Id = dBtemplate.Id;
                templateModel.TemplateDataPoco.Name = dBtemplate.Name;
                templateModel.TemplateDataPoco.Schema = dBtemplate.Schema;
                templateModel.TemplateDataPoco.Collection = dBtemplate.Collection;
                templateModel.TemplateDataPoco.Description = dBtemplate.Description;
                templateModel.TemplateDataPoco.Price = dBtemplate.Price;
                templateModel.TemplateDataPoco.TemplateType = dBtemplate.TemplateType;

            }
            return View(templateModel);

        }
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }   
}
