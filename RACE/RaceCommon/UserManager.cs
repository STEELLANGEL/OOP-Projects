using System.Collections.Generic;
using Newtonsoft.Json;


namespace RaceCommon
{
    public class UserManager
    {
        public static string path = "userResults.json";

        public static void Append(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            Save(usersResults);
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(path))
            {
                return new List<User>();
            }
           
            var fileData = FileProvider.GetValue(path);

            return  JsonConvert.DeserializeObject<List<User>>(fileData);
        }
        static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }

    }
}
