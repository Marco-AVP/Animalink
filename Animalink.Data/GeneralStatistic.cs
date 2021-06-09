using Animalink.Data.Base;
using Animalink.Data.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class GeneralStatistic : Entity  
    {
        [Column(TypeName = "varchar(8000)")]
        public string Statistic { get; set; }  //Json
        [Column(TypeName = "varchar(255)")]
        public string StatisticType { get; set; } 

        
        public GeneralStatistic()
        {

        }

    }
}
