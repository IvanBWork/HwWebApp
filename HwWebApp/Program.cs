using HwWebApp.Graph.Mutation;
using HwWebApp.Graph.Query;
using HwWebApp.Mapper;
using HwWebApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HwWebApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();
            //builder.Services.AddDbContext<StorageContext>(option => option.UseSqlServer(builder
            //    .Configuration.GetConnectionString("db")).LogTo(Console.WriteLine));
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductGroupRepository, ProductGroupRepository>();
            builder.Services.AddScoped<IStorageRepository, StorageRepository>();
            builder.Services.AddAutoMapper(typeof(MapperProfile));
            builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
            builder.Services.AddMemoryCache();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            //app.UseAuthorization();

            //app.MapControllers();

            app.MapGraphQL();

            app.Run();
        }
    }
}
