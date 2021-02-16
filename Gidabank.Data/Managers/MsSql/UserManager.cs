using Gidabank.Data.Db.MsSql;
using Repository;

namespace Gidabank.Data.Managers.MsSql
{
    public class UserManager : MsSql<Users>
    {
        public UserManager() : base(DbConfiguration.mssql_Connstr)
        {
        }
    }
}