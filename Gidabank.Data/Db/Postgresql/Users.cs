using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace Gidabank.Data.Db.Postgresql
{
    [Table("Users")]
    public class Users : DbBase
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}