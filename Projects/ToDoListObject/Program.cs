using ToDoListObject.Data;

namespace ToDoListObject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<DBWork>();
            var app = builder.Build();

            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}
