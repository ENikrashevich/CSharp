using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCats
{
    public interface IHomeCat
    {
        string NameOfHomeCat { get; }
        string SurnameOfOwner { get; }
        string NameOfOwner { get; }
        string DescriptionOfHomeCat { get; }
    }
}
