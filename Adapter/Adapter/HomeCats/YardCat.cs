using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCats
{
    public class YardCat : IHomeCat
    {
        public string NameOfHomeCat { get; set; }

        public string SurnameOfOwner { get; set; }

        public string NameOfOwner { get; set; }

        public string DescriptionOfHomeCat { get; set; }

        public YardCat(string nameOfHomeCat) 
        {
            NameOfHomeCat = nameOfHomeCat;
            SurnameOfOwner = "не определено";
            NameOfOwner = "не определено";
            DescriptionOfHomeCat = "метис";
        }
    }
}
