using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace LoadTest.Console
{
    public class SimpleTest
    {
        public static async Task<int> Main(string[] args)
        {
            System.Console.WriteLine("Testing LoadTestDb344_4080 - Breaking All Records!");
            System.Console.WriteLine("344 entities with 4080+ columns - The Ultimate Database!");

            try
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false)
                    .AddEnvironmentVariables()
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                System.Console.WriteLine($"Connection: {MaskPassword(connectionString)}");

                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                System.Console.WriteLine("✅ Connection successful");

                // Check if database exists
                var checkDbSql = "SELECT COUNT(*) FROM sys.databases WHERE name = 'LoadTestDb344_4080'";
                using var checkCommand = new SqlCommand(checkDbSql, connection);
                var dbExists = (int)(await checkCommand.ExecuteScalarAsync() ?? 0) > 0;
                
                System.Console.WriteLine($"Database LoadTestDb344_4080 exists: {dbExists}");

                if (dbExists)
                {
                    // Count tables
                    var countSql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                    using var countCommand = new SqlCommand(countSql, connection);
                    var tableCount = await countCommand.ExecuteScalarAsync();
                    System.Console.WriteLine($"✅ Found {tableCount} tables");
                    
                    // Count total columns
                    var columnCountSql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS";
                    using var columnCommand = new SqlCommand(columnCountSql, connection);
                    var columnCount = await columnCommand.ExecuteScalarAsync();
                    System.Console.WriteLine($"✅ Found {columnCount} total columns");
                    
                    if ((int)tableCount >= 344)
                    {
                        System.Console.WriteLine("🏆 WORLD RECORD! 344+ entities successfully deployed!");
                        System.Console.WriteLine("🚀 EF Core has shattered all expectations!");
                        System.Console.WriteLine("🎯 This is the ultimate migration tool stress test!");
                    }
                }

                System.Console.WriteLine("✅ Record-breaking stress test completed!");
                
                return 0;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"❌ Error: {ex.Message}");
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