using cSharp_graigsList.Models;
namespace cSharp_graigsList.DB;

public static class FakeDb
{
    public static List<Car> Cars { get; set; } = new List<Car>(){
    new Car("Gravedigger", 2023,"Chevy"  ),
    new Car("Reta-Ru", 2006,"Subaru"  ),
       new Car("Low rider", 2016,"Toyota"  ),
};
}