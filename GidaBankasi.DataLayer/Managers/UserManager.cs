using GidaBankasi.DataLayer.Db;
using Repository;

namespace GidaBankasi.DataLayer.Managers
{
    public class UserManager : MsSql<User>
    { 
        public UserManager() : base(DbConfiguration.mssql_Connstr)
        {
        }
        public User GetUserByEmailAndPassword(string email, string password)
        {
            return ItemQuery($"select * from Users where Email='{email}' and Password='{password}'");
        }

       
    }
}