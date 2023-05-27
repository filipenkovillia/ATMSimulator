using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Model.AppDbContext
{
    public sealed class DbContextProvider
    {
        private static readonly Lazy<DbContextProvider> instance = new Lazy<DbContextProvider>(() => new DbContextProvider());
        private readonly AppDbContext _dbContext;

        private DbContextProvider()
        {
            _dbContext = new AppDbContext();
        }

        public static DbContextProvider Instance => instance.Value;

        public AppDbContext GetDbContext()
        {
            return _dbContext;
        }
    }
}
