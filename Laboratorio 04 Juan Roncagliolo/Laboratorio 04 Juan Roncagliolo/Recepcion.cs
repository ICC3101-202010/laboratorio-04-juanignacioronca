using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    public class Recepcion : Maquina
    {
        //Atributos:
        public int Piezas_recibidas;
        public int Piezas_enviadas;
        //Metodos
        public string Enviar_a_almacenamiento(Recepcion recepcion)
        {
            if (recepcion.Hora < 4 | recepcion.Hora > 21)
            {
                string b;
                b = "|  " + recepcion.Apagado() + "  |  " + recepcion.Hora.ToString("00") + "  |";
                recepcion.Apagado();
                recepcion.Registro.Add(b);
                Piezas_recibidas = 0;
                Piezas_enviadas = Piezas_recibidas;
            }
            else
            {
                if (recepcion.Estado == "Encendido")
                {
                }
                else
                {
                    string b;
                    b = "| " + recepcion.Encendido() + " |  " + recepcion.Hora.ToString("00") + "  |";
                    recepcion.Registro.Add(b);
                }
            }
            string a;
            if (recepcion.Estado == "Encendido")
            {
                if (recepcion.Memoria < 2000)
                {
                    recepcion.Piezas_enviadas = recepcion.Piezas_recibidas;
                    recepcion.Memoria += recepcion.Piezas_enviadas;
                    a = "| " + recepcion.Piezas_recibidas.ToString("0000") + " | " + recepcion.Piezas_enviadas.ToString("0000") + " | " + recepcion.Memoria.ToString("0000") + " |  " + recepcion.Hora.ToString("00")+"  |";
                    recepcion.Registro.Add(a);
                    return a;
                }
                else
                {
                    recepcion.Piezas_enviadas = recepcion.Piezas_recibidas;
                    a = "| " + recepcion.Reinicio(recepcion.Nombre) + " |  " + recepcion.Hora.ToString("00") + "  |";
                    recepcion.Registro.Add(a);
                    return a;
                }
            }
            else
            {
                return "";
            }

        }
        public void Ver_Informacion(Recepcion recepcion)
        {
            Console.WriteLine("| Maquina Recepcion  | Hora |");
            Console.WriteLine("|  PR  |  PE  |  ME  | Hora |");
            foreach (var item in recepcion.Registro)
            {
                Console.WriteLine("|--------------------|------|");
                Console.WriteLine(item);
            }
        }
    }
}
