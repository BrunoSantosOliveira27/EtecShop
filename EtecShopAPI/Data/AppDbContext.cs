using EtecShopAPI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace EtecShopAPI.Data;

public class AppDbContext : Dbcontext
 {
    public AppContext(DbContextOptions<AppDbContext> options) base(options) { get; set; }
    {
    }

    public Dbset<Categoria> Categorias { get; set; }    
    public Dbset<Produto> Produtos { get; set; }

    Protected override void OnModelCreating(ModelBuilder modelBuider)
    {
        base.OnModelCreating(modelBuider);
    }


}
