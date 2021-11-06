using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminsGuide.Data.Models
{
    public class Guide
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("question")]
        public string Question { get; set; }
        [Column("answer")]
        public string Answer { get; set; }
    }
}
