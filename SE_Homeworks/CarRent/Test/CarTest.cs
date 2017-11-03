using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRent;
using System;
using System.Collections.Generic;

namespace CarTests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void AddTheLastDateIntoDatesList_FindLastDateShouldReturnLastDate()
        {
            //arrange
            var car = new Car("model", "color");
            DateOfRent dateOfRent = new DateOfRent();
            car.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 2), new DateTime(2017,10,7)));
            car.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 9), new DateTime(2017, 10, 23)));
            var expected = new DateTime(2017, 10, 23);
            //act
            var answer = dateOfRent.FindLastDate(car);
            //assert
            Assert.AreEqual(expected, answer);
        }

        [TestMethod]
        public void SetIdToUser_UserShouldHaveRightId()
        {
            //arrange
            Client user = new Client();
            var expected = 1;
            //act
            user.setID();
            var answer = user.getID();
            //assert
            Assert.AreEqual(expected, answer);
        }


        [TestMethod]
        public void GetFreeCarListOnTwoDates_ShouldReturnRightList()
        {
            //arrange
            CarRentCenter carCenter = new CarRentCenter();
            var firstCar = new Car("model_1", "color_1");
            var secondCar = new Car("model_2", "color_2");
            firstCar.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 2), new DateTime(2017, 10, 7)));
            firstCar.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 9), new DateTime(2017, 10, 23)));
            secondCar.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 2), new DateTime(2017, 10, 7)));
            secondCar.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 9), new DateTime(2017, 10, 26)));
            carCenter.getCarList().Add(firstCar);
            carCenter.getCarList().Add(secondCar);
            var expected = new List<Car>{ firstCar };

            //act
            var answer = (List<Car>)carCenter.CheckingFree(new DateTime(2017, 10, 25), new DateTime(2017, 10, 30));

            //assert
            CollectionAssert.AreEqual(expected, answer);

        }

        [TestMethod]
        public void SendCarToCheckUp_CountDateOfRentShouldBeEqualAddedDates()
        {
            //arrange
            Car car = new Car("model", "color");
            car.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 2), new DateTime(2017, 10, 7)));
            car.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 9), new DateTime(2017, 10, 23)));
            var expected = 3;

            //act
            car.SendToCheckUp();
            var answer = car.getDateOfRent().Count;

            //assert
            Assert.AreEqual(expected, answer);

        }

        [TestMethod]
        public void SendCarToRent_CarsDateOfRentShouldBeEqualAddedDates()
        {
            //arrange
            Car car = new Car("model", "color");
            car.getDateOfRent().Add(new DateOfRent(new DateTime(2017, 10, 9), new DateTime(2017, 10, 23)));
            var expected = 2;

            //act
            car.SendToRent(new DateTime(2017, 10, 2), new DateTime(2017, 10, 7));
            var answer = car.getDateOfRent().Count;

            //assert
            Assert.AreEqual(expected, answer);

        }

        [TestMethod]
        public void SendCarToRent_CarsCountOfRentShouldBeCorrect()
        {
            //arrange
            Car car = new Car("model", "color");
            var expected = 2;

            //act
            car.SendToRent(new DateTime(2017, 11, 19), new DateTime(2017, 12, 1));
            car.SendToRent(new DateTime(2017, 12, 2), new DateTime(2017, 12, 7));
            var answer = car.getCountOfRent();

            //assert
            Assert.AreEqual(expected, answer);

        }
    }
}            

