using Notification_AWS.Helpers;

namespace Notification_AWS
{
    public class Seed
    {
        public static void Seed1(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            DataContext context = scope.ServiceProvider.GetRequiredService<DataContext>();

            // use context
        }
    }
}
