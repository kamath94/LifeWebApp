using System.Data.Common;

namespace lifedashboard.Models
{
    public class DBUtil
    {
        public async Task DbConnectionAsync()
        {
            var url = Environment.GetEnvironmentVariable("https://jgmyttcfvaidryotbdfy.supabase.co");
            var key = Environment.GetEnvironmentVariable("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImpnbXl0dGNmdmFpZHJ5b3RiZGZ5Iiwicm9sZSI6ImFub24iLCJpYXQiOjE2OTg0MTQxOTIsImV4cCI6MjAxMzk5MDE5Mn0.BytOvBaP2iyyh3mdZ67sKHVGoojliguhbSj88XO2JVI");

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
        }
    }
}
