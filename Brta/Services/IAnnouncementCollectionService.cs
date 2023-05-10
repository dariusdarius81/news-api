using NewsApi.Models;

namespace NewsApi.Services
{
    public interface IAnnouncementCollectionService : ICollectionService<Announcement>
    {
        List<Announcement> GetAnnouncementsByCategoryId(string categoryId);
    }
}