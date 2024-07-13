using EcommerceAPI.DatabaseContext;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly EcommerceContext _context;

        public UserController(EcommerceContext context)
        {
            _context = context;
        }


    }
}
