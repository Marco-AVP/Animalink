using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Base
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; } 
        public DateTime UpdatedAt { get; private set; }
        private bool _isDeleted;

        public bool IsDeleted
        {
            get => _isDeleted;
            set
            {
                _isDeleted = value;
                OnValueChanged();
            }
        }

        protected void OnValueChanged()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        protected Entity()
        {
            Id = Guid.NewGuid();
            UpdatedAt = DateTime.UtcNow;
            CreatedAt = CreatedAt;
        }
    }
}
