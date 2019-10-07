/*
Carga un archivo en un array, recorre el array y
convierte cada elemento en entero.  
Realiza la suma total y la guarda en un archivo.
*/

class Total
{
    static void Main(string[] args)
    {		
		int acumulador;

		String[] registros = File.ReadAllLines("C:\\users\\joe\\mediciones.txt");
		
		acumulador = 0;
		foreach(var registro in registros)
		{
			acumulador += Int32.Parse(registro);
		}
		
		Guardar(acumulador);
	}
	
	static void Guardar(int v)
	{
		Console.WriteLine("El total es: " + v);
		
		File.WriteAllText("C:\\users\\joe\\resultado.txt", v + "\n");
	}
	
}

