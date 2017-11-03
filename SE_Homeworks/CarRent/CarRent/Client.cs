using System.Collections.Generic;
using System.Runtime.Serialization;


namespace CarRent
{
    [DataContract]
    public class Client
    {
        [DataMember]
        private int userID = 0;
        [DataMember]
        private List<Car> rentedCars = new List<Car>();

        public void setID()
        {
            userID++;
        }

        public List<Car> getRentedCars()
        {
            return rentedCars;
        }

        public int getID()
        {
            return userID;
        }
    }
}
