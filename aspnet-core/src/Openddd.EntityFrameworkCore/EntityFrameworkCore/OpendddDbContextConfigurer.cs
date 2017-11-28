using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Openddd.EntityFrameworkCore
{
    public static class OpendddDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OpendddDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OpendddDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
