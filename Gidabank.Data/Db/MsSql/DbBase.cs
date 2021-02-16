using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gidabank.Data.Db.MsSql
{
    public class DbBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}