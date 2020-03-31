using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace kin.TreeDB.Models
{
    [Table("Tree")]
    public class Tree : ICloneable
    {
        [Key]
        public int IdNode { get; set; }
        public int NodeId { get; set; }
        public int? MotherId { get; set; }
        public int? FatherId { get; set; }
        public bool IsDeleted { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
