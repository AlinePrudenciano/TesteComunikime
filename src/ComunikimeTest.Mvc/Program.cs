using AutoMapper;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Domain.Repositories;
using ComunikimeTest.Domain.Services;
using ComunikimeTest.Infra.Context;
using ComunikimeTest.Infra.Repositories;
using ComunikimeTest.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ComunikimeTest.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureServices(builder.Services);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<IStockService, StockService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();

            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IOrderItemService, OrderItemService>();

            services.AddScoped<IRepository<BaseEntity>, Repository<BaseEntity>>();
            services.AddScoped<IService<BaseEntity>, Service<BaseEntity>>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderModel>();
                cfg.CreateMap<OrderModel, Order>();

                cfg.CreateMap<OrderItem, OrderItemModel>();
                cfg.CreateMap<OrderItemModel, OrderItem>();

                cfg.CreateMap<User, UserModel>();
                cfg.CreateMap<UserModel, User>();

                cfg.CreateMap<Product, ProductModel>();
                cfg.CreateMap<ProductModel, Product>();

                cfg.CreateMap<Stock, StockModel>();
                cfg.CreateMap<StockModel, Stock>();

                cfg.CreateMap<BaseEntity, BaseEntity>();
                cfg.CreateMap<BaseEntity, BaseEntity>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddDbContext<ContextDb>(options => options.UseInMemoryDatabase("ComunikimeTest"));

            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        }
    }
}