using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.web.Models.Responses;
using System.Text;

namespace Publicaciones.Web.Controllers
{
    public class AuthorsController : Controller
    {
        HttpClientHandler httpClientHandler = new HttpClientHandler();
        public AuthorsController(IConfiguration configuration)
        {
            this.httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };

        }
        // GET: AuthorsController
        public ActionResult Index()
        {
            AuthorsListResponse authorReponse = new AuthorsListResponse();

            using (var httpClient = new HttpClient(this.httpClientHandler))
            {

                using (var response = httpClient.GetAsync("http://localhost:5008/api/Authors").Result)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;
                        authorReponse = JsonConvert.DeserializeObject<AuthorsListResponse>(apiResponse);
                    }


                }
            }
            return View(authorReponse.data);
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(string au_id)
        {
            AuthorsDetailResponse authorDetailResponse = new AuthorsDetailResponse();

            using (var httpClient = new HttpClient(this.httpClientHandler))
            {

                using (var response = httpClient.GetAsync("http://localhost:5008/api/Authors?au_id=" + au_id).Result)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;
                        authorDetailResponse = JsonConvert.DeserializeObject<AuthorsDetailResponse>(apiResponse);
                    }


                }
            }
            return View(authorDetailResponse.data);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
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

        // GET: AuthorController/Edit/5
        public ActionResult Edit(string au_id)
        {
            AuthorsDetailResponse authorDetailResponse = new AuthorsDetailResponse();

            using (var httpClient = new HttpClient(this.httpClientHandler))
            {

                using (var response = httpClient.GetAsync("http://localhost:5008/api/Authors?au_id=" + au_id).Result)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;
                        authorDetailResponse = JsonConvert.DeserializeObject<AuthorsDetailResponse>(apiResponse);
                    }


                }
            }
            return View(authorDetailResponse.data);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AuthorsUpdateDto authorsUpdateDto)
        {
            try
            {

                var AthorsUpdateDto = new AuthorsUpdateDto();



                using (var httpClient = new HttpClient(this.httpClientHandler))
                {


                    StringContent content = new StringContent(JsonConvert.SerializeObject(authorsUpdateDto), Encoding.UTF8, "application/json");

                    using (var response = httpClient.PostAsync("http://localhost:5008/api/Authors/Update", content).Result)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;

                        var result = JsonConvert.DeserializeObject<AuthorsUpdateDto>(apiResponse);
                    }
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