using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Shirt_shop
{
    public class TShirt : ClothingItem
    {
        public string Design { get; set; } = string.Empty;
        public string SleeveType { get; set; } = string.Empty;
        public TShirt() { }
    }
}