using Animalink.Business.Base;
using Animalink.Business.OperationResults;
using Animalink.Data;
using Animalink.Data.Pocos.Users;
using Animalink.DataAccess;
using Animalink.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Animalink.Business.Users
{
    public class UsersBo
    {

        public async Task<OperationResult<User>> GetUserInfo(Guid userId)
        {
            var genericBO = new GenericBo();

            return await genericBO.ExecuteOperation(async () =>
            {
                var genericDao = new GenericDao();
                return await genericDao.ReadAsync<User>(userId);
            });
        }

    }
}
