using AutoShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla",
                         shortDesc = "Electro",
                         longDesc = "Electro engine",
                         img = "/img/tesla.jpg",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Електромобілі"]
                     },
                    new Car
                    {
                        name = "Skoda",
                        shortDesc = "Diesel",
                        longDesc = "Diesel engine",
                        img = "/img/skoda.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    },
                    new Car
                    {
                        name = "Mercedes",
                        shortDesc = "Gasoline",
                        longDesc = "Gasoline engine",
                        img = "/img/mercedes.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Класичні автомобілі"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Електромобілі", desc = "Сучасний вид транспорту"},
                        new Category {categoryName = "Класичні автомобілі", desc = "Машини з двигуном внутрішнього згорання"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
