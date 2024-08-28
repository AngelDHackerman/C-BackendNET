
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

// Programa Principal 

class Program 
{
  static void Main(string[] args)
  {
    int numeroAsientosEnLaSala = 10;
    Sala sala = new Sala(numeroAsientosEnLaSala);
    string opcion;

    do
    {
      Console.WriteLine("\nSistema de Reservación de Asientos");
      Console.WriteLine("1. Mostrar Asientos");
      Console.WriteLine("2. Reservar Asiento");
      Console.WriteLine("3. Cancelar Reserva");
      Console.WriteLine("4. Salir");
      Console.Write("Elija una opción: ");
      opcion = Console.ReadLine();

      switch (opcion)
      {
        case "1":
          sala.MostrarAsientos();
          break;
        case "2":
          Console.WriteLine($"Ingrese el numero de asiento a reservar: ");
          string asientoAReservar = Console.ReadLine();
          sala.ReservarAsiento(asientoAReservar);
          break;
        case "3":
          Console.WriteLine("Ingrese el numero de asiento a cancelar: ");
          string asientoACancelar = Console.ReadLine();
          sala.CancelarReservaAsiento(asientoACancelar);
          break;
        case "4":
          Console.WriteLine("Gracias por usar el sistema de reservacion.");
          break;
        default:
        Console.WriteLine("Opcion no valida.");
        break;
      }
    } while (opcion != "4");
  }
}