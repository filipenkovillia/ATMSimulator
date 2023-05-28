using Microsoft.EntityFrameworkCore;

namespace ATMSimulator.Model.AppDbContext
{
    public sealed class DbContextProvider
    {
        private static AppDbContext dbContext;

        public static void Initialize(DbContextOptions<AppDbContext> options)
        {
            dbContext = new AppDbContext(options);
        }

        public static AppDbContext GetDbContext()
        {
            if (dbContext == null)
            {
                throw new InvalidOperationException("DbContext has not been initialized. Call the Initialize method first.");
            }

            return dbContext;
        }
    }
}
