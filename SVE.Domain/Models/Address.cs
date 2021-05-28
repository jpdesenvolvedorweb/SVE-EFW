using System;

namespace SVE.Domain.Models
{
    public class Address
    {
        public string PublicPlace { get; set; }

        public int? Number { get; set; }

        public string? Complement { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public char UF { get; set; }

        public string CEP { get; set; }

        public Guid IdPerson { get; set; }
    }
}
