using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ancestry.AncestryDB.Models
{
    [Table("Node")]
    public class Node : ICloneable
    {
        [Key]
        public int IdNode { get; set; }
        public int HumanId { get; set; }
        public int? MotherId { get; set; }
        public int? FatherId { get; set; }
        public bool IsDeleted { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
