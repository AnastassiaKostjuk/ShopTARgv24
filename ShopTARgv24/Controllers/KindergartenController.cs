using Microsoft.AspNetCore.Mvc;
using ShopTARgv24.Models.Kindergarten;
using ShopTARgv24.Data;

namespace ShopTARgv24.Controllers
{
    public class KindergartenController : Controller
    {
        private readonly ShopTARgv24Context _context;

        public KindergartenController
            (
                ShopTARgv24Context context
            )
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Kindergartens
                .Select(x => new KindergartenIndexViewModel
                {
                    Id = x.Id,
                    Group = x.Group,
                    ChildrenTotal = x.ChildrenTotal,
                    KindergartenName = x.KindergartenName,
                    Teacher = x.Teacher,
                });

            return View(result);
        }
    }
}
