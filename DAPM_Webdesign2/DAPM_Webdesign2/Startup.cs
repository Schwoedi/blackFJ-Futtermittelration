namespace DAPM_Webdesign2
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ...

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "meineRationen",
                    pattern: "MeineRationen/{option}",
                    defaults: new { controller = "MeineRationen", action = "Rationen" });

                endpoints.MapControllerRoute(
                    name: "fmTabelle",
                    pattern: "FMTabelle",
                    defaults: new { controller = "FMTabelle", action = "Futtermittel" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
