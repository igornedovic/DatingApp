using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppNew.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        // authentication
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
