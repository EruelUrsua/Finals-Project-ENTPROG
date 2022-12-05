using FinalProject.DataModel;
using FinalProject.App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutoMapper;

namespace FinalProject.App.Controllers
{
    public class PatientController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public PatientController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(context.Patients.ToList());
        }

        public IActionResult Add()
        {
            return View(new PatientVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Add(PatientVM model)
        {
            Patient user = mapper.Map<Patient>(model);
            await context.AddAsync(user);
            await context.SaveChangesAsync();


            return RedirectToAction("Index");
            /*if (ModelState.IsValid)
            {
                //await context.AddAsync(model);
                //await context.SaveChangesAsync();
                

                //return RedirectToAction("Add");
            //}
            /*else
            {
                return View(model);
            }*/
        }
    }
}
