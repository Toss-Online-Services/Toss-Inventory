﻿using Domain.Entities.Catalog;
using Domain.Infrastructure;
using Infrastructure.Data.EntityConfigurations;
using Infrastructure.IntegrationEventLogEF;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;

/// <remarks>
/// Add migrations using the following command inside the 'Catalog.API' project directory:
///
/// dotnet ef migrations add --context CatalogContext [migration-name]
/// </remarks>
public class CatalogContext : DbContext, IUnitOfWork
{
    public CatalogContext(DbContextOptions<CatalogContext> options, IConfiguration configuration) : base(options)
    {
    }

    public bool HasActiveTransaction => true;
    public DbSet<CatalogItem> CatalogItems { get; set; }
    public DbSet<CatalogBrand> CatalogBrands { get; set; }
    public DbSet<CatalogType> CatalogTypes { get; set; }
    //public DbSet<Product> Products { get; set; }

    public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasPostgresExtension("vector");
        builder.ApplyConfiguration(new CatalogBrandEntityTypeConfiguration());
        builder.ApplyConfiguration(new CatalogTypeEntityTypeConfiguration());
        builder.ApplyConfiguration(new CatalogItemEntityTypeConfiguration());
        //builder.ApplyConfiguration(new ProductConfiguration());

        // Add the outbox table to this context
        builder.UseIntegrationEventLogs();
    }
}
