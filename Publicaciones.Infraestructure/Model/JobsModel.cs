using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Publicaciones.Infraestructure.Models
{
	public class JobsModel
	{
		[Key]
		public char job_id { get; set; }
		public string job_disc { get; set; }
		public byte min_lvl { get; set; }
	}
}