using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Publicaciones.Application.Contract;
using Publicaciones.Infraestructure.Models;
using Publicaciones.Application.Dtos.Authors;

namespace Publicaciones.web.Controllers
{
    public class AuthorsController : Controller

    {
        private readonly IAuthorsService authorsService;

        public AuthorsController(IAuthorsService authorsService)
        {
            this.authorsService = authorsService;
        }
        // GET: AuthorsController
        public ActionResult Index()
        {

            var result = authorsService.Get();

            if (!result.Success)
                ViewBag.Message = result.Message;

            var authors = (List<AuthorsModel>)result.Data;

            return View(authors);

        }

        // GET: AuthorsController/Details/5
        public ActionResult Details(string au_id)
        {
            var result = authorsService.GetByau_id(au_id);

            if (!result.Success)
                ViewBag.Message = result.Message;


            var authors = (AuthorsModel)result.Data;

            return View(authors);
        }

        // GET: AuthorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AuthorsAddDto authorsAddDto)
        {
            try
            {

                var result = this.authorsService.Save(authorsAddDto);


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

        // GET: AuthorsController/Edit/5
        public ActionResult Edit(string au_id)
        {
            var result = authorsService.GetByau_id(au_id);

            if (!result.Success)
                ViewBag.Message = result.Message;


            var authors = (AuthorsModel)result.Data;

            return View(authors);
        }

        // POST: AuthorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AuthorsUpdateDto authorsUpdateDto)
        {
            try
            {
                var result = this.authorsService.Update(authorsUpdateDto);


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