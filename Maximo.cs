/*
Carga un archivo en un array, recorre el array y
convierte cada elemento en entero.  Si el valor
obtenido no supera el maximo permitido lo agrega
a un archivo.
*/

class Filtro
{
	public const int MaximoPermitido = 100;
	
    static void Main(string[] args)
    {		
		String[] registros = File.ReadAllLines("C:\\users\\joe\\test.txt");
		
		foreach(var registro in registros)
		{
			if(Int32.Parse(registro) <= MaximoPermitido)
			{
				Guardar(registro);
			}
		}

	}
	
	static void Guardar(string v)
	{
		
		Console.WriteLine("El valor " + v + " no supera el maximo permitido");
		
		File.AppendAllText("C:\\users\\joe\\filtrado.txt", v + "\n");
	}
	
}

