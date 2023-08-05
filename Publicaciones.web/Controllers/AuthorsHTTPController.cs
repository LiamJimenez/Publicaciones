using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Publicaciones.web.Models.Responses;
using Publicaciones.web.Services.HTTP;

namespace Publicaciones.web.Controllers
{
    public class AuthorsHttpController : Controller
    {
        private readonly IAuthorsHttpService authorsHttpService;
        private readonly ILogger<AuthorsHttpController> logger;

        public AuthorsHttpController(IAuthorsHttpService authorsHttpService, ILogger<AuthorsHttpController> logger)
        {
            this.authorsHttpService = authorsHttpService;
            this.logger = logger;
        }

        // GET: AuthorsHttpController
        public IActionResult Index()
        {
            try
            {
                AuthorsListResponse authorsList = authorsHttpService.Get();

                if (!authorsList.success)
                {
                    throw new Exception(authorsList.message);
                }

                return View(authorsList.data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while fetching authors.");
                ViewBag.Message = "An error occurred while fetching authors. Please try again later.";
                return View();
            }
        }

        // GET: AuthorsHttpController/Details/5
        public IActionResult Details(string au_id)
        {
            try
            {
                AuthorsDetailResponse authorsDetails = authorsHttpService.GetByau_id(au_id);

                if (!authorsDetails.success)
                {
                    throw new Exception(authorsDetails.message);
                }

                return View(authorsDetails.data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while fetching author details.");
                ViewBag.Message = "An error occurred while fetching author details. Please try again later.";
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: AuthorsHttpController/Edit/5
        public IActionResult Edit(string au_id)
        {
            try
            {
                AuthorsDetailResponse details = authorsHttpService.GetByau_id(au_id);

                if (!details.success || details.data == null)
                {
                    throw new Exception("Author details not found.");
                }

                return View(details.data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while fetching author details for editing.");
                ViewBag.Message = "An error occurred while fetching author details for editing. Please try again later.";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
