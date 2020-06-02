using System;
using System.Collections.Generic;

public interface ICarDAL
{
    /// Returns all cars that match the given filter criteria. The filter of each
    /// criteria is not applied if the given criteria is empty or null.
    IList<Car> GetCars(string brand, string model);
    /// Saves the car. Always adds the car to the collection.
    void SaveCar(Car c);
}
