using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab_Vahed.Dto
{
    public class User
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Term { get; set; }
        public string? Major { get; set; }
        public string? Lesson { get; set; }
    }
}
