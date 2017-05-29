using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TroyTrivia.Business.Entities;

namespace TroyTrivia.Business.Interactors
{
    public static class FilesInteractor
    {
        public static bool SaveCurrentGame(Game game)
        {
            var fileName = $"{game.Id}.json";
            var savedGameFilePath = Path.Combine(Properties.Settings.Default.SaveGameFolderPath, fileName);

            CreateDirectoryIfNotExists(savedGameFilePath);

            var serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(savedGameFilePath))
                {
                    using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                    {
                        serializer.Serialize(jsonWriter, game);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static Game LoadGameFromFile(string path)
        {
            var serializer = new JsonSerializer();
            using (StreamReader streamReader = new StreamReader(path))
            {
                using (JsonReader jsonReader = new JsonTextReader(streamReader))
                {
                    return (Game)serializer.Deserialize(jsonReader, typeof(Game));
                }
            }
        }

        public static void CreateDirectoryIfNotExists(string path)
        {
            var pathDirectory = Path.GetDirectoryName(path);

            if (false == Directory.Exists(pathDirectory))
            {
                Directory.CreateDirectory(pathDirectory);
            }
        }
    }
}
