using Microsoft.AspNetCore.Identity;

namespace DotnetWebCore.Identity.Data.Entities
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
        [PersonalData]
        public DateTime BirthDate { get; set; }
    }
}
