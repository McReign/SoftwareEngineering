using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeagueGram.Domain;

namespace LeagueGram.UnitTests
{
    [TestClass]
    public class LinqTests
    {
        [TestMethod]
        public void TestSelect()
        {
            var messages = new Message[]
            {
                new Message(Guid.NewGuid(), "safds", Guid.NewGuid(), DateTimeOffset.Now),
                new Message(Guid.NewGuid(), "gdfgdfg", Guid.NewGuid(), DateTimeOffset.Now),
                new Message(Guid.NewGuid(), "gdeiwoiueiojfkl", Guid.NewGuid(), DateTimeOffset.Now)
            };

            var messageTexts = messages.Select(message => message.Text).ToArray();
        }

        /*[TestMethod]
        public void TestWhere()
        {
            var users = new Message[]
            {
                new Message(Guid.NewGuid(), "safds", Guid.NewGuid(), DateTimeOffset.Now),
                new Message(Guid.NewGuid(), "gdfgdfg", Guid.NewGuid(), DateTimeOffset.Now),
                new Message(Guid.NewGuid(), "gdeiwoiueiojfkl", Guid.NewGuid(), DateTimeOffset.Now)
            };

            var filteredUsers = users.Where(user => user.RegistrationDate > new DateTimeOffset(2017, 10, 1, 0,0,0,TimeSpan.Zero)).ToArray();
        }*/

        [TestMethod]
        public void SecondTestWhere()
        {
            var str = new string[]{
                "sfdsfsdf",
                "dsf",
                "dsqqqqqwe"
            };

            var filteredStr = str.Where(array => array.Length > 5).ToArray();
            var mappedStr = filteredStr.Select(item => item[0].ToString()).ToList();
        }

        [TestMethod]
        public void TestAny()
        {
            var str = new string[]{
                "sfdsfsdf",
                "dsf",
                "dsqqqqqwe"
            };

            var hasValera = str.Any(student => student == "Valere");

            Assert.IsFalse(hasValera);
        }
    }

}
