using System;

namespace Practica2_Ejercicio7
{
    internal class Abogado : Persona
    {
        public string Empresa;
        public int JuiciosEnProceso;

        public Abogado(string nombre, int edad, string universidad, string zona, string empresa, int juicios)  : base(nombre, edad, universidad, zona)
        {
            Empresa = empresa;
            JuiciosEnProceso = juicios;
        }

        public void MostrarAbogado()
        {
            MostrarDatos();

            Console.WriteLine("Empresa: " + Empresa);
            Console.WriteLine("Juicios en proceso: " + JuiciosEnProceso);
        }
    }
}
