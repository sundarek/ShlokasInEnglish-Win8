using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace ShlokasInEnglish.DataModel
{
    class shlokas
    {
        public string ShlokaID { get; set; }
        public string ShlokaName { get; set; }
        public string ShlokaOriginal { get; set; }
        public string ShlokaEnglish { get; set; }

        //public shlokas(string shlokaID, string shlokaName, string shlokaOriginal, string shlokaEnglish)
        //{
        //    ShlokaID = shlokaID;
        //    ShlokaName = shlokaName;
        //    ShlokaOriginal = shlokaOriginal;
        //    ShlokaEnglish = shlokaEnglish;
        //}
    }

    class deity
    {
        public string DeityID { get; set; }
        public string DeityName { get; set; }
        public string DeityImage { get; set; }

        private List<shlokas> shlokasOfDeity = new List<shlokas>();
        public List<shlokas> ShlokasOfDeity
        {
            get { return shlokasOfDeity; }
            set { shlokasOfDeity = value; }
        }

    }

}
