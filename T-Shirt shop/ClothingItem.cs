using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Shirt_shop
{

        public class ClothingItem
        {
            public string Name { get; set; } = string.Empty;
            public decimal Price { get; set; } = decimal.Zero;
            public string Size { get; set; } = string.Empty;
            public string Material { get; set; } = string.Empty;
            public ClothingItem() { }
        }
    }