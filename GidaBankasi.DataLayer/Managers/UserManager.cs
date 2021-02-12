using AlchemLife.Repository.Repository;
using GidaBankasi.DataLayer.Db;

namespace GidaBankasi.DataLayer.Managers
{
    public class UserManager : MsSql<User>
    {
        public User GetUserByEmailAndPassword(string email, string password)
        {
            return ItemQuery($"select * from Users where Email='{email}' and Password='{password}'");
        }
    }
}