using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TroyTrivia.Business.Interactors
{
    public class JsonInteractor
    {
        public static T SerializeToObject<T> (string jsonContent)
        {
            var serializer = new JsonSerializer();
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonContent)))
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    using (JsonReader jsonReader = new JsonTextReader(streamReader))
                    {
                        return (T)serializer.Deserialize(jsonReader, typeof(T));
                    }
                }
            }
        }
    }
}
