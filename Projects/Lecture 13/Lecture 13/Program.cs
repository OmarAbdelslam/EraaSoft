using Lecture_13.Data.DBWork;
using Lecture_13.IRepositoryContracts;
using Lecture_13.IServicesContracts;
using Lecture_13.Repsoitory;
using Lecture_13.Services;

namespace Lecture_13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();
            builder.Services.AddSingleton<DataProject>();
            builder.Services.AddScoped<IProjectsContracts,RepositoryProject>();
            builder.Services.AddScoped<IProjectServices,ProjectServices>();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            
           
            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}
