using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kin.TreeDB.Models
{
    [Table("Tree")]
    public class Tree : ICloneable
    {
        [Key]
        public int IdNode { get; set; }
        public int Node { get; set; }
        public int? Mother { get; set; }
        public int? Father { get; set; }
        public bool IsDeleted { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
