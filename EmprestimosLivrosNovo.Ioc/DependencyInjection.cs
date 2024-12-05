//using EmprestimosLivrosNovo.Application.Interfaces;
//using EmprestimosLivrosNovo.Application.Services;
//using EmprestimosLivrosNovo.Infra.Data;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EmprestimosLivrosNovo.Infra.Ioc
//{
//    class DependencyInjection
//    {
//        public static class DependencyInjection
//        {
//            public static IServiceCollection AddInfrastructure(this IServiceCollection services,
//                IConfiguration configuration)
//            {
//                services.AddDbContext<ApplicationDBContext>(options =>
//                {
//                    options.UserSqlServer(configuration.GetConnectionString("DefaultConnection"),
//                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
//                });
//                services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

//                services.AddScoped<IClienteRepository, ClienteRepository>();
//                services.AddScoped<IClienteService, ClienteService>();

//                return services;
//            }
//        }
//    }
//}
