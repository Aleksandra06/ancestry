using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ancestry.AncestryDB.Models
{
    [Table("Human")]
    public class Human : ICloneable
    {
        [Key]
        public int IdName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public bool IsDeleted { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
