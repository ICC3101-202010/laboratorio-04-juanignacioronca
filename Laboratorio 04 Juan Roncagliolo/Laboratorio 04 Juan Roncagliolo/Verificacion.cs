using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    class Verificacion : Maquina
    {
        //Atributos:
        public int Objetos_recibidos;
        public int Objetos_enviados;
        //Metodos
        public string Enviar_a_empaque(Verificacion verificacion)
        {
            if (verificacion.Hora < 4 | verificacion.Hora > 21)
            {
                string b;
                b = "|    " + verificacion.Apagado() + "   |  " + verificacion.Hora.ToString("00") + "  |";
                verificacion.Apagado();
                verificacion.Registro.Add(b);
                Objetos_recibidos = 0;
                Objetos_enviados = Objetos_recibidos;
            }
            else
            {
                if (verificacion.Estado == "Encendido")
                {
                }
                else
                {
                    string b;
                    b = "|    " + verificacion.Encendido() + " |  " + verificacion.Hora.ToString("00") + "  |";
                    verificacion.Registro.Add(b);
                }
            }
            string a;
            if (verificacion.Estado == "Encendido")
            {
                if (verificacion.Memoria < 500)
                {
                    verificacion.Objetos_enviados = verificacion.Objetos_recibidos ;
                    verificacion.Memoria += verificacion.Objetos_enviados;
                    a = "|  " + verificacion.Objetos_recibidos.ToString("0000") + " |  " + verificacion.Objetos_enviados.ToString("0000") + "  | " + verificacion.Memoria.ToString("0000") + " |  " + verificacion.Hora.ToString("00") + "  |";
                    verificacion.Registro.Add(a);
                    return a;
                }
                else
                {
                    verificacion.Objetos_enviados = verificacion.Objetos_recibidos ;
                    verificacion.Memoria += verificacion.Objetos_enviados;
                    a = "|   " + verificacion.Reinicio(verificacion.Nombre) + "  |  " + verificacion.Hora.ToString("00") + "  |";
                    verificacion.Registro.Add(a);
                    return a;
                }
            }
            else
            {
                return "";
            }

        }
        public void Ver_Informacion(Verificacion verificacion)
        {
            Console.WriteLine("| Maquina Verificacion  | Hora |");
            Console.WriteLine("|   OR  |   OE   |  ME  | Hora |");
            foreach (var item in verificacion.Registro)
            {
                Console.WriteLine("|---------------------|------|");
                Console.WriteLine(item);
            }
        }
    }
}
