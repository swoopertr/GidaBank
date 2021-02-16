using Gidabank.Data.Db.Postgresql;
using Repository;

namespace Gidabank.Data.Managers.Postgresql
{
    public class UserManager : Repository.Postgresql<Users>
    {
        public UserManager() : base(DbConfiguration.postgresql_Connstr)
        {
        }
    }
}