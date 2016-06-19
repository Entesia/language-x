using System.Collections.Generic;
using LX.Enums;

namespace LX.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SearchVm
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
        public bool? ForRent { get; set; }
        public List<MotorType> Motor { get; set; }
        public string Error { get; set; }
    }
}