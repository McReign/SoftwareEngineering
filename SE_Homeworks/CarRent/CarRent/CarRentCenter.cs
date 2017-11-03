using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CarRent
{
    [DataContract]
    public class CarRentCenter
    {
        [DataMember]
        private List<Car> carList = new List<Car>();
        [DataMember]
        private List<Client> clientList = new List<Client>();

        private SerializationDeserialization serializationDeserialization = new SerializationDeserialization();

        public void loadData()
        {
            carList = serializationDeserialization.Deserialize();
        }

        public void setCarToRent(Client user, Car car, DateTime firstDate, DateTime lastDate)
        {
            user.setID();
            clientList.Add(user);
            car.SendToRent(firstDate, lastDate);
            CheckForCountOfRent(car);
        }

        public void CheckForCountOfRent(Car car)
        {
            if (car.getCountOfRent() == 10)
            {
                car.SendToCheckUp();
            }
        }

        public IEnumerable<Car> CheckingFree(DateTime firstDate, DateTime lastDate)
        {
            List<Car> freeCarList = new List<Car>();

            foreach (Car car in carList)
            {
                foreach (DateOfRent dateOfRent in car.getDateOfRent())
                {
                    if (((DateTime.Compare(firstDate, dateOfRent.getFirstDate()) < 0) && (DateTime.Compare(lastDate, dateOfRent.getFirstDate()) < 0))
                        || ((DateTime.Compare(firstDate, dateOfRent.getLastDate()) > 0) && (DateTime.Compare(lastDate, dateOfRent.getLastDate()) > 0))) //&& (car.IsFreeToRent()))
                    {
                        freeCarList.Add(car);
                    }
                }
            }

            return freeCarList;
        }

        public void saveData()
        {
            serializationDeserialization.Serialize(carList);
        }

        public List<Car> getCarList()
        {
            return carList;
        }

    }
}
