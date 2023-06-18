using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class selman
    {
        public int Id { get; set; }
        public String FirstName { get; set; } =String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String FullName => $"{FirstName } {LastName.ToUpper() }";
        public int Age { get; set; }
        
    }
}