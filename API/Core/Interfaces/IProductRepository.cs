﻿using API.Entities;

namespace API.Core.Interfaces
{
    public interface IProductRepository
    {

        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductsAsync();

    }
}
