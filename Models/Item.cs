using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace SleingList.Models
{
    public class Item
    {
        public string? Nome{ get ; set; }
        public int PrecoUnidade{ get; set; }	
        public int Quantidade{ get; set; }
    }
}