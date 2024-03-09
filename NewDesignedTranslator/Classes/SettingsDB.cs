using MySql.Data.MySqlClient;

namespace NewDesignedTranslator.Classes
{
    public class SettingsDB
    {
        //Строка для подключения к ДБ
        private readonly string connectionString =
            "OPEN SOURCE";

        public void InitializeSettings()
        {
            //IF Open Source Version
            if(Globals.OP == true)
            {
                Globals.newVer = "OP";
                Globals.patchNotes = "This is a open soruce version of that program,you can type here whatever you want in SettingsDB.cs file!";
                Globals.DownloadUpdaterLink = "OP";
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM Settings", connection))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Globals.newVer = reader.GetString(0);
                            Globals.patchNotes = reader.GetString(1);
                            Globals.DownloadUpdaterLink = reader.GetString(3);
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }
        }

    }
}
