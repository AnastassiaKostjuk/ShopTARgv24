using Microsoft.AspNetCore.Mvc;
using ShopTARgv24.Core.Dto;
using ShopTARgv24.Core.ServiceInterface;
using ShopTARgv24.Data;
using ShopTARgv24.Models.Kindergarten;

namespace ShopTARgv24.Controllers
{
    public class KindergartenController : Controller
    {
        private readonly ShopTARgv24Context _context;
        private readonly IKindergartenServices _kindergartenServices;
        public KindergartenController
            (
                ShopTARgv24Context context,
                IKindergartenServices kindergartenServices
            )
        {
            _context = context;
            _kindergartenServices = kindergartenServices;
        }

        public IActionResult Index()
        {
            var result = _context.Kindergartens
                .Select(x => new KindergartenIndexViewModel
                {
                    Id = (Guid)x.Id,
                    Group = x.Group,
                    ChildrenTotal = (int)x.ChildrenTotal,
                    Teacher = x.Teacher,
                    KindergartenName = x.KindergartenName
                });

            return View(result);
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";

            KindergartenCreateUpdateViewModel result = new();

            return View("CreateUpdate", result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(KindergartenCreateUpdateViewModel vm)
        {
            var dto = new KindergartenDto()
            {
                Id = vm.Id,
                Group = vm.Group,
                ChildrenTotal = vm.ChildrenTotal,
                KindergartenName = vm.KindergartenName,
                Teacher = vm.Teacher,
                CreatedAt = vm.CreatedAt,
                UpdatedAt = vm.UpdatedAt
            };
            var result = await _kindergartenServices.Create(dto);

            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        //Update
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var kindergarten = await _kindergartenServices.DetailAsync(id);

            if (kindergarten == null)
            {
                return NotFound();
            }

            var vm = new KindergartenCreateUpdateViewModel();

            vm.Id = kindergarten.Id;
            vm.Group = kindergarten.Group;
            vm.ChildrenTotal = kindergarten.ChildrenTotal;
            vm.KindergartenName = kindergarten.KindergartenName;
            vm.Teacher = kindergarten.Teacher;
            vm.CreatedAt = kindergarten.CreatedAt;
            vm.UpdatedAt = kindergarten.UpdatedAt;

            return View("CreateUpdate", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Update(KindergartenCreateUpdateViewModel vm)
        {
            var dto = new KindergartenDto()
            {
                Id = vm.Id,
                Group = vm.Group,
                ChildrenTotal = vm.ChildrenTotal,
                KindergartenName = vm.KindergartenName,
                Teacher = vm.Teacher,
                CreatedAt = vm.CreatedAt,
                UpdatedAt = vm.UpdatedAt
            };

            var result = await _kindergartenServices.Update(dto);

            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index), vm);
        }

    }
}
