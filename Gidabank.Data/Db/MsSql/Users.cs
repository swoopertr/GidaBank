using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gidabank.Data.Db.MsSql
{
    [Table("Users")]
    public class Users : DbBase
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public string LoginType { get; set; }
    }
}