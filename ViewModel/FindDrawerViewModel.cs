using FinalProject_201810088.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_201810088.ViewModel
{
    public class FindDrawerViewModel
    {
        //Find By
        public String Name { get; set; }
        public String EmailAddress { get; set; }
        public String PhoneNumber { get; set; }
        public double? CostPerManga { get; set; }

        //Navigation
        public ICollection<Work> Works { get; set; }

        //Result
        public IEnumerable<Drawer> Drawers { get; set; }
    }
}
