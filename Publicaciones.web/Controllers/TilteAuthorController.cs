using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Publicaciones.Application.Contract;
using Publicaciones.Infraestructure.Models;
using Publicaciones.Application.Dtos.titleauthor;

namespace Publicaciones.web.Controllers 
{
    public class TitleAuthorController : Controller
    {
        private readonly ITitleAuthorService _titleAuthorService;

        public TitleAuthorController(ITitleAuthorService _titleAuthorService)
        {
            this._titleAuthorService = _titleAuthorService;
        }
        // Get TitleAutorController
        public ActionResult Index() 
        {
            var result = _titleAuthorService.Get();

            if (!result.Success) 
                ViewBag.Message = result.Message;

            var titleAuthor = (List<titleAuthorModel>)result.Data;

            return View(titleAuthor);
            
        }
        // Get: TitleAuthorController/Detail/5
        public ActionResult Details(string au_id) 
        {
            var result = _titleAuthorService.GetByau_id(au_id);

            if (!result.Success)
                ViewBag.Message = result.Message;

            var titleAuthor = (titleAuthorModel)result.Data;

            return View(titleAuthor);
        }
        // GET: TitleAuthorsController/Create
        public ActionResult Create() 
        {
            return View();
        }

        // POST: TitleAuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(TitleAuthorAddDto titleAuthorAddDto) 
        {
            try
            {
                var result = this._titleAuthorService.Save(titleAuthorAddDto);

                if (!result.Success)
                {
                    ViewBag.Message = result.Message;
                    return View();
                }

                return RedirectToAction(nameof(Index));
            }
            catch 
            {
                return View();
            }
        }
        // GET: TitleauthorController/Edit/5

        public ActionResult Edit(string au_id) 
        {
            var result = _titleAuthorService.GetByau_id(au_id);

            if (!result.Success)
                ViewBag.Message = result.Message;

            var titleAuthor = (titleAuthorModel)result.Data;

            return View(titleAuthor);
        }

        // POST: TitleauthorsController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(titleAuthorUpdateDto titleAuthorUpdateDto) 
        {
            try
            {
                var result = this._titleAuthorService.Update(titleAuthorUpdateDto);

                if (!result.Success)
                {
                    ViewBag.Message = result.Message;
                    return View();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}