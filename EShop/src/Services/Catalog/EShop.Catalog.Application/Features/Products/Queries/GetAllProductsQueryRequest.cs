﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Catalog.Application.Features.Products.Queries
{
    //Bu da uçak!

    //istek:
    public record GetAllProductsQueryRequest():IRequest<IEnumerable<GetProductResponse>>;

    //istek sonucu:
    public record GetProductResponse(Guid Id, string Name, string Description, decimal Price, int? CategoryId, string ImageUrl);


}
