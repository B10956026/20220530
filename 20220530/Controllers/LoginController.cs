using _20220530.Models;
using _20220530.Models.Enum;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace _20220530.Controllers
{
    public class LoginController : Controller
    {
        List<LoginUser> userList = new List<LoginUser>
        {
            new LoginUser
            {
                Account = "123",
                Password = "123",
                Role = RoleEnum.Normal.ToString(), // 先假設有 admin 跟 normal 兩種角色
                Name = "Tony",
                IsDisable = false
            },
            new LoginUser
            {
                Account = "1234",
                Password = "1234",
                Role = RoleEnum.Admin.ToString(), // 先假設有 admin 跟 normal 兩種角色
                Name = "Matt",
                IsDisable = false
            }
        };

        /// <summary>
        /// 角色 對應 功能代碼
        /// </summary>
        List<Role2FnCode> role2Fn = new List<Role2FnCode>
        {
            new Role2FnCode{ RoleName = RoleEnum.Admin.ToString(), FnCode = AuthFnCodeEnum.StudentMgr.ToString() },
            new Role2FnCode{ RoleName = RoleEnum.Admin.ToString(), FnCode = AuthFnCodeEnum.StudentGradesMgr.ToString() },
            new Role2FnCode{ RoleName = RoleEnum.Normal.ToString(), FnCode = AuthFnCodeEnum.StudentMgr.ToString() },
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(LoginUser loginUser)
        {
            var user = (from a in userList
                        where a.Account == loginUser.Account
                        && a.Password == loginUser.Password
                        && a.IsDisable == false
                        select a).SingleOrDefault(); // 查詢是否有該使用者 (linq語法)

            if (user == null)
            {
                ViewData["ErrorMessage"] = "帳號與密碼有錯";
                return View();
            }
            else
            {
                // 取得登入者的授權功能代碼
                var userAuthFnCode = String.Join(',', role2Fn.Where(x => x.RoleName == user.Role).Select(x => x.FnCode).ToList());
                // 帳號密碼正確，建立ClaimsIdentity
                var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, user.Account),
                                new Claim("FullName", user.Name),
                                new Claim(ClaimTypes.Role, user.Role.ToString()),
                                new Claim("LastChanged", DateTime.Now.ToString()),
                                new Claim("AuthFnCode", String.Join(',', userAuthFnCode))
                            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDeny()
        {
            return View(); // 權限不足時導至此頁面
        }
    }
}
