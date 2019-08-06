using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQSort.Models
{
    public class QSortResponse 
    {
        public string Name { get; set; }
        public string Values { get; set; }
        public bool? Order { get; set; }

        public string OrderedValues { get; set; } = "";
    }
}
