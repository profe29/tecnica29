/*
Carga un archivo en un array de String, recorre 
el array y separa en campos cada string, 
(los campos estan separados por comas).
Se filtran los archivos de acuerdo al valor
del segundo campo (columna) y se actualiza ese
valor.
*/
using System;
using System.IO;
using System.Collections.Generic;

class Update
{
    static void Main(string[] args)
    {		
		String[] text = File.ReadAllLines("C:\\Users\\Reconquista\\ver.txt");
		Queue<string> resultado = new Queue<string>();
		String producto;
		int cantidad;
		String estado;

		for(int i = 0; i < text.Length; i++)
		{
			var campos = text[i].Split(',');
			producto = campos[0];

			cantidad = Int32.Parse(campos[1]);
			estado = campos[2];
			
			if(cantidad < 100)
			{
			  cantidad = cantidad * 2;
			}
			
			String[] linea = new String[3];
			linea[0] = producto;
			linea[1] = cantidad.ToString();
			linea[2] = estado;
			
			resultado.Enqueue(String.Join(",", linea));
			
		}

		String[] arr = resultado.ToArray();

        System.IO.File.WriteAllLines("C:\\Users\\Reconquista\\ver.txt", arr);
	}
}
