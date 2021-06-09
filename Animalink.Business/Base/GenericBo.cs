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
        public async Task<OperationResult<T>> ExecuteOperation<T>(Func<Task<T>> func)
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
    }
}
