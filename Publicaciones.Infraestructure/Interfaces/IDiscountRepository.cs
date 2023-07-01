using System;
using System.Collections.Generic;
using Publicaciones.Infraestructure.Models;
using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Domain.Entities;

namespace Publicaciones.Infraestructure.Interfaces
{
    public interface IDiscountRepository : IBaseRepository<Discount>
    {
        List<DiscountModel> GetDiscounts();
        DiscountModel GetDiscount(decimal discount);
        List<DiscountModel> GetDiscountsType();
        DiscountModel GetDiscountType(string discountType);
    }
}
