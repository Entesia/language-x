using System.ComponentModel.DataAnnotations.Schema;
using LX.Enums;

namespace LX.Models
{
    [Table("Car")]
    public class Car
    {
        public int Id { get; set; }
        [ForeignKey("Make")]
        public virtual int MakeId { get; set; } 
        public virtual Make Make { get; set; }
        [ForeignKey("Model")]
        public virtual int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public bool ForRent { get; set; }
        public virtual MotorType Motor { get; set; }
    }
}