using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Recepcion recepcion_1 = new Recepcion();
            Almacenamiento almacenamiento_1 = new Almacenamiento();
            Ensamblaje ensamblaje_1 = new Ensamblaje();
            Verificacion verificacion_1 = new Verificacion();
            Empaque empaque_1 = new Empaque();
            Random rnd = new Random();
            for (int i = 0; i < 24; i++)
            {
                recepcion_1.Hora = i;
                almacenamiento_1.Hora = i;
                ensamblaje_1.Hora = i;
                verificacion_1.Hora = i;
                empaque_1.Hora = i;
                recepcion_1.Piezas_recibidas = rnd.Next(0, 1000);
                recepcion_1.Enviar_a_almacenamiento(recepcion_1);
                almacenamiento_1.Piezas_recibidas = recepcion_1.Piezas_enviadas;
                almacenamiento_1.Enviar_a_ensamble(almacenamiento_1);
                ensamblaje_1.Piezas_recibidas = almacenamiento_1.Piezas_enviadas;
                ensamblaje_1.Enviar_a_verificacion(ensamblaje_1);
                verificacion_1.Objetos_recibidos = ensamblaje_1.Objetos_enviados;
                verificacion_1.Enviar_a_empaque(verificacion_1);
                empaque_1.Objetos_recibidos = verificacion_1.Objetos_enviados;
                empaque_1.Enviar_producto(empaque_1);
            }
            //Programa
            int a = -1;
            while (a!=0)
            {
                Console.WriteLine("\nBienvenido al menu principal:\n\n1. Ver informacion maquina recepcion:\n2. Ver informacion maquina almacenamiento:" +
                    "\n3. Ver informacion maquina ensamblaje:\n4. Ver informacion maquina verificacion:\n5. Ver informacion maquina empaque:" +
                    "\n6. Ver informacion de todas las maquinas:\n7. Ver la abreviatura\n0. Para salir:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    recepcion_1.Ver_Informacion(recepcion_1);
                    Console.WriteLine("\nPresione cualqueir tecla para volver atras");
                    Console.ReadKey();
                }
                else if (a == 2)
                {
                    almacenamiento_1.Ver_Informacion(almacenamiento_1);
                    Console.WriteLine("\nPresione cualqueir tecla para volver atras");
                    Console.ReadKey();
                }
                else if (a == 3)
                {
                    ensamblaje_1.Ver_Informacion(ensamblaje_1);
                    Console.WriteLine("\nPresione cualqueir tecla para volver atras");
                    Console.ReadKey();
                }
                else if (a == 4)
                {
                    verificacion_1.Ver_Informacion(verificacion_1);
                    Console.WriteLine("\nPresione cualqueir tecla para volver atras");
                    Console.ReadKey();
                }
                else if (a == 5)
                {
                    empaque_1.Ver_Informacion(empaque_1);
                }
                else if (a == 6)
                {
                    empaque_1.Ver_Informacion_2(recepcion_1, almacenamiento_1, ensamblaje_1, verificacion_1, empaque_1);
                    Console.WriteLine("\nPresione cualqueir tecla para volver atras");
                    Console.ReadKey();
                }
                else if (a ==7)
                {
                    Console.WriteLine("\n-------------Esta es la abreviatura de las tablas:-------------\n|PR: Piezas Recibidas| PE: Piezas Enviadas |PA: Piezas Almacenadas|\n" +
                                      "|    ME: Memoria     | OE: Objetos Enviados| OR: Objetos Recividos|");
                    Console.WriteLine("\nPresione cualqueir tecla para volver atras");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta, intente nuevamente");
                }
            }
            
        }
    }
}
