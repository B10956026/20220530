using _20220530.Models;
using _20220530.Models.Enum;
using Microsoft.AspNetCore.Mvc;

namespace _20220530.Controllers
{
    [FnCodeAuthorize(AuthFnCodeEnum.StudentGradesMgr)]
    public class StudentGradeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
