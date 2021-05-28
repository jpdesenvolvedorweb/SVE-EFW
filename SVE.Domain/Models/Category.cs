using System;

namespace SVE.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public bool Active { get; set; }
        
        public DateTime DateRegister { get; set; }

        public DateTime Deactivation { get; set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}
