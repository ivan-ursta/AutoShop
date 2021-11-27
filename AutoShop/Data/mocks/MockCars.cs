using AutoShop.Data.interfaces;
using AutoShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla", 
                        shortDesc="Electro",longDesc="Electro engine",
                        img="/img/tesla.jpg",
                        price=45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Skoda",
                        shortDesc="Diesel",longDesc="Diesel engine",
                        img="/img/skoda.jpg",
                        price=45000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mercedes",
                        shortDesc="Gasoline",longDesc="Gasoline engine",
                        img="/img/mercedes.jpg",
                        price=45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }

                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
