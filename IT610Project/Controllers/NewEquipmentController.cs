using Microsoft.AspNetCore.Mvc;
using IT610Project.Data;
using IT610Project.Models.NEF;
//using NewEquipmentFormWeb.Models.MediMizer;

namespace IT610Project.Controllers
{
    public class NewEquipmentController : Controller
    {
        private readonly BaseDbContext _dbcontext;
        //private readonly MediMizerDbContext _MediMizerContext;

        public NewEquipmentController(BaseDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            IEnumerable<NewEquipment> objNewEquipmentList = _dbcontext.NewEquipment;
            return View(objNewEquipmentList);
        }

        // Get
        [HttpGet]
        public IActionResult Create()
        {
            //// Get data from database
            //List<Model> ModelList = new List<Model>();
            //ModelList = (from Model in _MediMizerContext.Models select Model).ToList();
            //// Insert data into list
            //ModelList.Insert(0, new Model { ModelKey = 0, ModelNo = "Select" });
            //// Assigning ModelList to Viewbag.ListofModel
            //ViewBag.ListofModel = ModelList;
            return View();
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NewEquipment obj)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.NewEquipment.Add(obj);
                _dbcontext.SaveChanges();
                TempData["Success"] = "Equipment Created Successfully";
                return RedirectToAction("List");
            }
            return View(obj);
        }

        // Get
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var EquipmentFromDb = _dbcontext.NewEquipment.Find(id);

            if (EquipmentFromDb == null)
            {
                return NotFound();
            }
            return View(EquipmentFromDb);
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NewEquipment obj)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.NewEquipment.Update(obj);
                _dbcontext.SaveChanges();
                TempData["Success"] = "Equipment Edited Successfully";
                return RedirectToAction("List");
            }
            return View(obj);
        }

        // Get
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var EquipmentFromDb = _dbcontext.NewEquipment.Find(id);

            if (EquipmentFromDb == null)
            {
                return NotFound();
            }
            return View(EquipmentFromDb);
        }

        // Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _dbcontext.NewEquipment.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _dbcontext.NewEquipment.Remove(obj);
            _dbcontext.SaveChanges();
            TempData["Success"] = "Equipment Deleted Successfully";
            return RedirectToAction("List");
        }
    }
}
