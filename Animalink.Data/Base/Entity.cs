using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Base
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

       

        protected Entity()
        {
            Id = Guid.NewGuid();
            UpdatedAt = DateTime.UtcNow;
            CreatedAt = DateTime.UtcNow; //?
        }
    }
}
