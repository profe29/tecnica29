/*
Carga un archivo en un array, recorre el array y
convierte cada elemento en entero.  
Calcula el promedio y lo guarda en un archivo.
*/

class Promedio
{
    static void Main(string[] args)
    {		
		int acumulador;
		float promedio;

		String[] registros = File.ReadAllLines("C:\\users\\joe\\mediciones.txt");
		
		acumulador = 0;
		foreach(var registro in registros)
		{
			acumulador += Int32.Parse(registro);
		}
		
		promedio = acumulador / (float) registros.Length;
		Guardar(promedio);
	}
	
	static void Guardar(float v)
	{
		Console.WriteLine("El promedio es: " + v);
		
		File.WriteAllText("C:\\users\\joe\\resultado.txt", v + "\n");
	}
	
}

