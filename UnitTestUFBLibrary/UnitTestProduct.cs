using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UFBLibrary;

namespace UnitTestUFBLibrary
{
    /// <summary>
    /// Класс тест библиотеки по работе с тетированием класса продуктов
    /// </summary>
    [TestClass]
    public class UnitTestProduct
    {
        /// <summary>
        /// Тест автоматической проверки метода проверки суммы
        /// </summary>
        [TestMethod] 
        public void CheckPrice_Import200_20_500_50_1000_00_ReturnLowPrice()
        {
            decimal price = new decimal(200.20);
            decimal normalPrice = new decimal(500.50);
            decimal delta = new decimal(1000.00);

            string trueResult = "Нормальная цена";

            string result = ProductL.CheckPrice(price, normalPrice, delta);

            Assert.AreEqual(result, trueResult);
        }
    }
}
