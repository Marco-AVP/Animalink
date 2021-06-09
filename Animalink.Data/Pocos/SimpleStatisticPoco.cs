using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Pocos
{
    public class SimpleStatisticPoco <T> // converter em Json (NewTonsoft)
    {
        public T Value { get; set; } 
    }
}
