using Microsoft.Extensions.Logging;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Jobs;
using Publicaciones.Application.Extentions;
using Publicaciones.Domain.Entities;
using Publicaciones.Infraestructure.Exceptions;
using Publicaciones.Infraestructure.Interface;
using System;

namespace Publicaciones.Application.Service
{
    public class JobsService : IJobsService
    {
        private readonly IJobsRepository jobsRepository;
        private readonly ILogger<JobsService> logger;

        public JobsService(IJobsRepository jobsRepository,
                                  ILogger<JobsService> logger)
        {
            this.jobsRepository = jobsRepository;
            this.logger = logger;
        }

        public ServiceResult Get()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.jobsRepository.GetJobs();
            }
            catch (JobsException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los deparmentos";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetByjob_id(string job_id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.jobsRepository.GetJobsByjob_id(job_id);
            }
            catch (EmployeesException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los Trabajos";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult Remove(JobsRemoveDto model)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                this.jobsRepository.Remove(new Jobs()
                {
                    job_id = model.job_id,
                    deleted = model.deleted,
                    deleteddate = model.ChangeDate,
                    userdeleted = model.ChangeUser
                });

                result.Message = "Trabajo eliminado correctamente.";

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el departamento.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Save(JobsAddDto model)
        {
            ServiceResult result = new ServiceResult();

            if (!model.IsValidAuthors().Success)
                return result;


            try
            {
                var jobs = model.ConvertDtoAddToEntity();

                this.jobsRepository.Add(jobs);

                result.Message = "Trabajo agregado correctamente.";
            }
            catch (JobsException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el Trabajo.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Update(JobsUpdateDto model)
        {
            ServiceResult result = new ServiceResult();

            if (!model.IsValidAuthors().Success)
                return result;

            try
            {
                var jobs = model.ConvertDtoUpdateToEntity();

                this.jobsRepository.Update(jobs);

                result.Message = "Trabajo actualizado correctamente.";
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error actualizando el trabajo.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }



            return result;
        }
    }
}

