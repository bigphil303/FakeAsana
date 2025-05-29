using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asana.Library.Models
{
    public class ToDo
    {
        private string? Name { get; set; }
        private string? Description { get; set;}
        private int? Priority { get; set; }
        private bool? IsCompleted { get; set; }

        public ToDo()
        {

        }
    }
}


