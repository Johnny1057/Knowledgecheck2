using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledgecheck2sl
{
    public class TShirt : ClothingItem
    {
        public string Design { get; set; } = string.Empty;
        public string SleeveType { get; set; } = string.Empty;

        public TShirt() { }
    }
}