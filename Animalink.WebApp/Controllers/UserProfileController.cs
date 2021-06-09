using Animalink.Business.Users;
using Animalink.Data.Pocos.Users;
using Animalink.WebApp.Models.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace Animalink.WebApp.Controllers
{
    public class UserProfileController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> UserInfo(Guid userId)
        {
            userId = new Guid("93CE26A3-6E6E-4349-988C-24EB83649E8F");

            var userModel = new UserProfileViewModel();
            var userBo = new UsersBo();
            var userInfo = await userBo.GetUserInfo(userId);

            var userData = new UserDataPoco();
            userData.Id = userInfo.Result.Id;
            userData.UserName = userInfo.Result.UserName;
            userData.ImageReference = userInfo.Result.ImageReference;

            userModel.UserDataPoco = userData;

            return View(userModel);
        }


        [HttpPost]
        public async Task<IActionResult> Userinfo(UserProfileViewModel vm, Guid userId)
        {
   
            if (ModelState.IsValid)
            {
                var userModel = new UserProfileViewModel();
                var userBo = new UsersBo();
                var userInfo = await userBo.GetUserInfo(userId);

                var userData = new UserDataPoco();
                userData.Id = userInfo.Result.Id;
                userData.UserName = userInfo.Result.UserName;
                userData.ImageReference = userInfo.Result.ImageReference;

                userModel.UserDataPoco = userData;

                return View(userModel);
            }
            else
            {
                // mecanismo de alertas de erros
                return View();
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
