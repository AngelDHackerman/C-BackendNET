var volar = new SuperPoder();
volar.Nombre = "Volar";
volar.Descripcion = "Capacidad para volar y planear en el aire";
volar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "super fuerza";
superFuerza.Descripcion = "Fuerza sobrehumana";
superFuerza.Nivel = NivelPoder.NivelTres;

var superInteligencia = new SuperPoder();
superInteligencia.Nombre = "Super Inteligencia";
superInteligencia.Descripcion= "Inteligencia muy superior a la de los humanos";
superInteligencia.Nivel= NivelPoder.NivelUno;

var tecnologia = new SuperPoder();
tecnologia.Nombre= "Tecnologia muy avanzada";
tecnologia.Descripcion= "Tecnologia muy avanzada desarrollada por humanos o Aliens";
tecnologia.Nivel= NivelPoder.NivelDos;

var velocidad = new SuperPoder();
velocidad.Nombre = "Velocidad";
velocidad.Descripcion= "Velicidad sobrehumana";
velocidad.Nivel = NivelPoder.NivelTres;

var inmotalidad = new SuperPoder();
inmotalidad.Nombre= "Inmortalidad";
inmotalidad.Descripcion = "Capazcidad de no morir";
inmotalidad.Nivel = NivelPoder.NivelTres;


// Creando nuevo objeto para superman
var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

// Agregando superpoders a Superman

List<SuperPoder> poderesSuperman = new List<SuperPoder>();  // Aqui se declara que los super poders seran una lista de la clase "superPoder".
poderesSuperman.Add(volar);  // aqui se le agregan a lista de los superpoderes de superman el poder de "poderVolar"
poderesSuperman.Add(superFuerza);

superman.SuperPoderes = poderesSuperman;  // Se agrega todo el objeto de superpoderes a Superman. 
superman.UsarSuperPoderes();  // se invoca la funcion que describe que superpoderes se estan usando. 

// Creando nuevo objeto para Batman
var batman = new SuperHeroe();

batman.Id = 2;
batman.Nombre = "Batman";
batman.IdentidadSecreta = "Bruce Wayne";
batman.Ciudad = "Gotham";
batman.PuedeVolar= false;

// agregando superpoderes a batman

List<SuperPoder> poderesBatman = new List<SuperPoder>();
poderesBatman.Add(superInteligencia);
poderesBatman.Add(tecnologia);

batman.SuperPoderes = poderesBatman;
batman.UsarSuperPoderes();

// Creando nuevo objeto para Wonder woman
var wonderWoman = new SuperHeroe();

wonderWoman.Id = 3;
wonderWoman.Nombre= "Wonder Woman";
wonderWoman.IdentidadSecreta= "Diana Prince";
wonderWoman.Ciudad= "Themyscira";
wonderWoman.PuedeVolar = true;

// agregando superpoderes a wonder woman

List<SuperPoder> poderesWonderWoman = new List<SuperPoder>();
poderesWonderWoman.Add(inmotalidad);
poderesWonderWoman.Add(superFuerza);

wonderWoman.SuperPoderes = poderesWonderWoman;
wonderWoman.UsarSuperPoderes();


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

  public void UsarSuperPoderes () {  // void significa que no va a retornar ningun valor, todo sera usado internamente.
    foreach (var item in SuperPoderes) { 
      Console.WriteLine($"{Nombre} esta usando el super poder {item.Nombre}!!");
    }
  }
}

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