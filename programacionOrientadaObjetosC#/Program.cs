using System;
using System.Collections.Generic;
using System.Text;
using SuperHeroesApp.Models; // Asegúrate de que el espacio de nombres sea correcto.

class Program {
    static void Main(string[] args) {
        var volar = new SuperPoder();
        volar.Nombre = "Volar";
        volar.Descripcion = "Capacidad para volar y planear en el aire";
        volar.Nivel = NivelPoder.NivelDos;

        var superFuerza = new SuperPoder();
        superFuerza.Nombre = "Super Fuerza";
        superFuerza.Descripcion = "Fuerza sobrehumana";
        superFuerza.Nivel = NivelPoder.NivelTres;

        var superInteligencia = new SuperPoder();
        superInteligencia.Nombre = "Super Inteligencia";
        superInteligencia.Descripcion = "Inteligencia muy superior a la de los humanos";
        superInteligencia.Nivel = NivelPoder.NivelUno;

        var tecnologia = new SuperPoder();
        tecnologia.Nombre = "Tecnologia muy avanzada";
        tecnologia.Descripcion = "Tecnologia muy avanzada desarrollada por humanos o Aliens";
        tecnologia.Nivel = NivelPoder.NivelDos;

        var velocidad = new SuperPoder();
        velocidad.Nombre = "Velocidad";
        velocidad.Descripcion = "Velocidad sobrehumana";
        velocidad.Nivel = NivelPoder.NivelTres;

        var inmortalidad = new SuperPoder();
        inmortalidad.Nombre = "Inmortalidad";
        inmortalidad.Descripcion = "Capacidad de no morir";
        inmortalidad.Nivel = NivelPoder.NivelTres;

        var regeneracion = new SuperPoder();
        regeneracion.Nombre = "Regeneracion";
        regeneracion.Descripcion = "Capacidad curativa y regeneracion de miembros";
        regeneracion.Nivel = NivelPoder.NivelUno;

        // Creando nuevo objeto para superman
        var superman = new SuperHeroe();
        superman.Id = 1;
        superman.Nombre = "       Superman         ";
        superman.IdentidadSecreta = "Clark Kent";
        superman.Ciudad = "Metropolis";
        superman.PuedeVolar = true;

        // Agregando superpoderes a Superman
        List<SuperPoder> poderesSuperman = new List<SuperPoder> {
            volar,
            superFuerza
        };
        superman.SuperPoderes = poderesSuperman;
        string resultSuperPoderes = superman.UsarSuperPoderes();
        Console.WriteLine(resultSuperPoderes);

        // Creando nuevo objeto para Batman
        var batman = new SuperHeroe();
        batman.Id = 2;
        batman.Nombre = "Batman";
        batman.IdentidadSecreta = "Bruce Wayne";
        batman.Ciudad = "Gotham";
        batman.PuedeVolar = false;

        // Agregando superpoderes a Batman
        List<SuperPoder> poderesBatman = new List<SuperPoder> {
            superInteligencia,
            tecnologia
        };
        batman.SuperPoderes = poderesBatman;
        resultSuperPoderes = batman.UsarSuperPoderes();
        Console.WriteLine(resultSuperPoderes);

        // Creando nuevo objeto para Wonder Woman
        var wonderWoman = new SuperHeroe();
        wonderWoman.Id = 3;
        wonderWoman.Nombre = "Wonder Woman";
        wonderWoman.IdentidadSecreta = "Diana Prince";
        wonderWoman.Ciudad = "Themyscira";
        wonderWoman.PuedeVolar = true;

        // Agregando superpoderes a Wonder Woman
        List<SuperPoder> poderesWonderWoman = new List<SuperPoder> {
            inmortalidad,
            superFuerza
        };
        wonderWoman.SuperPoderes = poderesWonderWoman;
        resultSuperPoderes = wonderWoman.UsarSuperPoderes();
        Console.WriteLine(resultSuperPoderes);

        // Creando nuevo objeto para Wolvering (AntiHeroe)
        var wolverine = new AntiHeroe();
        wolverine.Id = 4;
        wolverine.Nombre = "Wolverine";
        wolverine.IdentidadSecreta = "Logan";
        wolverine.PuedeVolar = false;

        // Agregando superpoderes a Wolverine
        List<SuperPoder> poderesWolverine = new List<SuperPoder> {
            inmortalidad,
            regeneracion
        };
        wolverine.SuperPoderes = poderesWolverine;
        resultSuperPoderes = wolverine.UsarSuperPoderes();
        Console.WriteLine(resultSuperPoderes);

        string accionAntiheroe = wolverine.RealizarAccionDeAntiheroe("Ataca a la policia");
        Console.WriteLine(accionAntiheroe);
    }
}
