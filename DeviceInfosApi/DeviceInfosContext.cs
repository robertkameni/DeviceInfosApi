using Microsoft.EntityFrameworkCore;

namespace DeviceInfosApi
{
    public class DeviceInfosContext : DbContext
    {
        public DeviceInfosContext(DbContextOptions<DeviceInfosContext> options) : base(options)
        {

        }

        //Neue Datenbank Tabelle
        public DbSet<DeviceInfos> DevicesInfos { get; set; }
    }
}
