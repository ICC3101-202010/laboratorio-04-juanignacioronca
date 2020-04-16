using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    public class Almacenamiento : Maquina
    {
        //Atributos:
        public int Piezas_recibidas;
        public int Piezas_almacenadas;
        public int Piezas_enviadas;

        //Metodos
        public string Enviar_a_ensamble(Almacenamiento almacenamiento )
        {
            if (almacenamiento.Hora < 4 | almacenamiento.Hora > 21)
            {
                string b;
                b = "|      " + almacenamiento.Apagado() + "     |  " + almacenamiento.Hora.ToString("00") + "  |";
                almacenamiento.Apagado();
                almacenamiento.Registro.Add(b);
                Piezas_recibidas = 0;
                Piezas_almacenadas = 0;
                Piezas_enviadas = Piezas_recibidas;
            }
            else
            {
                if (almacenamiento.Estado == "Encendido")
                {
                }
                else
                {
                    string b;
                    b = "|      " + almacenamiento.Encendido() + "   |  " + almacenamiento.Hora.ToString("00") + "  |";
                    almacenamiento.Registro.Add(b);
                }
            }
            string a;
            if (almacenamiento.Estado == "Encendido")
            {
                Random rnd = new Random();
                if (almacenamiento.Memoria < 2000)
                {
                    almacenamiento.Piezas_almacenadas += almacenamiento.Piezas_recibidas;
                    almacenamiento.Piezas_enviadas = rnd.Next(0, almacenamiento.Piezas_almacenadas);
                    almacenamiento.Piezas_almacenadas -= almacenamiento.Piezas_enviadas;
                    almacenamiento.Memoria += almacenamiento.Piezas_enviadas;
                    a = "| " + almacenamiento.Piezas_recibidas.ToString("0000") + " | " + almacenamiento.Piezas_almacenadas.ToString("0000") + " | " + almacenamiento.Piezas_enviadas.ToString("0000") + " | " + almacenamiento.Memoria.ToString("0000") + " |  " + almacenamiento.Hora.ToString("00") + "  |";
                    almacenamiento.Registro.Add(a);
                    return a;
                }
                else
                {
                    almacenamiento.Piezas_almacenadas += almacenamiento.Piezas_recibidas;
                    almacenamiento.Piezas_enviadas = rnd.Next(0, almacenamiento.Piezas_almacenadas);
                    almacenamiento.Piezas_almacenadas -= almacenamiento.Piezas_enviadas;
                    almacenamiento.Memoria += almacenamiento.Piezas_enviadas;
                    a = "|     " + almacenamiento.Reinicio() + "    |  " + almacenamiento.Hora.ToString("00") + "  |";
                    almacenamiento.Registro.Add(a);
                    return a;
                }
            }
            else
            {
                return "";
            }

        }
        public void Ver_Informacion(Almacenamiento almacenamiento)
        {
            Console.WriteLine("|  Maquina Almacenamiento   | Hora |");
            Console.WriteLine("|  PR  |  PA  |  PE  |  ME  | Hora |");
            foreach (var item in almacenamiento.Registro)
            {
                Console.WriteLine("|---------------------------|------|");
                Console.WriteLine(item);
            }
        }
    }
}


