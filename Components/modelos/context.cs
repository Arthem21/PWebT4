using Microsoft.EntityFrameworkCore;

class Context :DbContext{

    public DbSet<Multimedia>? multimedias{set; get;}=null;
    public DbSet<personajes>? personajes{set; get;}=null;
    public Context(DbContextOptions<Context>options):base(options){}


}