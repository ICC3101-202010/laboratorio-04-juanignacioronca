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
        public bool Factor_aleatorio;
        public string Nombre;
        public List<string> Registro = new List<string>();

        public string Encendido()
        {
            Estado = "Encendido";
            return "Maquina  Encendida";  
        }
        public string Reinicio(string maquina)
        {
            if (Factor_aleatorio == true)
            {
                Memoria = 0;
                Estado = "Encendido";
                return "Maquina Reiniciada";
            }
            else
            {
                int a = -1;
                while (a != 1)
                {
                    Console.WriteLine("Escriba 1 para Reiniciar la maquina "+maquina+ " o 0 para volver atras");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                if (a == 1)
                {
                    Memoria = 0;
                    Estado = "Encendido";
                    return "Maquina Reiniciada";
                }
                else if (a == 0)
                {
                    return "";
                }
                else
                {
                    return "Opcion incorrecta";
                }

            }
        }
        public string Apagado()
        {
            Memoria = 0;
            Estado = "Apagada";
            return "Maquina  Apagada";
            
        }

    }
}
