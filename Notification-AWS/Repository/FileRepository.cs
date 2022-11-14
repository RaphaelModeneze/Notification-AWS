using Notification_AWS.Helpers;
using Notification_AWS.Models;

namespace Notification_AWS.Repository
{
    public class FileRepository : IFileRepository, IDisposable
    {
        private readonly DataContext dataContext;

        public FileRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Files> GetFiles()
        {
            return dataContext.Files.ToList();
        }
        public void InsertFile(Files files)
        {
            dataContext.Files.Add(files);
        }

        public void Save()
        {
            dataContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dataContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
