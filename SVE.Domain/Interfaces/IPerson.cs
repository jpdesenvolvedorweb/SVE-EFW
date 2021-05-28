using System;

namespace SVE.Domain.Interfaces
{
    public interface IPerson
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public char Sex { get; set; }

        public DateTime BirthDate { get; set; }

        public Guid IdPhone { get; set; }

        public string Email { get; set; }

        public string? Document { get; set; }

        public  string? Profession { get; set; }

        public string? MaritalStatus { get; set; }

        public string Nationality { get; set; }

        public string Naturalness { get; set; }

        public string? Cnh { get; set; }

        public DateTime RegistrationDate { get; set; }
     
    }
}
