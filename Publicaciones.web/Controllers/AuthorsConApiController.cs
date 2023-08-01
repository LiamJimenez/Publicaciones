using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.web.Models.Responses;
using System.Text;

namespace School.Web.Controllers
{
    public class AuthorsConApiController : Controller
    {
        HttpClientHandler httpClientHandler = new HttpClientHandler();
        public AuthorsConApiController(IConfiguration configuration)
        {
            this.httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };

        }
        // GET: AuthorsConApiController
        public ActionResult Index()
        {
            AuthorsListResponse authorsList = new AuthorsListResponse();

            using (var httpClient = new HttpClient(this.httpClientHandler))
            {

                using (var response = httpClient.GetAsync("http://localhost:5008/api/Authors").Result)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;
                        authorsList = JsonConvert.DeserializeObject<AuthorsListResponse>(apiResponse);
                    }


                }
            }



            return View(authorsList.data);
        }

        // GET: AuthorsConApiController/Details/5
        public ActionResult Details(string au_id)
        {
            AuthorsDetailResponse authorsDetail = new AuthorsDetailResponse();


            using (var httpClient = new HttpClient(this.httpClientHandler))
            {

                using (var response = httpClient.GetAsync($"http://localhost:5008/api/Authors{au_id}").Result)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;
                        authorsDetail = JsonConvert.DeserializeObject<AuthorsDetailResponse>(apiResponse);
                    }


                }
            }



            return View(authorsDetail.data);
        }

        // GET: AuthorsConApiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorsConApiController/Create
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

        // GET: AuthorsConApiController/Edit/5
        public ActionResult Edit(string au_id)
        {
            AuthorsDetailResponse authorsDetail = new AuthorsDetailResponse();


            using (var httpClient = new HttpClient(this.httpClientHandler))
            {

                using (var response = httpClient.GetAsync($"http://localhost:5008/api/Authors{au_id}").Result)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;
                        authorsDetail = JsonConvert.DeserializeObject<AuthorsDetailResponse>(apiResponse);
                    }

                }
            }


            return View(authorsDetail.data);
        }

        // POST: AuthorsConApiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AuthorsUpdateDto authorsUpdateDto)
        {
            try
            {
                var authorsUpdateResponse = new AuthorsUpdateResponse();

                using (var httpClient = new HttpClient(this.httpClientHandler))
                {

                    StringContent content = new StringContent(JsonConvert.SerializeObject(authorsUpdateDto), Encoding.UTF8, "application/json");

                    using (var response = httpClient.PostAsync("http://localhost:5008/api/Authors", content).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = response.Content.ReadAsStringAsync().Result;

                            var result = JsonConvert.DeserializeObject<AuthorsUpdateResponse>(apiResponse);

                            if (!result.success)
                            {
                                ViewBag.Message = result.message;
                                return View();
                            }
                            return RedirectToAction(nameof(Index));

                        }
                        else
                        {
                            ViewBag.Message = "Error actualizando el author";
                            return View();
                        }



                    }
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorsConApiController/Delete/5
        public ActionResult Delete(string au_id)
        {
            return View();
        }

        // POST: AuthorsConApiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string au_id, IFormCollection collection)
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