using Animalink.Data.Pocos.Nfts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Pocos.Users
{
    public class UserDataPoco  // used to present the stats in presentation
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string ImageReference { get; set; }
        public List<SaleDataPoco> NftsOwned { get; set; }

    }
}
