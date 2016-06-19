using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LX.Models
{
    [Table("Make")]
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<MakeContent> MakeContent { get; set; }
        //public string Type { get; set; }
    }
}