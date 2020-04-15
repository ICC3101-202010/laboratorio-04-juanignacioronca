using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    public abstract class Maquina
    {
        public int Memoria;
        public string Estado;
        public int Hora;

        public string Encendido()
        {
            Estado = "Encendido";
            return "Maquina encendida";
        }
        public string Reinicio()
        {
            Apagado();
            Encendido();
            return "Maquina Reiniciada";
        }
    public string Apagado()
        {
            Memoria = 0;
            Estado = "Apagada";
            return "Maquina apagada";
        }
        public void Guardar_informacion()
        {

        }

    }
}
