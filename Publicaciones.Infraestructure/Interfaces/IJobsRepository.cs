
using System;
using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Domain.Entities;
using System.Collections.Generic;
using Publicaciones.Infraestructure.Models;

namespace Publicaciones.Infraestructure.Interface
{
    public interface IJobsRepository : IBaseRepository<Jobs>
    {
        List<JobsModel> GetJobs();
        JobsModel GetJobsByemp_id(int id);
    }

}

