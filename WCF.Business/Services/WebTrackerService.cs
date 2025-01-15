using System.Threading.Tasks;

namespace WCF.Business.Services
{
    public class WebTrackerService
    {
        public async Task AddWebTrackerAsync(WebTrackerRequest request)
        {
            using (var context = new AppDbContext())
            {
                context.WebTrackers.Add(new WebTracker { SourceIp = request.SourceIp, TimeOfAction = request.TimeOfAction, URLRequest = request.URLRequest });
                await context.SaveChangesAsync();
            }
        }
    }
}
