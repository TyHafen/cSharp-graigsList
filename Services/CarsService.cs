using cSharp_graigsList.DB;
using cSharp_graigsList.Models;
namespace cSharp_graigsList.Services;


public class CarsService
{
    internal List<Car> GetAll()
    {
        return FakeDb.Cars;
    }

    internal Car GetById(string id)
    {
        Car found = FakeDb.Cars.Find(c => c.Id == id);
        if (found == null)
        {
            throw new Exception("Invalid Id");
        }
        return found;
    }
    internal Car Create(Car newCar)
    {
        FakeDb.Cars.Add(newCar);
        return newCar;
    }

    internal void Delete(string id)
    {
        Car found = GetById(id);
        FakeDb.Cars.Remove(found);
    }

    internal Car Update(Car updates)
    {
        Car original = GetById(updates.Id);
        original.Make = updates.Make ?? original.Make;
        original.Name = updates.Name ?? original.Name;
        original.Year = updates.Year ?? original.Year;
        return original;

    }
}