using System.Text; // Necesario para usar StringBuilder

namespace SuperHeroesApp.Models { 
    class SuperHeroe { 
  public int Id;
  public string Nombre;
  public string IdentidadSecreta;
  public string Ciudad;
  public List<SuperPoder> SuperPoderes;  // List<T> es una clase genérica en C# que representa una lista (o colección) de objetos de un tipo específico. En este caso, SuperPoder es el tipo de objeto que la lista va a contener. 
  public bool PuedeVolar;


    public SuperHeroe() {  // constructor
    Id = 1;  // el ID por defecto sera 1
    SuperPoderes = new List<SuperPoder>();
    PuedeVolar = false;
  }

  public string UsarSuperPoderes () {  // void significa que no va a retornar ningun valor, todo sera usado internamente.
    StringBuilder sb = new StringBuilder();

    foreach (var item in SuperPoderes) { 
      sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}!!");
    }

    return sb.ToString ();
  }
}
}