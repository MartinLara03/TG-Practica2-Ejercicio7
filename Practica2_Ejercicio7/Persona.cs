using System;

namespace Practica2_Ejercicio7
{
    internal class Persona
    {
        public string Nombre;
        public int Edad;
        public string Universidad;
        public string Zona;

        public Persona(string nombre, int edad, string universidad, string zona)
        {
            Nombre = nombre;
            Edad = edad;
            Universidad = universidad;
            Zona = zona;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Universidad: " + Universidad);
            Console.WriteLine("Zona: " + Zona);
        }
    }
}