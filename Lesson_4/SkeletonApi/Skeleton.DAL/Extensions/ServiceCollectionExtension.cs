﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Skeleton.DAL.Context;

namespace Skeleton.DAL.Extensions;

public static class ServiceCollectionExtension
{
    public static void InjectDatabaseServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);
    }

    private static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        // add database, use sql server
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(
                configuration["ConnectionString"]);
        });

    }
}