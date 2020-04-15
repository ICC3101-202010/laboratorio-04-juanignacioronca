using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    class Recepcion:Maquina
    {
        //Atributos:
        public int Piezas_recibidas;
        public int Piezas_enviadas;
        //Metodos
        public void def_Estado(Recepcion maquina)
        {
            if (maquina.Hora < 9 | maquina.Hora > 21)
            {
                maquina.Apagado();
                Piezas_recibidas = 0;
                Piezas_enviadas = Piezas_recibidas;
            }
            else
            {
                maquina.Encendido();
            }
        }
        public string Enviar_a_almacenamiento(Recepcion recepcion)
        {
            recepcion.def_Estado(recepcion);
            if (recepcion.Estado == "Encendido")
            {
                if (recepcion.Memoria < 2000)
                {
                    recepcion.Piezas_enviadas = recepcion.Piezas_recibidas;
                    recepcion.Memoria += recepcion.Piezas_enviadas;
                }
                else
                {
                    recepcion.Piezas_enviadas = recepcion.Piezas_recibidas;
                    Console.WriteLine("| "+recepcion.Reinicio()+" | "+recepcion.Hora);
                    recepcion.Memoria += recepcion.Piezas_enviadas;
                    return "| " + recepcion.Piezas_recibidas.ToString("0000") + " | " + recepcion.Piezas_enviadas.ToString("0000") + " | " + recepcion.Memoria.ToString("0000") + " | " + recepcion.Hora.ToString("00");
                }
            }
            else
            {
            }
            return "| " + recepcion.Piezas_recibidas.ToString("0000")+ " | "+ recepcion.Piezas_enviadas.ToString("0000") + " | " + recepcion.Memoria.ToString("0000") + " | " + recepcion.Hora.ToString("00");
        }
    }
}
