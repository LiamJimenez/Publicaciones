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
	public class EmployeesRepository : BaseRepository<Employees>, IEmployeesRepository
	{
		private readonly ILogger<EmployeesRepository> logger;
		private readonly PublicacionesContext context;

		public EmployeesRepository(ILogger<EmployeesRepository> logger,
			PublicacionesContext context) : base(context)
		{
			this.logger = logger;
			this.context = context;
		}
		public override void Add(Employees entity)
		{

			if (this.Exists(cd => cd.emp_fname == entity.emp_fname))
				throw new EmployeesException("El Empleado ya existe.");

			base.SaveChanges();
			base.Add(entity);
		}

		public override void Update(Employees entity)
		{
			try
			{

				Employees employeesToUpdate = base.GetEntity(entity.emp_id);

				employeesToUpdate.emp_id = entity.emp_id;
				employeesToUpdate.modifydate = entity.modifydate;
				employeesToUpdate.emp_lname = entity.emp_lname;
				employeesToUpdate.emp_fname = entity.emp_fname;
				employeesToUpdate.usermod = entity.usermod;
				employeesToUpdate.minit = entity.minit;
				employeesToUpdate.job_id = entity.job_id;
				employeesToUpdate.job_lvl = entity.job_lvl;
				employeesToUpdate.pub_id = entity.pub_id;
				employeesToUpdate.hire_date = entity.hire_date;

				base.Update(employeesToUpdate);
				base.SaveChanges();
			}
			catch (Exception ex)
			{

				this.logger.LogError("Error actualizando al empleado", ex.ToString());
			}
		}
		public override void Remove(Employees entity)
		{
			try
			{
				Employees employeesToRemove = this.GetEntity(entity.emp_id);

				employeesToRemove.deleted = entity.deleted;
				employeesToRemove.deleteddate = entity.deleteddate;
				employeesToRemove.userdeleted = entity.userdeleted;

				this.context.Employees.Update(employeesToRemove);
				this.context.SaveChanges();

			}
			catch (Exception ex)
			{

				this.logger.LogError("Error eliminando el empleado", ex.ToString());
			}
		}



		public EmployeesModel GetEmployeesByemp_id(string emp_id)
		{
			EmployeesModel employeesModel = new EmployeesModel();


			try
			{
				Employees employees = this.GetEntity(emp_id);

				employeesToUpdate.emp_id = entity.emp_id;
				employeesToUpdate.modifydate = entity.modifydate;
				employeesToUpdate.emp_lname = entity.emp_lname;
				employeesToUpdate.emp_fname = entity.emp_fname;
				employeesToUpdate.usermod = entity.usermod;
				employeesToUpdate.minit = entity.minit;
				employeesToUpdate.job_id = entity.job_id;
				employeesToUpdate.job_lvl = entity.job_lvl;
				employeesToUpdate.pub_id = entity.pub_id;
				employeesToUpdate.hire_date = entity.hire_date;

			}
			catch (Exception ex)
			{

				this.logger.LogError("Error obteniendo el empleado", ex.ToString());
			}

			return employeesModel;
		}
		public List<EmployeesModel> GetEmployees()
		{

			List<EmployeesModel> employees = new List<EmployeesModel>();

			try
			{
				employees = this.context.Employees
				.Where(cd => !cd.deleted)
				.Select(de => new EmployeesModel()
				{
					emp_id = de.emp_id,
					emp_fname = de.emp_fname,
					emp_lname = de.emp_lname,

				}).ToList();
			}
			catch (Exception ex)
			{

				this.logger.LogError("Error obteniendo los departamentos", ex.ToString());
			}

			return employees;
		}
	}
}
