using AppFinalCaminhao.Models;
using Microsoft.EntityFrameworkCore;

namespace AppFinalCaminhao.Data
{
    public class BancoContext :DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<Caminhao> Caminhoes { get; set; }
    }
}
