using Microsoft.EntityFrameworkCore;

namespace lifedashboard.Models
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DBConfig(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DBConfig>>()))
            {
                // Look for any movies.
                if (context.MemberDetails.Any())
                {
                    return;   // DB has been seeded
                }
                context.MemberDetails.AddRange(
                    new MemberDetails
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
