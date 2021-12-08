using System;

namespace Facade.Entity
{
    public class Buyer
    {
        public Buyer(Guid id, string firstName, string lastName, string email, Address address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}