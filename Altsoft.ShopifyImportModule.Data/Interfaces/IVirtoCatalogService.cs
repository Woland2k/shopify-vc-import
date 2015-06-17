﻿using System.Collections.Generic;
using Altsoft.ShopifyImportModule.Data.Models;
using VirtoCommerce.CatalogModule.Data.Model;
using Catalog = VirtoCommerce.Domain.Catalog.Model.Catalog;

namespace Altsoft.ShopifyImportModule.Data.Interfaces
{
    public interface IVirtoCatalogService
    {
        PaginationResult<Catalog> GetCatalogs();
        PaginationResult<VirtoCommerce.Domain.Catalog.Model.Category> GetCategories(VirtoCategorySearchCriteria searchCriteria);
        CategoryBase AddCategory(VirtoCategory virtoCategory);
        void AddProduct(Product virtoProduct, List<CategoryBase> virtoCatalogId, IEnumerable<string> virtoCategoryIds);
        void CommitChanges();
        List<string> CheckCodesExistance(List<string> code);
    }
}