using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LX.Enums;

namespace LX.Models
{
    [Table("Localization")]
    public class Localization
    {
        public int Id { get; set; }

        [Required, MaxLength(10), Index("IX_NameCultureContentType", 1, IsUnique = true)]
        public string Culture { get; set; }

        [Required, MaxLength(100), Index("IX_NameCultureContentType", 2, IsUnique = true)]
        public string Name { get; set; }

        [Required, MaxLength(400)]
        public string Value { get; set; }

        [Required, Index("IX_NameCultureContentType", 3, IsUnique = true)]
        public ContentType ContentType { get; set; }
    }
}