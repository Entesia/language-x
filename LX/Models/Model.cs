using System.ComponentModel.DataAnnotations.Schema;

namespace LX.Models
{
    [Table("Model")]
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MakeId { get; set; }
    }
}