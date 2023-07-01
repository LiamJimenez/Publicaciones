using System;
using System.Collections.Generic;
using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Domain.Entities;
using Publicaciones.Infraestructure.Models;

namespace Publicaciones.Infraestructure.Interfaces
{
    public interface ISalesRepository
    {
        List<SalesModel> GetSales();
        SalesModel GetSale(string ord_num);
    }
}
