using NewDesignedTranslator.Classes;
using NewDesignedTranslator.Classes.TranslatorClasses;
using NewDesignedTranslator.Classes.TranslatorClasses.Mistakes;
using NewDesignedTranslator.UserControls;
using System.Collections.Generic;

namespace NewDesignedTranslator
{
    public static class Globals
    {
        //Open source ?
        public static bool OP = true;

        //CV
        public static string ClientVersion = "OP";

        //UC
        public static Programm Programm_uc = new Programm();
        public static UC_info info_uc = new UC_info();
        public static UC_update update_uc = new UC_update();
        public static TranslatorForm mainForm = null;

        //Классы Переводчика
        public static Translator translator = new Translator();
        public static TranslatorRules rules = new TranslatorRules();

        //Классы обработчика ошибок
        public static MistakeHandler mistakeHandler = new MistakeHandler();
        public static List<MisspelledWord> MisspelledWords = new List<MisspelledWord>();

        //Криптография
        //public static Cryptor cryptor = new Cryptor();

        //Обновление программы
        public static string newVer = string.Empty;
        public static string patchNotes = "This is open source program,you can modify it however you want,modify this string in Globals.cs!";

        public static string DownloadUpdaterLink = string.Empty;

        public static bool outdatedVersion = false;

        public static bool downloaded = false;

        //Настройки
        public static string SettingsFile = "config\\Settings.xml";
        public static string UNTFile = "config\\UNT.trconf";
        
        public static Settings settings = null;

        public static SettingsDB SettingsDB = new SettingsDB();
    }
}
