
namespace SuperHeroesApp.Models { 
  class SuperPoder { 
  public string Nombre;
  public string Descripcion;
  public NivelPoder Nivel;  // Cada que queramos asignarle un nivel de poder deberemos usar la clase "NivelPoder".

  public SuperPoder() {
    Nivel = NivelPoder.NivelUno;  // el nivel de poder por defecto sera 1.

  }
}

enum NivelPoder { 
  NivelUno, 
  NivelDos, 
  NivelTres
}
}