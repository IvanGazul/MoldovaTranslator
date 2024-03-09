using Microsoft.Win32;
using System;

namespace NewDesignedTranslator.Classes
{
    public class Settings
    {

        //Путь до нашего приложения в реестре
        private static RegistryKey moldovaTranslatorKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\moldovaTranslator", true);

        public void Save()
        {
            moldovaTranslatorKey.SetValue("Version", this._version);
            moldovaTranslatorKey.SetValue("SavedTextRum", this._savedTextRum);
            moldovaTranslatorKey.SetValue("SavedTextMold", this._savedTextMold);
            moldovaTranslatorKey.SetValue("PrevVersion", this._prevVersion);
            moldovaTranslatorKey.SetValue("FirstLaunch", this._firstLaunch);
            moldovaTranslatorKey.SetValue("SwappedLang", this._swappedLang);
        }
        public static Settings GetSettings()
        {
            string version, savedTextRum, savedTextMold, prevVersion;
            bool firstLaunch, swappedLang;
            try
            {
                version = moldovaTranslatorKey.GetValue("Version").ToString();
                savedTextRum = moldovaTranslatorKey.GetValue("SavedTextRum").ToString();
                savedTextMold = moldovaTranslatorKey.GetValue("SavedTextMold").ToString();
                prevVersion = moldovaTranslatorKey.GetValue("PrevVersion").ToString();
                firstLaunch = Convert.ToBoolean(moldovaTranslatorKey.GetValue("FirstLaunch").ToString());
                swappedLang = Convert.ToBoolean(moldovaTranslatorKey.GetValue("SwappedLang").ToString());
            }
            catch
            {
                return new Settings(Globals.ClientVersion, string.Empty,string.Empty,true, string.Empty,false);
            }

            return new Settings(version,savedTextRum, savedTextMold, firstLaunch, prevVersion, swappedLang);
        }

        public Settings(string version ,string savedTextRum, string savedTextMold, 
                        bool firstLaunch, string prevVersion, bool swappedLang)
        {
            _version = version;
            _savedTextMold = savedTextMold;
            _savedTextRum = savedTextRum;
            _firstLaunch = firstLaunch;
            _prevVersion = prevVersion;
            _swappedLang = swappedLang;
        }
       
        public Settings()
        {

        }

        public string _version { get; set; } = Globals.ClientVersion;
        public string _savedTextRum { get; set; }
        public string _savedTextMold { get; set; }
        public bool _firstLaunch { get; set; }
        public bool _swappedLang { get; set; }
        public string _prevVersion { get; set; }
    }
}
