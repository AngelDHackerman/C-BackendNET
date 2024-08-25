namespace SuperHeroesApp.Models { 
  // Creando clases abstractas, cada que creamos una propiedad abstracta, la clase hija es forzada a crearla tambien.
  internal abstract class Heroe { 
    public abstract string Nombre { get; set;}
    public abstract string SalvarElMundo();
    
    public string SalvarLaTierra() {  // Esta no es forzada a ser usada por la clase hija, ya que es un metodo normal.
      return $"{Nombre} ha salvado la tierra";
    }
  }
}