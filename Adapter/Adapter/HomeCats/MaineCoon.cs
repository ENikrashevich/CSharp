using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCats
{
    public class MaineCoon : IHomeCat
    {
        public string NameOfHomeCat { get; set; }

        public string SurnameOfOwner { get; set; }

        public string NameOfOwner { get; set; }

        public string DescriptionOfHomeCat { get; set; }

        public MaineCoon(string nameOfHomeCat, string surnameOfOwner, string nameOfOwner)
        {
            NameOfHomeCat = nameOfHomeCat;
            SurnameOfOwner = surnameOfOwner;
            NameOfOwner = nameOfOwner;
            DescriptionOfHomeCat = "Мейн-кун";
        }
    }
}
