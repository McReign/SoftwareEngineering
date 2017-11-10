using System.IO;
using Newtonsoft.Json;

namespace VocabularySprintLibrary.Infrastructure
{
    public class File
    {
        public File()
        {
            dataDirectory = Directory.GetCurrentDirectory() + "/Data/";
        }

        public T ReadFromFile<T>(string filePath)
        {
            if (!Directory.Exists(dataDirectory + filePath))
            {
                Directory.CreateDirectory(dataDirectory + filePath);
            }
            
            StreamReader streamReader = new StreamReader(dataDirectory + filePath);
            string json = streamReader.ReadToEnd();
            T content = JsonConvert.DeserializeObject<T>(json);
            streamReader.Close();

            return content;
        }

        public void SaveToFile<T>(string filePath, T objectToSave)
        {
            string json = JsonConvert.SerializeObject(objectToSave);

            if (!Directory.Exists(dataDirectory + filePath))
            {
                Directory.CreateDirectory(dataDirectory + filePath);
            }

            StreamWriter streamWriter = new StreamWriter(dataDirectory + filePath);
            streamWriter.Write(json);
            streamWriter.Close();
        }

        public string dataDirectory { get; }
    }
}
