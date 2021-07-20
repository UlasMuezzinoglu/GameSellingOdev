using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingOdev.Entities
{
    class Player
    {
        public Player()
        {

        }
        public Player(int id, string firstName, string lastName, string identityNumber, string email, string password, string phoneNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdentityNumber = identityNumber;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
