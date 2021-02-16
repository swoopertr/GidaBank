using System.Collections.Generic;
using System.Diagnostics;
using Gidabank.Data.Db.Postgresql;
using Gidabank.Data.Managers.Postgresql;
using Gidabank.Data.Managers.MsSql;
using Microsoft.AspNetCore.Mvc;
using Gidabank.UI.Models;


namespace Gidabank.UI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
                   
        }

        public IActionResult Index()
        {
            var postgre_UsersManager = new Gidabank.Data.Managers.Postgresql.UserManager();

            var all = postgre_UsersManager.GetAll();

            var mssql_UserManager = new Gidabank.Data.Managers.MsSql.UserManager();
            var usersList = mssql_UserManager.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}