using System;

namespace Practica2_Ejercicio7
{
    internal class Doctor : Persona
    {
        public string Especialidad;
        public string Hospital;

        public Doctor(string nombre, int edad, string universidad, string zona, string especialidad, string hospital) : base(nombre, edad, universidad, zona)
        {
            Especialidad = especialidad;
            Hospital = hospital;
        }

        public void MostrarDoctor()
        {
            MostrarDatos();

            Console.WriteLine("Especialidad: " + Especialidad);
            Console.WriteLine("Hospital: " + Hospital);
        }
    }
}