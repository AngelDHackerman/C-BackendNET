
// Definicion del Enum para el estado del asiento

public enum EstadoAsiento
{
  Disponible, 
  Reservado,
  Ocupado
}

// Interfaz para asientos reservables 

public interface IReservable  // porque tiene una I adelante? 
{
  void Reservar();
  void CancelarReserva();
}

// Clase Abstracta para Elementos Reservables 

public abstract class ElementoReservable 
{
  public string Identificador {get; set;}
  public EstadoAsiento Estado {get; set;}

  public ElementoReservable(string identificador)
  {
    Identificador = identificador;
    Estado = EstadoAsiento.Disponible;
  }

  public abstract void MostrarEstado();
}

// Clase Concreta para asiento

public class Asiento : ElementoReservable, IReservable
{
  public Asiento(string numeroAsiento) : base(numeroAsiento)
  {

  }

  public void Reservar()
  {
    if (Estado == EstadoAsiento.Disponible)
    {
      Estado = EstadoAsiento.Reservado;
      Console.WriteLine($"El asiento {Identificador} ha sido reservado.");
    }
    else 
    {
      Console.WriteLine($"El asiento {Identificador} no esta disponible");
    }
  }

  public void CancelarReserva()
  {
    if (Estado == EstadoAsiento.Reservado)
    {
      Estado = EstadoAsiento.Disponible;
      Console.WriteLine($"La reservacion del asiento {Identificador} ha sido cancelada.");
    }
    else 
    {
      Console.WriteLine($"El asiento {Identificador} no estaba reservado.");
    }
  }

    public override void MostrarEstado()
    {
        Console.WriteLine($"Asiento {Identificador}: {Estado}");
    }
}

// Clase para la sala de cine

public class Sala 
{
  public List<Asiento> Asientos { get; private set; }

  public Sala(int numeroDeAsientos)
  {
    Asientos = new List<Asiento>();
    for (int i = 1; i <= numeroDeAsientos; i ++)
    {
      Asientos.Add(new Asiento(i.ToString()));
    }
  }

  public void MostrarAsientos()
  {
    foreach (var asiento in Asientos)
    {
      asiento.MostrarEstado();
    }
  }

  public void ReservarAsiento (string identificador)
  {
    Asiento asiento = Asientos.FirstOrDefault(a => a.Identificador == identificador);
    if (asiento != null)
    {
      asiento.Reservar();
    }
    else
    {
      Console.WriteLine($"Asiento no encontrado");
    }
  }

  public void CancelarReservaAsiento(string identificador)
  {
    Asiento asiento = Asientos.FirstOrDefault(a => a.Identificador == identificador);
    if (asiento != null)
    {
      asiento.CancelarReserva();
    }
    else
    {
      Console.WriteLine($"Asiento no encontrado");
    }
  }  
}

