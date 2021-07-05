using Animalink.Business.Base;
using Animalink.Business.OperationResults;
using Animalink.Data;
using Animalink.Data.Base;
using Animalink.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Animalink.Business.Partners
{
    public class PartnersBo
    {

        public async Task<OperationResult<List<Partner>>> ListAllPartners()
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteDBOperation(async () =>
            {
                var dao = new GenericDao();
                return await dao.ListAsync<Partner>();
            });
        }



    }
}
