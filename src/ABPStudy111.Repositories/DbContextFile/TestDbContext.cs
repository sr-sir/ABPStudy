using Microsoft.EntityFrameworkCore;
using ABPStudy111.Core.Dto;
using ABPStudy.Core.Dto;

namespace ABPStudy111.Repositories.DbContextFile
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }
        public DbSet<Orders> Tb_orders { get; set; }
        public DbSet<Settleorder> Tb_settleorder { get; set; }
        public DbSet<Picture> Tb_picture { get; set; }
        public DbSet<PictureType> Tb_picturetype { get; set; }
    }
}
