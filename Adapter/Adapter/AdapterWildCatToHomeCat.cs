using Adapter.HomeCats;
using Adapter.WildCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterWildCatToHomeCat : IHomeCat
    {
        IWildCat cat;

        public AdapterWildCatToHomeCat(IWildCat cat)
        {
            this.cat = cat;
        }

        public string NameOfHomeCat => cat.NameOfWildCat;

        public string SurnameOfOwner => "не определено";

        public string NameOfOwner => "не определено";

        public string DescriptionOfHomeCat => cat.DescriptionOfWildCat;
    }
}
