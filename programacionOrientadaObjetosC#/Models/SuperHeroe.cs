using System.Text; // Necesario para usar StringBuilder

namespace SuperHeroesApp.Models
{  // asi es como exportamos esto al archivo Program.cs
  class SuperHeroe : Heroe
  {
    private string _Nombre;
    public int Id;
    // Asi es como se hace el encapsulamiento de la propiedad "Nombre" para hacer el "trim" de los espacios en blando recibidos
    public override string Nombre  // override se usa para hacer una sobreescritura del metodo abstracto en Heroe.cs
    {
      get
      {
        return _Nombre;
      }
      set
      {
        _Nombre = value.Trim();
      }
    }

    // Creando un encapsulamiento de "read Only"
    public string NombreEIdentidadSecreta
    {
      get
      {
        return $"{Nombre} ({IdentidadSecreta})";
      }
    }
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;  // List<T> es una clase genérica en C# que representa una lista (o colección) de objetos de un tipo específico. En este caso, SuperPoder es el tipo de objeto que la lista va a contener. 
    public bool PuedeVolar;


    public SuperHeroe()
    {  // constructor
      Id = 1;  // el ID por defecto sera 1
      SuperPoderes = new List<SuperPoder>();
      PuedeVolar = false;
    }

    public string UsarSuperPoderes()
    {  // void significa que no va a retornar ningun valor, todo sera usado internamente.
      StringBuilder sb = new StringBuilder();

      foreach (var item in SuperPoderes)
      {
        sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder {item.Nombre}!!");
      }

      return sb.ToString();
    }

    public override string SalvarElMundo()
    {
      return $"{NombreEIdentidadSecreta} ha salvado el mundo";
    }
  }
}