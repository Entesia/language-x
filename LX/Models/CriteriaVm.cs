using System.Collections.Generic;
using LX.Enums;

namespace LX.Models
{
    public class CriteriaVm
    {
        public int Id { get; set; }
        public List<Make> Make { get; set; }
        public List<Model> Model { get; set; }
        public MotorType Motor { get; set; }
        public string Error { get; set; }
    }
}