using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Publicaciones.web.Models.Responses;
using Publicaciones.web.Services;
using Publicaciones.web.Services.HTTP;

namespace Publicaciones.web.Controllers
{
    public class AuthorsSinApiController : Controller
    {
        private readonly IAuthorsHttpService authorsApiService;

        public AuthorsSinApiController(IAuthorsHttpService authorsApiService)
        {
            
            this.authorsApiService = authorsApiService;
        }
        // GET: AuthorsSinApiController
        public ActionResult Index()
        {
            AuthorsListResponse authorsReponse = new AuthorsListResponse();


            //authorsReponse = this.authorsApiService.GetAuthors();


            return View(authorsReponse.data);
        }

        // GET: AuthorsSinApiController/Details/5
        public ActionResult Details(string au_id)
        {
            AuthorsDetailResponse authorsDetailResponse = this.authorsApiService.GetByau_id(au_id);


            return View(authorsDetailResponse.data);
        }

        // GET: AuthorsSinApiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorsSinApiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorsSinApiController/Edit/5
        public ActionResult Edit(string au_id)
        {
            AuthorsDetailResponse authotrsDetailResponse = new AuthorsDetailResponse();


            return View(authotrsDetailResponse.data);
        }

        // POST: AAuthorsSinApiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string au_id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}