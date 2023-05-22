using Microsoft.AspNetCore.Identity;

namespace ParfumeriaJasmin.Data
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
