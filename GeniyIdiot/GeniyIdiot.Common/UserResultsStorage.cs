using System.Collections.Generic;
using System.IO;
using System.Text;
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GeniyIdiot.Common
{
    public class UserResultsStorage
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

            var userStatistic = JsonConvert.DeserializeObject<List<User>>(fileData);

            return userStatistic;
        }
        static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }
    }
}
