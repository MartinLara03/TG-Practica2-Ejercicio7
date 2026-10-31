using System.Numerics;

namespace Practica2_Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 7 - HERENCIA");
            Console.WriteLine();


            // Datos del Doctor

            Doctor doctor = new Doctor(
                "Carlos Lopez",
                50,
                "UNAM",
                "Toluca",
                "Cardiologia",
                "Hospital General"
            );


            // Datos del Abogado

            Abogado abogado = new Abogado(
                "Juan Perez",
                51,
                "UNAM",
                "Metepec",
                "Bufete Legal",
                5
            );


            // Mostrar los datos del Doctor

            Console.WriteLine("DATOS DEL DOCTOR");
            doctor.MostrarDoctor();

            Console.WriteLine();


            // Mostrar los datos del Abogado

            Console.WriteLine("DATOS DEL ABOGADO");
            abogado.MostrarAbogado();

            Console.WriteLine();


            // Comparar las edades

            Console.WriteLine();
            Console.WriteLine("COMPARACION DE EDADES");
            Console.WriteLine();

            if (doctor.Edad > abogado.Edad)
            {
                // El Doctor tiene mayor edad

                Console.WriteLine("El Doctor tiene mayor edad.");
                Console.WriteLine();

                Console.WriteLine("Datos personales del Doctor:");
                doctor.MostrarDatos();
            }
            else if (doctor.Edad < abogado.Edad)
            {
                // El Abogado tiene mayor edad

                Console.WriteLine("El Abogado tiene mayor edad.");
                Console.WriteLine();

                Console.WriteLine("Datos personales y laborales del Abogado:");
                abogado.MostrarAbogado();
            }
            else
            {
                // Los dos tienen la misma edad

                Console.WriteLine("El Doctor y el Abogado tienen la misma edad.");
                Console.WriteLine();

                Console.WriteLine("Datos personales del Doctor:");
                doctor.MostrarDatos();

                Console.WriteLine();

                Console.WriteLine("Datos personales del Abogado:");
                abogado.MostrarDatos();
            }



            // Comparar Universidad

            Console.WriteLine("COMPARACION DE UNIVERSIDAD");

            if (doctor.Universidad == abogado.Universidad)
            {
                Console.WriteLine("Provienen de la misma universidad.");
            }
            else
            {
                Console.WriteLine("No provienen de la misma universidad.");
            }

            Console.WriteLine();


            // Comparar Zona

            Console.WriteLine("COMPARACION DE ZONA");

            if (doctor.Zona == abogado.Zona)
            {
                Console.WriteLine("Viven en la misma zona.");
            }
            else
            {
                Console.WriteLine("No viven en la misma zona.");
            }

            Console.WriteLine();


            // Mostrar juicios del Abogado

            Console.WriteLine("JUICIOS EN PROCESO");

            Console.WriteLine(
                "El abogado tiene " + abogado.JuiciosEnProceso + " juicios en proceso.");


            Console.ReadKey();
        }
    }
}
