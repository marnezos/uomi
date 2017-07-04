using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace Windows_Uomi_App
{
    class Translator
    {
        private static Translator _instance;
        private ResourceManager _resourceManager;    
        
        private Translator()
        {
            _resourceManager = new ResourceManager("Windows_Uomi_App.Languages.Translations", typeof(Translator).Assembly);
        }

        public string Translate(string StringToTranslate, string Locale = "en")
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(Locale); ;            
            return _resourceManager.GetString("frmMain_Caption", cultureInfo);
        }

        public static Translator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Translator();
                }
                return _instance;
            }
        }

    }
}
