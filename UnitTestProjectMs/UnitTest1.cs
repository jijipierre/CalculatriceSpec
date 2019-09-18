using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreCalculator.Controllers;
using NetCoreCalculator.Models;

namespace UnitTestProjectMs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HomeController_Adition()
        {
            HomeController homeController = new HomeController();
            Operation model = new Operation();
            model.OperationType = OperationType.Addition;
            model.NumberA = 5;
            model.NumberB = 4;
            homeController.Index(model);

            Assert.AreEqual(model.Result, 9);
        }
        [TestMethod]
        public void HomeController_Subtraction()
        {
            HomeController homeController = new HomeController();
            Operation model = new Operation();
            model.OperationType = OperationType.Subtraction;
            model.NumberA = 5;
            model.NumberB = 4;
            homeController.Index(model);

            Assert.AreEqual(model.Result, 1);
        }
        [TestMethod]
        public void HomeController_Multiplication()
        {
            HomeController homeController = new HomeController();
            Operation model = new Operation();
            model.OperationType = OperationType.Multiplication;
            model.NumberA = 5;
            model.NumberB = 4;
            homeController.Index(model);

            Assert.AreEqual(model.Result, 20);
        }
        [TestMethod]
        public void HomeController_Division()
        {
            HomeController homeController = new HomeController();
            Operation model = new Operation();
            model.OperationType = OperationType.Division;
            model.NumberA = 10;
            model.NumberB = 2;
            homeController.Index(model);

            Assert.AreEqual(model.Result, 5);
        }
    }
}
