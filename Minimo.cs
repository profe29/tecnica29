/*
Carga un archivo en un array, recorre el array y
convierte cada elemento en entero.  Si el valor
obtenido es mayor al minimo permitido lo agrega
a un archivo.
*/

class Filtro
{
	public const int MinimoPermitido = 100;
	
    static void Main(string[] args)
    {		
		String[] registros = File.ReadAllLines("C:\\users\\joe\\test.txt");
		
		foreach(var registro in registros)
		{
			if(Int32.Parse(registro) > MinimoPermitido)
			{
				Guardar(registro);
			}
		}

	}
	
	static void Guardar(string v)
	{
		
		Console.WriteLine("El valor " + v + " supera el minimo permitido");
		
		File.AppendAllText("C:\\users\\joe\\filtrado.txt", v + "\n");
	}
	
}

