using Microsoft.Extensions.Logging;
using Publicaciones.Domain.Entities;
using Publicaciones.Infraestructure.Context;
using Publicaciones.Infraestructure.Core;
using Publicaciones.Infraestructure.Exceptions;
using Publicaciones.Infraestructure.Interface;
using Publicaciones.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Publicaciones.Infraestructure.Repositories
{
	public class JobsRepository : BaseRepository<Jobs>, IJobsRepository
	{
		private readonly ILogger<JobsRepository> logger;
		private readonly PublicacionesContext context;

		public JobsRepository(ILogger<JobsRepository> logger,
			PublicacionesContext context) : base(context)
		{
			this.logger = logger;
			this.context = context;
		}
		public override void Add(Jobs entity)
		{

			if (this.Exists(cd => cd.job_id == entity.job_id))
				throw new JobsException("El Trabajo ya existe.");

			base.SaveChanges();
			base.Add(entity);
		}

		public override void Update(Jobs entity)
		{
			try
			{

				Jobs jobsToUpdate = base.GetEntity(entity.job_id);

				jobsToUpdate.job_id = entity.job_id;
				jobsToUpdate.modifydate = entity.modifydate;
				jobsToUpdate.job_disc = entity.job_disc;
				jobsToUpdate.jobs_min_lvl = entity.job_min_lvl;
				jobsToUpdate.usermod = entity.usermod;

				base.Update(jobsToUpdate);
				base.SaveChanges();
			}
			catch (Exception ex)
			{

				this.logger.LogError("Error actualizando al trabajo", ex.ToString());
			}
		}
		public override void Remove(Jobs entity)
		{
			try
			{
				Jobs jobsToRemove = this.GetEntity(entity.job_id);

				jobsToRemove.deleted = entity.deleted;
				jobsToRemove.deleteddate = entity.deleteddate;
				jobsToRemove.userdeleted = entity.userdeleted;

				this.context.jobs.Update(jobsToRemove);
				this.context.SaveChanges();

			}
			catch (Exception ex)
			{

				this.logger.LogError("Error eliminando el trabajo", ex.ToString());
			}
		}



		public JobsModel GetJobsByjob_id(string job_id)
		{
			JobsModel jobsModel = new JobsModel();


			try
			{
				Jobs jobs = this.GetEntity(job_id);

				jobsToUpdate.job_id = entity.job_id;
				jobsToUpdate.modifydate = entity.modifydate;
				jobsToUpdate.job_disc = entity.job_disc;
				jobsToUpdate.jobs_min_lvl = entity.job_min_lvl;
				jobsToUpdate.usermod = entity.usermod;

			}
			catch (Exception ex)
			{

				this.logger.LogError("Error obteniendo el trabajo", ex.ToString());
			}

			return jobsModel;
		}
		public List<jobsModel> GetJobs()
		{

			List<JobsModel> jobs = new List<JobsModel>();

			try
			{
				jobs = this.context.Jobs
				.Where(cd => !cd.deleted)
				.Select(de => new JobsModel()
				{
					job_id = de.job_id,
					job_disc= de.job_disc,
					min_lvl = de.min_lvl,

				}).ToList();
			}
			catch (Exception ex)
			{

				this.logger.LogError("Error obteniendo los departamentos", ex.ToString());
			}

			return jobs;
		}
	}
}
