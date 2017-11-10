using System.IO;
using Newtonsoft.Json;

namespace VocabularySprintLibrary.Infrastructure
{
    public class File
    {
        public File()
        {
            //dataDirectory = "Data/";
        }

        public T ReadFromFile<T>(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            
            StreamReader streamReader = new StreamReader(filePath);
            string json = streamReader.ReadToEnd();
            T content = JsonConvert.DeserializeObject<T>(json);
            streamReader.Close();

            return content;
        }

        public void SaveToFile<T>(string filePath, T objectToSave)
        {
            string json = JsonConvert.SerializeObject(objectToSave);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.Write(json);
            streamWriter.Close();
        }

        //public string dataDirectory { get; }
    }
}
