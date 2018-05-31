using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Lab5.Models
{
    public class CarFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarFactory(): base("name=DefaultConnection")
        {
            Database.SetInitializer(new CarInitializer());
        }
    }

    public class CarInitializer : DropCreateDatabaseIfModelChanges<CarFactory>
    {
        protected override void Seed(CarFactory context)
        {
            {
                context.Cars.Add(new Car() { Model = "Rabbit", MaxSpeed = 300 });
                context.Cars.Add(new Car() { Model = "Turtle", MaxSpeed = 150 });

            }
        }
    }

}