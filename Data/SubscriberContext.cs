using Microsoft.EntityFrameworkCore;

namespace Subscriber.Data
{
    public class SubscriberContext : DbContext
    {
        public SubscriberContext(DbContextOptions<SubscriberContext> options) : base(options)
        {
        }
        #region DbSet
        public DbSet<SubscriberData> Subscribers { get; set; } = null!;
        #endregion 
    }
}
