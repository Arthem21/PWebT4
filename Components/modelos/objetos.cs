
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore;


public enum tipoEntidad{

    serie='s',
    pelicula='p',
    libro='l'
}
class Multimedia(){

    public string id {set;get;}=" ";
    public string nombre {set;get;}=" ";
    public string? pais {set;get;}
    public string? idioma {set;get;}
    public string? foto {set;get;}
    public string? resumen {set;get;}
    public tipoEntidad tipo {set;get;}= tipoEntidad.serie;
    public List<personajes> personajes {set;get;}= new List<personajes>();

    protected void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<Multimedia>().HasNoKey();
    }
    

}


class personajes(){

    public string id {set;get;}= Guid.NewGuid().ToString();
    public string nombre {set;get;}=" ";
    public string? apodo {set;get;}
    public string? raza {set;get;}
    public string? foto {set;get;}
    public int? edad {set;get;}
    public string? habilidad {set;get;}

    public string multimediaID {get; set;}="";
    public Multimedia multimedia {set;get;}= new Multimedia();

    protected void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<personajes>().HasNoKey();
}
}