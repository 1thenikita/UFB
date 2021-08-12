using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFBLibrary
{
    /// <summary>
    /// Класс библиотеки по работе с продуктами
    /// </summary>
    public class ProductL
    {
        /// <summary>
        /// Метод проверки стоимости товара на высокую цену
        /// </summary>
        /// <param name="price">Цена</param>
        /// <param name="normalPrice">Нормальная цена</param>
        /// <param name="delta">Дельта (разброс)</param>
        public static string CheckPrice(decimal price, decimal normalPrice, decimal delta)
        {
            decimal normalPriceMin = normalPrice - delta;
            decimal normalPriceMax = normalPrice + delta;

            string result = "Низкая цена";

            if (price <= normalPriceMin)
            {
                result = "Низкая цена";
            }

            if (price >= normalPriceMin && price <= normalPriceMax)
            {
                result = "Нормальная цена";
            }

            if (price >= normalPriceMax)
            {
                result = "Высокая цена";
            }

            return result;
        }
    }
}
