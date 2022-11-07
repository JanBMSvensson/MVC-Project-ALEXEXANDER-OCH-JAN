namespace Gr44_MVC_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            WebApplication app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            //app.UseEndpoints(endpoints =>
            //    endpoints.MapControllerRoute("potato",
            //    "{Controller=Home}/{Action=About}"));


            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("carrot", "FeverCheck", new { Controller = "Doctor", Action = "Index" }));

            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("potatistärklese", "GuessingGame", new { Controller = "Guess", Action = "GuessNumber" }));

            app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

            app.Run();
        }
    }
}