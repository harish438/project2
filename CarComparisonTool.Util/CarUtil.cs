using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparisonTool.Util
{
    public class CarUtil
    {
        List<Car> _cars = null;
        private object car;

        public CarUtil()
        {
            //_cars = new List<Util.Car>()
            //{
            //    new Car() { Make = "Honda", Model = "CRV", Color = "Green", Year = 2016, Price = 23845, TCCRating = 8, HwyMPG = 33}
            //};
            //_cars = new List<Car>()
            //{
            //    new Car
            //    {
            //        Make = "Honda", Model = "CRV", Color = "Green", Year = 2016, Price = 23845, TCCRating = 8, HwyMPG = 33
            //    },
            //    new Car
            //    {
            //        Make = "Honda", Model = "CRV", Color = "Green", Year = 2016, Price = 23845, TCCRating = 8, HwyMPG = 33
            //    }
            //};
         }
        public List<Car> AddCars(string json)
        {
            _cars = JsonConvert.DeserializeObject<List<Car>>(json);
            return _cars;
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public List<Car> GetNewestVehicles()
        {
            return _cars.OrderByDescending(c => c.Year).ThenBy(c => c.Make).ThenBy(c => c.Model).ToList();
            
        }

        public List<Car> GetBestValue()
        {
            return _cars.OrderByDescending(c => c.HwyMPG).ThenByDescending(c => c.TCCRating).ThenBy(c=>c.Price).ToList();
        }

        public List<Car> GetAlphabetizedList()
        {
            return _cars.OrderBy(c => c.Make).ThenBy(c => c.Model).ToList();
        }

        public List<Car> GetVehiclesbyPrice()
        {
            return (from car in _cars
                    orderby car.Price descending, car.Make
                    select car).ToList();
        }

        public List<Car> CalculateFuelConsumption(decimal distance)
        {
            return _cars.Select(c => { c.FuelConsumed = distance / c.HwyMPG; return c; }).ToList();
        }

        public List<MilesPerYear> GetAvgMiles(decimal distance)
        {
            var years = _cars.Select(c => { c.FuelConsumed = distance / c.HwyMPG; return c; })
                .GroupBy(c => c.Year)
                .Select(c => new MilesPerYear
                {
                    Year = c.First().Year,
                    MPG = (decimal)c.Sum(c1 => c1.HwyMPG)/c.Count()
                }).ToList();
            return years;
            //var milePerYear = new List<MilesPerYear>();

            //foreach (var year in years)
            //{
            //    milePerYear.Add(new MilesPerYear
            //    {
            //        Year = year.FirstOrDefault().Year,
            //    });

            //}

            //return null;

        }

        public Car GetRandomCar()
        {
            Random randNum = new Random();
            return _cars[randNum.Next(_cars.Count)];
        }
    }
}
