using System;

namespace CarRent
{
    class ClientFacade
    {
        private Client user = new Client();
        private CarRentCenter carCenter = new CarRentCenter();

        public void ShowFreeCars(DateTime firstDate, DateTime lastDate)
        {
            carCenter.CheckingFree(firstDate, lastDate);
            
        }

        public void MakeARent(Car car, DateTime firstDate, DateTime lastDate)
        {
            carCenter.setCarToRent(user, car, firstDate, lastDate);
            user.getRentedCars().Add(car);
        }
    }
}
