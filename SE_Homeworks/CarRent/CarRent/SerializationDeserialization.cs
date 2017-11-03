using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace CarRent
{
    class SerializationDeserialization
    {
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Car>));
        
        public void Serialize(List<Car> carList)
        {
            using (FileStream fileStream = new FileStream("carList.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fileStream, carList);
            }
        }

        public List<Car> Deserialize()
        {
            List<Car> carList;

            using (FileStream fileStream = new FileStream("carList.json", FileMode.OpenOrCreate))
            {
                carList = (List<Car>)jsonFormatter.ReadObject(fileStream); 
            }

            return carList;
        }
    }
}
