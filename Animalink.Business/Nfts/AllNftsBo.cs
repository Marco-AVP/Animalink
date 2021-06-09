using Animalink.Business.Base;
using Animalink.Business.OperationResults;
using Animalink.Data;
using Animalink.Data.Pocos.Nfts;
using Animalink.DataAccess;
using Animalink.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;

namespace Animalink.Business.Nfts
{
    public class AllNftsBo
    {

        #region List

        public async Task<OperationResult<List<TemplateDataPoco>>> ListTemplatesByType(string nftType)
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteOperation(async () =>
            {
                var nftTemplatesDao = new NftTemplatesDao();
                return await nftTemplatesDao.GetAllNftTemplates(nftType);
            });

        }

        public async Task<OperationResult<TemplateDataPoco>> ListTemplatesById(Guid nftId)
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteOperation(async () =>
            {
                var nftTemplatesDao = new NftTemplatesDao();
                return await nftTemplatesDao.GetNftTemplate(nftId);
            });

        }


        //---------GenericDao

        //public async Task<OperationResult<TemplateDataPoco>> GetTemplateById(Guid nftId)
        //{
        //    var genericBO = new GenericBo();

        //    return await genericBO.ExecuteOperation(async () =>
        //    {
        //        var genericDao = new GenericDao();
        //        return await genericDao.ReadAsync(nftId);
        //    });
        //}




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
