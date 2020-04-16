using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    class Ensamblaje : Maquina
    {
        //Atributos:
        public int Piezas_recibidas;
        public int Objetos_enviados;
        //Metodos
        public string Enviar_a_verificacion(Ensamblaje ensamblaje)
        {
            if (ensamblaje.Hora < 4 | ensamblaje.Hora > 21)
            {
                string b;
                b = "|   " + ensamblaje.Apagado() + "   |  " + ensamblaje.Hora.ToString("00") + "  |";
                ensamblaje.Apagado();
                ensamblaje.Registro.Add(b);
                Piezas_recibidas = 0;
                Objetos_enviados = Piezas_recibidas/4;
            }
            else
            {
                if (ensamblaje.Estado == "Encendido")
                {
                }
                else
                {
                    string b;
                    b = "|   " + ensamblaje.Encendido() + " |  " + ensamblaje.Hora.ToString("00") + "  |";
                    ensamblaje.Registro.Add(b);
                }
            }
            string a;
            if (ensamblaje.Estado == "Encendido")
            {
                Random rnd = new Random();
                if (ensamblaje.Memoria < 500)
                {
                    ensamblaje.Objetos_enviados = ensamblaje.Piezas_recibidas/4;
                    ensamblaje.Memoria += ensamblaje.Objetos_enviados;
                    a = "|  " + ensamblaje.Piezas_recibidas.ToString("0000") + " | " + ensamblaje.Objetos_enviados.ToString("0000") + "  | " + ensamblaje.Memoria.ToString("0000") + " |  " + ensamblaje.Hora.ToString("00") + "  |";
                    ensamblaje.Registro.Add(a);
                    return a;
                }
                else
                {
                    ensamblaje.Objetos_enviados = ensamblaje.Piezas_recibidas/4;
                    ensamblaje.Memoria += ensamblaje.Objetos_enviados;
                    a = "|  " + ensamblaje.Reinicio(ensamblaje.Nombre) + "  |  " + ensamblaje.Hora.ToString("00") + "  |";
                    ensamblaje.Registro.Add(a);
                    return a;
                }
            }
            else
            {
                return "";
            }

        }
        public void Ver_Informacion(Ensamblaje ensamblaje)
        {
            Console.WriteLine("|  Maquina Ensablaje   | Hora |");
            Console.WriteLine("|  PR   | OE   |  ME   | Hora |");
            foreach (var item in ensamblaje.Registro)
            {
                Console.WriteLine("|---------------------|------|");
                Console.WriteLine(item);
            }
        }
    }
}


