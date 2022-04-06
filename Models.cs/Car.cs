using System.ComponentModel.DataAnnotations;

namespace cSharp_graigsList.Models
{

    public class Car
    {

        public string? Id { get; set; }

       
        public string? Make { get; set; }

        public string? Name { get; set; }

        public int? Year { get; set; }


        public Car(string name, int? year, string make)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Make = make;
            Year = year;


        }

    }



}














