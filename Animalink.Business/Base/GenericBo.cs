using Animalink.Business.OperationResults;
using Animalink.Data.Base;
using Animalink.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Animalink.Business.Base
{
    public class GenericBo
    {
        public async Task<OperationResult<T>> ExecuteDBOperation<T>(Func<Task<T>> func)
        {
            try
            {
                var transactionOptions = new TransactionOptions
                {
                    IsolationLevel = IsolationLevel.ReadCommitted,
                    Timeout = TimeSpan.FromSeconds(30)
                };
                using (var ts = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    var result = await func.Invoke();
                    ts.Complete();
                    return new OperationResult<T>() { Result = result, Success = true };
                }
            }
            catch (Exception ex)
            {
                return new OperationResult<T>() { Success = false, Exception = ex };
            }
        }

        public async Task<OperationResult> ExecuteDBOperation(Func<Task> func)
        {
            try
            {
                var transactionOptions = new TransactionOptions
                {
                    IsolationLevel = IsolationLevel.ReadCommitted,
                    Timeout = TimeSpan.FromSeconds(30)
                };
                using (var ts = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    await func.Invoke();
                    ts.Complete();
                    return new OperationResult() { Success = true };
                }
            }
            catch (Exception ex)
            {
                return new OperationResult() { Success = false, Exception = ex };
            }
        }

        public async Task<OperationResult<T>> ExecuteProtectedOperation<T>(Func<Task<T>> func)
        {
            try
            {
                var result = await func.Invoke();
                return new OperationResult<T>() { Result = result, Success = true };

            }
            catch (Exception ex)
            {
                return new OperationResult<T>() { Success = false, Exception = ex };
            }
        }


        public async Task<OperationResult<T>> GetTemplate<T>(Guid id) where T : Entity
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteDBOperation(async () =>
            {
                var genericDao = new GenericDao();
                return await genericDao.ReadAsync<T>(id);
            });

        }


        public async Task<OperationResult> UpdateAsync<T>(T item) where T : Entity
        {
            return await ExecuteDBOperation(async () =>
            {
                var genericdao = new GenericDao();
                await genericdao.UpdateAsync(item);
            });
        }

    }
}
