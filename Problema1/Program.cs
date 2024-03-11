using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nombre: Maria Fernanda Zuluaga Usme
            //Grupo: 213022_117
            //Programa de Ingeniería de Sistemas
            //Código fuente: Autoría propia

            //Declaración de variables

            string Nombre, Temporada, CompaniaViaje, Estudiante;
            int Edad;
            double TarifaBasica;

        //CAPTURA DE LOS DATOS DE ENTRADA

            //Ingreso del Nombre del pasajero

            Console.WriteLine("Ingrese el nombre del pasajero: ");
            Nombre = Console.ReadLine().ToUpper();

            //Ingreso de la Temporada, con la validación de que debe ingresar 'Alta' o 'Baja'

            Console.WriteLine("Ingrese la temporada del viaje: ");
            do
            {
                Temporada = Console.ReadLine().ToUpper();
                if(Temporada == "ALTA" || Temporada == "BAJA")
                {
                    Console.WriteLine("Se selecciono temporada " + Temporada);
                    break;
                }
                else
                {
                    Console.WriteLine("¡ERROR! Por favor ingrese si es temporada 'Alta' o 'Baja' ");
                }
            }
            while (true);

            //Ingreso de la Compañía de viaje, con la validación de que debe ingresar 'Alas' o 'Volar'

            Console.WriteLine("Ingrese la compañía de viaje, Alas o Volar: ");
            do
            {
                CompaniaViaje = Console.ReadLine().ToUpper();
                if (CompaniaViaje == "ALAS" || CompaniaViaje == "VOLAR")
                {
                    Console.WriteLine("Se selecciono Compañía de Viaje " + CompaniaViaje);
                    break;
                }
                else 
                {
                    Console.WriteLine("¡ERROR! Por favor ingrese si la Compañía de Viaje es 'Alas' o 'Volar' ");
                }
            }
            while (true);

            //Ingreso de la edad del pasajero, con la validación de que debe ingresarse un numero

            Console.WriteLine("Ingrese la edad del pasajero: ");
            bool EsNumero = int.TryParse(Console.ReadLine(), out Edad);
            if (EsNumero == false) {
                Console.WriteLine("¡ERROR! Por favor ingrese un numero");
                Edad = int.Parse(Console.ReadLine());
            }

            //Ingreso de si es estudiante

            Console.WriteLine("¿Es usted estudiante?");
            Estudiante = Console.ReadLine().ToUpper();
            if (Estudiante == "SI")
            {
                Console.WriteLine("Es estudiante ");
            }
            else
            {
            Console.WriteLine("No es estudiante ");
            }

            //Ingreso de la Tarifa Básica, con la validación de que debe ingresar un numero

            Console.WriteLine("Ingrese la tarifa básica");
            bool EsNumero1 = double.TryParse(Console.ReadLine(), out TarifaBasica);
            if (EsNumero1 == false)
            {
                Console.WriteLine("¡ERROR! Por favor ingrese un numero");
                TarifaBasica = double.Parse(Console.ReadLine());
            }

            //Verificar que condiciones cumple el pasajero

            if (CompaniaViaje == "ALAS")
            {
                Console.WriteLine("Nombre del pasajero: " + Nombre);
                Console.WriteLine("El precio del pasaje es: " + TarifaBasica);
                if (Temporada == "ALTA")
                {
                    Console.WriteLine("Aplicar el aumento del 30%");
                    TarifaBasica = TarifaBasica + (TarifaBasica * 0.3);
                    Console.WriteLine("El precio del pasaje con aumento por temporada es: " + TarifaBasica);

                    if (Edad < 18)
                    {
                        Console.WriteLine("Aplicar el descuento del 50%");
                        TarifaBasica = TarifaBasica - (TarifaBasica * 0.5);
                        Console.WriteLine("El precio del pasaje con descuento aplicado es: " + TarifaBasica);
                    }
                    else
                    {
                        Console.WriteLine("No tiene ningún descuento para aplicar");
                        Console.WriteLine("El precio del pasaje es: " + TarifaBasica);
                    }
                }
                else
                {
                    if (Temporada == "BAJA")
                    {
                        if (Edad >= 18)
                        {
                            if (Estudiante == "SI")
                            {
                                Console.WriteLine("Aplicar el descuento del 10%");
                                TarifaBasica = TarifaBasica - (TarifaBasica * 0.1);
                                Console.WriteLine("El precio del pasaje  con descuento aplicado es: " + TarifaBasica);
                            }
                            else
                            {
                                Console.WriteLine("No tiene ningún descuento para aplicar");
                                Console.WriteLine("El precio del pasaje es: " + TarifaBasica);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Aplicar el descuento del 50%");
                            TarifaBasica = TarifaBasica - (TarifaBasica * 0.5);
                            Console.WriteLine("El precio del pasaje con descuento aplicado es: " + TarifaBasica);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Nombre del pasajero: " + Nombre);
                Console.WriteLine("El precio del pasaje es: " + TarifaBasica);
                if (CompaniaViaje == "VOLAR")
                {
                    if (Temporada == "ALTA")
                    {
                        Console.WriteLine("Aplicar el aumento del 20%");
                        TarifaBasica = TarifaBasica + (TarifaBasica * 0.2);
                        Console.WriteLine("El precio del pasaje con aumento por temporada es: " + TarifaBasica);
                        if (Edad < 18)
                        {
                            Console.WriteLine("Aplicar el descuento del 50%");
                            TarifaBasica = TarifaBasica - (TarifaBasica * 0.5);
                            Console.WriteLine("El precio del pasaje con descuento aplicado es: " + TarifaBasica);
                        }
                        else
                        {
                            Console.WriteLine("No tiene ningún descuento para aplicar");
                            Console.WriteLine("El precio del pasaje es: " + TarifaBasica);
                        }
                    }
                    else
                    {
                        if (Temporada == "BAJA")
                        {
                            if (Edad < 18)
                            {
                                Console.WriteLine("Aplicar el descuento del 50%");
                                TarifaBasica = TarifaBasica - (TarifaBasica * 0.5);
                                Console.WriteLine("El precio del pasaje con descuento aplicado es: " + TarifaBasica);
                            }
                            else
                            {
                                Console.WriteLine("No tiene ningún descuento para aplicar");
                                Console.WriteLine("El precio del pasaje es: " + TarifaBasica);
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
