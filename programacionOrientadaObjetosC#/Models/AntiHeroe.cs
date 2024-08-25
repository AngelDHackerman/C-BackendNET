namespace SuperHeroesApp.Models { 
  // AntiHeroe va heredar todas las propiedades de SuperHeroe
  internal class AntiHeroe : SuperHeroe {
    public string RealizarAccionDeAntiheroe (string accion) { 
      return $"El antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}";
    }
  }
}