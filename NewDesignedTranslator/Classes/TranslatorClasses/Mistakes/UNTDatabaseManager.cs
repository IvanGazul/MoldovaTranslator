using MySql.Data.MySqlClient;

namespace NewDesignedTranslator.Classes.TranslatorClasses.Mistakes
{
    internal class UNTDatabaseManager
    {
        //Строка для подключения к ДБ
        private readonly string connectionString =
            "OPEN SOURCE";

        //Слово и его перевод из ДБ
        private string _originalWord = string.Empty;
        private string _wordTranslation = string.Empty;

        //Новый перевод который хочет добавить пользователь
        private string userNewTranslation;

        private void UpdateCountOfWord(MySqlConnection connection)
        {
            //Перевод уже существует
            using (MySqlCommand newCommand = new MySqlCommand($"UPDATE UNT SET usedBy=usedBy+1 WHERE userTranslation=@userTranslation", connection))
            {
                newCommand.Parameters.AddWithValue("@userTranslation", userNewTranslation);
                newCommand.ExecuteNonQuery();
            }
        }

        private void AddNewWordTranslation(MySqlConnection connection,string originalWord)
        {
            //Добавляем новый перевод для этого слова
            using (MySqlCommand newCommand = new MySqlCommand("INSERT INTO UNT (originalWord, userTranslation, usedBy) VALUES (@originalWord, @userTranslation, @usedBy);", connection))
            {
                newCommand.Parameters.AddWithValue("@originalWord", originalWord);
                newCommand.Parameters.AddWithValue("@userTranslation", userNewTranslation);
                newCommand.Parameters.AddWithValue("@usedBy", 1);
                newCommand.ExecuteNonQuery();
            }
        }
        
        public void AddUNT(string originalWord, string userTranslation)
        {
            userNewTranslation = userTranslation;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM UNT WHERE originalWord=@originalWord", connection))
                {
                    command.Parameters.AddWithValue("@originalWord", originalWord);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                _originalWord = reader.GetValue(0).ToString();
                                _wordTranslation = reader.GetValue(1).ToString();
                            }
                            catch
                            {
                                errorBox.Show("Произошла непредвиденная ошибка");
                                return;
                            }

                            reader.Close();

                            //Такой перевод для этого слова уже используют
                            if (_originalWord == originalWord && _wordTranslation == userTranslation)
                            {
                                //Увеличиваем число использований на 1
                                UpdateCountOfWord(connection);
                                break;
                            }

                            
                        }

                        if(reader.RecordsAffected == 0)
                        {
                            //Такого перевода для этого слова еще не существует или само слово еще не сущ. в БД
                            AddNewWordTranslation(connection, originalWord);
                        }

                    }
                    connection.Close();
                }
            }
        }
    }
}
