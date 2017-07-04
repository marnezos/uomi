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
        private CultureInfo _cultureInfo;
        private string _localeLanguage;

        private Translator()
        {
            _resourceManager = new ResourceManager("Windows_Uomi_App.Languages.Translations", typeof(Translator).Assembly);
            _localeLanguage = "en"; // Default language is english
        }

        public string Locale {
            get { return _localeLanguage;  }
            set
            {
                _localeLanguage = value;
                _cultureInfo = CultureInfo.CreateSpecificCulture(_localeLanguage);
            }
        }

        public string Translate(string StringToTranslate)
        {
            return _resourceManager.GetString("frmMain_Caption", _cultureInfo);
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
