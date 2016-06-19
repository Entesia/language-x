using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LX.Enums;

namespace LX.Models
{
    [Table("MakeContent")]
    public class MakeContent
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public string Text { get; set; }

        public static implicit operator List<object>(MakeContent v)
        {
            throw new NotImplementedException();
        }
    }
}