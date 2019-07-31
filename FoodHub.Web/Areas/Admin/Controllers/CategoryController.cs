using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodHub.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace FoodHub.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            return View(_db.Category.ToList());
        }
    }
}