using System;
using System.Collections.Generic;

public interface ICarBL
{
    /// Sets the current DAL.
    void SetDAL(ICarDAL dal);
    /// Sets the current brand. Each operation is only allowed on cars owned by
    /// the current brand.
    void SetCurrentBrand(string brand);
    /// Returns all cars of the current brand. A Exception is thrown, if no brand
    /// is set.
    IList<Car> GetCars();
    /// Returns the car of the given model of the current brand. Null is returned,
    /// if the model is not found. A Exception is thrown, if no brand is set.
    Car GetCar(string model);
    /// Saves the car of the current brand. A Exception is thrown, if no brand is
    /// set or the car does not belong to the current brand.
    void SaveCar(Car c);
}
