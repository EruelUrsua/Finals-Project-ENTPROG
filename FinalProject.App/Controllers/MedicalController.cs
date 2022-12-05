using AutoMapper;
using FinalProject.App.Models;
using FinalProject.App.Models.Repositories;
using FinalProject.DataModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.App.Controllers
{
    public class MedicalController : Controller
    {
        private readonly IMedicalRepo repo;
        private readonly IMapper mapper;
        public MedicalController(IMedicalRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(mapper.Map<List<MedicalVM>>(await repo.GetAllAsync()));
        }

        public IActionResult Add()
        {
            return View(new MedicalVM());
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(MedicalVM model)
        {
            if (ModelState.IsValid)
            {

                await repo.AddAsync(mapper.Map<Medical>(model));
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            
            }
        }

    }
}
