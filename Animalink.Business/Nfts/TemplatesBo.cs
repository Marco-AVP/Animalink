using Animalink.Business.Base;
using Animalink.Business.OperationResults;
using Animalink.Data;
using Animalink.Data.Pocos.Nfts;
using Animalink.DataAccess;
using Animalink.DataAccess.Base;
using Animalink.Services;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace Animalink.Business.Nfts
{
    public class TemplatesBo
    {

        #region List

        public async Task<OperationResult<List<FullTemplateDataPoco>>> ListFullTemplatesByFilters(string templateName, Guid? templateTypeId, Guid? rarityId, Guid? schemaId, Guid? collectionId)
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteDBOperation(async () =>
            {
                var nftTemplatesDao = new TemplatesDao();
                return await nftTemplatesDao.GetAllFullTemplatesByFilters(templateName, templateTypeId, rarityId, schemaId, collectionId);
            });
        }

        public async Task<OperationResult<List<FullTemplateDataPoco>>> GetFullTemplatesByName(string templateName)
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteDBOperation(async () =>
            {
                var nftTemplatesDao = new TemplatesDao();
                return await nftTemplatesDao.GetAllFullTemplatesByName(templateName);
            });
        }


        public async Task<OperationResult<FullTemplateDataPoco>> GetFullTemplateById(Guid nftId)
        {
            var genericBO = new GenericBo();
            var templateData = new FullTemplateDataPoco();


            var opResult = await genericBO.ExecuteDBOperation(async () =>
            {
                var nftTemplatesDao = new TemplatesDao();
                return await nftTemplatesDao.GetFullTemplateById(nftId);
            });

            if (!opResult.Success) return opResult;

            

            var serviceResult = await genericBO.ExecuteProtectedOperation(async () =>
            {
                var dBtemplate = opResult.Result;
                var atomicAssetsId = dBtemplate.AtomicAssetsId.ToString();

                var atomicAssets = new AtomicAssets();
                var resultTemplate = await atomicAssets.GetTemplateById("mavp4thearte", atomicAssetsId);
                var root = JsonSerializer.Deserialize<Root<TemplateData>>(resultTemplate);


                if (dBtemplate.AtomicAssetsId == (int)Int64.Parse(root.data.template_id))
                {
                    templateData.AtomicAssetsId = (int)Int64.Parse(root.data.template_id);
                }

                if (root.data.MaxSupply != null && root.data.IssuedSupply != null)
                {
                    templateData.NumberAvailable = root.data.MaxSupply.Value - root.data.IssuedSupply.Value;
                }

                templateData.Id = dBtemplate.Id;

                templateData.Name = dBtemplate.Name;
                templateData.Schema = dBtemplate.Schema;
                templateData.Collection = dBtemplate.Collection;
                templateData.Description = dBtemplate.Description;
                templateData.Price = dBtemplate.Price;
                templateData.TemplateType = dBtemplate.TemplateType;
                templateData.Rarity = dBtemplate.Rarity;
                templateData.RarityLevel = dBtemplate.RarityLevel;
                templateData.MaxSupply = dBtemplate.MaxSupply;
                templateData.ImageReference = dBtemplate.ImageReference;
                templateData.IsDeleted = dBtemplate.IsDeleted;
                templateData.IsBurnable = dBtemplate.IsBurnable;
                templateData.IsPublished = dBtemplate.IsPublished;
                templateData.IsTransferable = dBtemplate.IsTransferable;

                return templateData;
            });

            return serviceResult;
        }


        // criar Dao para Animal, usar TemplateViewModel no controller, buscar template que quero fazer update na DB e alterar os dados que quero,
        // mandar o nftTemplate de volta para a DB com os updates

        //---------GenericDao..... 


        public async Task<OperationResult<Data.Template>> GetTemplate(Guid id)
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteDBOperation(async () =>
            {
                var genericDao = new GenericDao();
                return await genericDao.ReadAsync<Data.Template>(id);
            });

        }

        public async Task<OperationResult> UpdateTemplate(Data.Template nftTemplate)
        {

            var genericBo = new GenericBo();

            return await genericBo.ExecuteDBOperation(async () =>
            {
                var genericdao = new GenericDao();
                await genericdao.UpdateAsync<Data.Template>(nftTemplate);
            });
        }

        public async Task<OperationResult> CreateTemplate(Data.Template nftTemplate)
        {

            var genericBo = new GenericBo();

            return await genericBo.ExecuteDBOperation(async () =>
            {
                var genericdao = new GenericDao();
                await genericdao.CreateAsync<Data.Template>(nftTemplate);
            });
        }


        public async Task<OperationResult> CreateAnimal(Data.Animal animal)
        {

            var genericBo = new GenericBo();

            return await genericBo.ExecuteDBOperation(async () =>
            {
                var genericdao = new GenericDao();
                await genericdao.CreateAsync<Data.Animal>(animal);
            });
        }


        public async Task<OperationResult> CreateTemplateType(Data.TemplateType templateType)
        {

            var genericBo = new GenericBo();

            return await genericBo.ExecuteDBOperation(async () =>
            {
                var genericdao = new GenericDao();
                await genericdao.CreateAsync<Data.TemplateType>(templateType);
            });
        }


        // Use Cases

        //public async Task<OperationResult<List<NftTemplate>>> ListAllNftTemplatesAsync()  // generic
        //{
        //    var genericBO = new GenericBo();

        //    return await genericBO.ExecuteOperation(async () =>
        //    {
        //        var dao = new GenericDao();
        //        return await dao.ListAsync<NftTemplate>();
        //    });



        //    #region Generic/Non Generic exemples

        //    // --- Ex Utilização Lambda por extenso 

        //    //Func<Task<List<NftTemplate>>> funcaoLambda = async () =>
        //    //{
        //    //    var dao = new GenericDao();
        //    //    return await dao.ListAsync<NftTemplate>();
        //    //};
        //    //return await genericBO.ExecuteOperation(funcaoLambda);



        //    // --- Ex utilização não generico 

        //    //try
        //    //{
        //    //    var transactionOptions = new TransactionOptions
        //    //    {
        //    //        IsolationLevel = IsolationLevel.ReadCommitted,
        //    //        Timeout = TimeSpan.FromSeconds(30)
        //    //    };
        //    //    using (var ts = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
        //    //    {
        //    //        var dao = new GenericDao();
        //    //        var result = await dao.ListAsync<NftTemplate>();
        //    //        ts.Complete();
        //    //        return new OperationResult<List<NftTemplate>>() { Success = true, Result = result };
        //    //    }
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    return new OperationResult<List<NftTemplate>>() { Success = false, Exception = e };
        //    //}

        //    #endregion
        //}

        #endregion

    }
}
