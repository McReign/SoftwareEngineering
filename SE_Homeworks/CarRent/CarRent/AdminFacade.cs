
namespace CarRent
{
    class AdminFacade
    {
        private CarRentCenter carCenter = new CarRentCenter();

        public void ShowAllCars()
        {
            carCenter.getCarList();
        }

        public void AddCar(string model, string color)
        {
            carCenter.getCarList().Add(new Car(model, color));//, OccupationStatus.Free));
        }
    }
}
