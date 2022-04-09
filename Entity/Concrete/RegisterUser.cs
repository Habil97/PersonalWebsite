using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class RegisterUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImageURL { get; set; }
    }
}
