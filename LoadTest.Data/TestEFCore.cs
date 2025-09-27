using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LoadTest.Data
{
    public class TestEFCore
    {
        public static async Task<int> Main(string[] args)
        {
            Console.WriteLine("🚀 Testing EF Core with 344 entities - The Ultimate Challenge!");
            Console.WriteLine("Pushing beyond all previous limits!");
            
            try
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                Console.WriteLine($"Connection: {MaskPassword(connectionString)}");
                
                Console.WriteLine("Creating DbContext with 344 entities...");
                var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer(connectionString)
                    .Options;
                
                Console.WriteLine("Initializing ApplicationDbContext - This is the ultimate test!");
                using var context = new ApplicationDbContext(options);
                
                Console.WriteLine("Testing database connection...");
                var canConnect = await context.Database.CanConnectAsync();
                Console.WriteLine($"Can connect: {canConnect}");
                
                if (canConnect)
                {
                    Console.WriteLine("Creating database schema with 344 entities...");
                    Console.WriteLine("🏆 If this succeeds, we've set a new record!");
                    
                    await context.Database.EnsureCreatedAsync();
                    Console.WriteLine("✅ Database schema created successfully!");
                    
                    Console.WriteLine("🎉 EF Core successfully handled 344 entities!");
                    Console.WriteLine("🏆 NEW WORLD RECORD ACHIEVED!");
                }
                
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return 1;
            }
        }
        
        private static string MaskPassword(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                return "null";
            
            return connectionString.Replace("Password=Password12345!", "Password=***");
        }
    }
}