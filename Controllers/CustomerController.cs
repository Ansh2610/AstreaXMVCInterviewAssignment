using Microsoft.AspNetCore.Mvc;

namespace AstreaXMVCInterviewAssignment.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Orders()
        {
            return View();
        }
    }
}