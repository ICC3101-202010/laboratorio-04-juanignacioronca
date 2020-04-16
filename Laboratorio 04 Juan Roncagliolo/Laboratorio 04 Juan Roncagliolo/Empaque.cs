using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_04_Juan_Roncagliolo
{
    class Empaque : Maquina
    {
        //Atributos:
        public int Objetos_recibidos;
        public int Productos_enviados;
        //Metodos
        public string Enviar_producto(Empaque empaque)
        {
            if (empaque.Hora < 4 | empaque.Hora > 21)
            {
                string b;
                b = "| " + empaque.Apagado() + " |  " + empaque.Hora.ToString("00") + "  |";
                empaque.Apagado();
                empaque.Registro.Add(b);
                Objetos_recibidos = 0;
                Productos_enviados = Objetos_recibidos;
            }
            else
            {
                if (empaque.Estado == "Encendido")
                {
                }
                else
                {
                    string b;
                    b = "|" + empaque.Encendido() + "|  " + empaque.Hora.ToString("00") + "  |";
                    empaque.Registro.Add(b);
                }
            }
            string a;
            if (empaque.Estado == "Encendido")
            {
                Random rnd = new Random();
                if (empaque.Memoria < 800)
                {
                    empaque.Productos_enviados = empaque.Objetos_recibidos;
                    empaque.Memoria += empaque.Productos_enviados;
                    a = "| " + empaque.Objetos_recibidos.ToString("000") + " | " + empaque.Productos_enviados.ToString("000") + " | " + empaque.Memoria.ToString("0000") + " |  " + empaque.Hora.ToString("00") + "  |";
                    empaque.Registro.Add(a);
                    return a;
                }
                else
                {
                    empaque.Productos_enviados = empaque.Objetos_recibidos ;
                    empaque.Memoria += empaque.Productos_enviados;
                    a = "|" + empaque.Reinicio() + "|  " + empaque.Hora.ToString("00") + "  |";
                    empaque.Registro.Add(a);
                    return a;
                }
            }
            else
            {
                return "";
            }

        }
        public void Ver_Informacion(Empaque empaque)
        {
            Console.WriteLine("| Maquina Empaque  | Hora |");
            Console.WriteLine("|  OR |  OE |  ME  | Hora |");
            foreach (var item in empaque.Registro)
            {
                Console.WriteLine("|-------------------|------|");
                Console.WriteLine(item);
            }
        }
        public void Ver_Informacion_2(Recepcion recepcion, Almacenamiento almacenamiento, Ensamblaje ensamblaje, Verificacion verificacion, Empaque empaque)
        {
            Console.WriteLine("| Maquina Recepcion  |  Maquina Almacenamiento   |  Maquina Ensablaje   | Maquina Verificacion  | Maquina Empaque  | Hora |");
            Console.WriteLine("|  PR  |  PE  |  ME  |  PR  |  PA  |  PE  |  ME  |  PR   | OE   |  ME   |   OR  |   OE   |  ME  |  OR |  OE |  ME  | Hora |");
            for (int i = 0; i < Registro.Count; i++)
            {
                Console.WriteLine("|--------------------|---------------------------|----------------------|-----------------------|------------------|------|");
                Console.WriteLine(recepcion.Registro[i].Substring(0, recepcion.Registro[i].Length - 8) 
                                + almacenamiento.Registro[i].Substring(0, almacenamiento.Registro[i].Length - 8)
                                + ensamblaje.Registro[i].Substring(0, ensamblaje.Registro[i].Length - 8)
                                + verificacion.Registro[i].Substring(0, verificacion.Registro[i].Length - 8)
                                + empaque.Registro[i]);
            }
        }
    }
}



