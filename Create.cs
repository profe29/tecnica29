/*
Carga un archivo en un array de String, recorre 
el array y separa en campos cada string, 
(los campos estan separados por comas).
Se filtran los archivos de acuerdo al valor
del segundo campo (columna) y los registros
filtrados se guardan en otro archivo de texto
separado por comas.
*/
using System;
using System.IO;
using System.Collections.Generic;

class Create
{
    static void Main(string[] args)
    {
        String[] text = File.ReadAllLines("C:\\Users\\Reconquista\\ver.txt");

        Stack<string> resultado = new Stack<string>();
        String producto;
        int cantidad;
        String estado;

        resultado.Push("Procesado ok " + DateTime.Today);

        foreach (var line in text)
        {
            var campos = line.Split(',');
            producto = campos[0];
            cantidad = Int32.Parse(campos[1]);
            estado = campos[2];

            if (cantidad < 15)
            {
                resultado.Push(line);
            }

        }
        String[] arr = resultado.ToArray();

        System.IO.File.WriteAllLines("C:\\Users\\Reconquista\\out.txt", arr);
    }
}

