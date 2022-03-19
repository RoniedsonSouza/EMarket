using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class AspNetUsers : IdentityUser<Guid>
    {
        public List<AspNetUserClaims> AspNetUserClaims { get; set; }
        public List<AspNetUsersRefreshToken> AspNetUsersRefreshToken { get; set; }
    }
}
