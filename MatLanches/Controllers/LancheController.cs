﻿using MatLanches.Repositories.Interfaces;
using MatLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MatLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {

            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            
            return View(lanchesListViewModel);
        
        }
    }
}
