using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataModel
{
    public class ApplicationUser : IdentityUser
    {
        public string Usertype { get; set; }
    }
}
