using Animalink.Data.Base;
using Animalink.Data.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data
{
    public class UserStatistics : Entity
    {
        public string Statistic { get; set; } // tipo string?
        public string StatisticType { get; set; } // pode herdar Name de NamedEntity?   Necessário no construtor?


        public UserStatistics()
        {

        }
    }
}
