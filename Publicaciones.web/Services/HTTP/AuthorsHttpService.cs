using Publicaciones.web.Models.Responses;

namespace Publicaciones.web.Services.HTTP
{
    public class AuthorsHttpService : IAuthorsHttpService
    {
        private readonly IHttpRepository httpRepository;
        private readonly ILogger<AuthorsHttpService> logger;
        private string baseUrl = string.Empty;

        //http://localhost:5008/api/Authors

        public AuthorsHttpService(IHttpRepository httpRepository,
                                  IConfiguration configuration,
                                  ILogger<AuthorsHttpService> logger)
        {
            this.httpRepository = httpRepository;
            this.logger = logger;
            this.baseUrl = configuration["ApiConfig:baseUrl"];
        }

        public AuthorsListResponse Get()
        {
            AuthorsListResponse? authorsList = new();
            string url = $" {baseUrl}Authors/GetAuthor";

            try
            {
                authorsList = httpRepository.Get(url, authorsList);

                if (authorsList == null) throw new Exception();
            }
            catch (Exception ex)
            {

            }

            return authorsList;
        }

        public AuthorsDetailResponse GetByau_id(string au_id)
        {
            AuthorsDetailResponse? authorsDetails = new();
            string url = $" {baseUrl}Author/GetUserByau_ID?id={au_id}";

            try
            {
                authorsDetails = httpRepository.Get(url, authorsDetails);

                if (authorsDetails == null) throw new Exception();

            }
            catch (Exception ex)
            {

            }

            return authorsDetails;
        }
    }
}

       

       