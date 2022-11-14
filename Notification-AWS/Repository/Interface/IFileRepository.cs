using Notification_AWS.Models;

namespace Notification_AWS.Repository
{
    public interface IFileRepository
    {
        void Dispose();
        IEnumerable<Files> GetFiles();
        void InsertFile(Files files);
        void Save();
    }
}