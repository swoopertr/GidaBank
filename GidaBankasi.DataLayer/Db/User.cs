using System;
using System.ComponentModel.DataAnnotations.Schema;
using GidaBankasi.DataLayer.Db.Base;

namespace GidaBankasi.DataLayer.Db
{
    [Table("Users")]
    public class User: DbBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int LoginType { get; set; }
        public DateTime LastLogin { get; set; }
    }
}