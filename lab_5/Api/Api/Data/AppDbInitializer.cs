using Api.Data.Models;

namespace Api.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(context != null && !context.Algorithms.Any())
                {
                    context.Algorithms.AddRange(
                      
                    );
                }

            }
        }
    }
}
