using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string ImageReference { get; set; }

    }
}
