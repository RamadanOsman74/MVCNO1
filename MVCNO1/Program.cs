namespace MVCNO1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews(); // add session or cookie
            builder.Services.AddSession();

            var app = builder.Build();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync(" middleware no 1 \n");
            //    await next();
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync(" middleware no 2 \n");
            //    await next();
            //});
            //app.Run(async (context) =>
            //{
            //     await context.Response.WriteAsync(" middleware no 3 \n");

            //});




            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute(
                "Route1", "dept/{id:int}",
                new
                {
                    controller= "Dept",
                    action = "Details"
                }
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
	}
}
