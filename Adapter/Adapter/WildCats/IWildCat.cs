using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WildCats
{
    public interface IWildCat
    {
        string NameOfWildCat {  get; }
        string DescriptionOfWildCat { get;}
    }
}
