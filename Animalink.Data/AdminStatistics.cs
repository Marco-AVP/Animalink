using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data
{
    public class AdminStatistics : Entity
    {
        public string Statistic { get; set; }
        public string StatisticType { get; set; }

        public AdminStatistics()
        {

        }
    }
}
