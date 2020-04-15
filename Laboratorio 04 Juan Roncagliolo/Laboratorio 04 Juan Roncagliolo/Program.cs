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
            Random rnd = new Random();
            Console.WriteLine("| Maquina Recepcion  |  Maquina Almacenamiento   |  Maquina Ensablaje   | Maquina Verificacion  | Maquina Empaque  | Hora |");
            Console.WriteLine("|  PR  |  PE  |  ME  |  PR  |  PA  |  PE  |  ME  |  PR   |  OE   |  ME  |   OR  |   OE   |  ME  |  OR |  OE |  ME  | Hora |");
            for (int i = 0; i < 24; i++)
            {
                recepcion_1.Hora = i;
                recepcion_1.Piezas_recibidas = rnd.Next(0, 1000);
                Console.WriteLine(recepcion_1.Enviar_a_almacenamiento(recepcion_1));
            }
            Console.WriteLine("| PR: Piezas Recibidas PE: Piezas Enviadas ME: Memoria PA: Piezas Almacenadas OE: Objetos Enviados OR: Objetos Recividos  |");
            Console.ReadKey();
        }
    }
}
