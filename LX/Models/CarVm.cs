using System.Linq;
using LX.Enums;
using LX.Infrastructure;

namespace LX.Models
{
    public class CarVm
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public Model Model { get; set; }
        public MotorType Motor { get; set; }
        public bool? ForRent { get; set; }

        public CarVm() { }

        public CarVm(Car car)
        {
            var make = car.Make.MakeContent.FirstOrDefault(t => t.Language == Current.Culture);
            Make = make == null ? "" : make.Text;
            Model = car.Model;
            Id = car.Id;
            Motor = car.Motor;
            ForRent = car.ForRent;
        }
    }
}