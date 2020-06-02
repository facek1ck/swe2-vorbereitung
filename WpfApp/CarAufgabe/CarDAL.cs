using System;
using System.Collections.Generic;
using System.Linq;

public class CarDAL : ICarDAL
{
    public IList<Car> GetCars(string brand, string model)
    {
        if (string.IsNullOrEmpty(brand))
        {
            return _cars.Where(c => c.Model == model).ToList();
        }
        else if (string.IsNullOrEmpty(model))
        {
            return _cars.Where(c => c.Brand == brand).ToList();

        }
        else if(string.IsNullOrEmpty(brand) && string.IsNullOrEmpty(model))
        {
            return _cars;
        }
        return _cars.Where(c => c.Brand == brand && c.Model == model).ToList();
    }

    public void SaveCar(Car c)
    {
        _cars.Add(c);
    }

    private IList<Car> _cars { get; } = new List<Car>();
}
