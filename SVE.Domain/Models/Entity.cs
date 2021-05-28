using System;

namespace SVE.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public abstract bool IsValid();
    }
}
