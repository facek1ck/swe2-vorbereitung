using System;
using System.Collections.Generic;
using System.Linq;

public class CarBL : ICarBL
{
    public Car GetCar(string model)
    {
        if (_brand == null)
        {
            throw new Exception("Brand must not be null!");
        }
        return _dal.GetCars(_brand, model).FirstOrDefault();
    }

    public IList<Car> GetCars()
    {
        if (_brand == null)
        {
            throw new Exception("Brand must not be null!");
        }
        return _dal.GetCars(_brand, null);
    }

    public void SaveCar(Car c)
    {
        _dal.SaveCar(c);
    }

    public void SetCurrentBrand(string brand)
    {
        _brand = brand;
    }

    public void SetDAL(ICarDAL dal)
    {
        _dal = dal;
    }

    private ICarDAL _dal { get; set; }
    private string _brand { get; set; }
}
