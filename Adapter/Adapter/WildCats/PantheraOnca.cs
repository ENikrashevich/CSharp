using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WildCats
{
    public class PantheraOnca : IWildCat
    {
        public string NameOfWildCat { get; set; }

        public string DescriptionOfWildCat { get; set; }

        public PantheraOnca(string nameOfWildCat)
        {
            NameOfWildCat = nameOfWildCat;
            DescriptionOfWildCat = "Ягуар";
        }
    }
}
