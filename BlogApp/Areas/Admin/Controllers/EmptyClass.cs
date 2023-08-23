//using System;
//using System.Data;
//using Entities.DTos;
//using Microsoft.AspNetCore.Mvc;
//using Services.Contracts;

//namespace BlogApp.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class UserController : Controller
//    {
//        private readonly IServiceManager _manager;

//        public UserController(IServiceManager serviceManager)
//        {
//            _manager = serviceManager;
//        }

//        public IActionResult Index()
//        {
//            var users = _manager.AuthService.GetAllUsers();
//            return View(users);
//        }

//        public IActionResult Create()
//        {
//            return View(new UserDtoForCreation()
//            {
//                Roles = new HashSet<string>(_manager
//                .AuthService
//                .Roles
//                .Select(r => r.Name)
//                .ToList())
//            });
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([FromForm] UserDtoForCreation userDto)
//        {
//            if (!ModelState.IsValid) return View();
//            try
//            {
//                var result = await _manager.AuthService.CreateUser(userDto);
//                return result.Succeeded
//                    ? RedirectToAction("Index")
//                    : View(new UserDtoForCreation()
//                    {
//                        Roles = new HashSet<string>(_manager
//                .AuthService
//                .Roles
//                .Select(r => r.Name)
//                .ToList())
//                    });
//            }
//            catch (Exception ex)
//            {
//                return View(new UserDtoForCreation()
//                {
//                    Roles = new HashSet<string>(_manager
//            .AuthService
//            .Roles
//            .Select(r => r.Name)
//            .ToList())
//                });
//            }

//        }

//        public async Task<IActionResult> Update([FromRoute(Name = "id")] string id)
//        {
//            var user = await _manager.AuthService.GetOneUserForUpdate(id);
//            return View(user);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Update([FromForm] UserDtoForUpdate userDto)
//        {
//            if (ModelState.IsValid)
//            {
//                await _manager.AuthService.Update(userDto);
//                return RedirectToAction("Index");
//            }
//            return View();
//        }

//        public async Task<IActionResult> ResetPassword([FromRoute(Name = "id")] string id)
//        {
//            return View(new ResetPasswordDto()
//            {
//                UserName = id
//            });
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordDto model)
//        {

//            var result = await _manager.AuthService.ResetPassword(model);
//            return result.Succeeded
//                ? RedirectToAction("Index")
//                : View(new ResetPasswordDto()
//                {
//                    UserName = model.UserName
//                });

//        }



//    }
//}

