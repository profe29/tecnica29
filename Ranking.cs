/*
Carga un archivo en un array de String, recorre 
el array y convierte cada elemento en entero.  
Los enteros se agregan a otro array que se ordena 
en forma descendente y se guarda en un archivo.

*/

class Ranking
{
    static void Main(string[] args)
    {		
		ArrayList enteros = new ArrayList();
		
		String[] registros = File.ReadAllLines("C:\\users\\joe\\reproducciones.txt");

		foreach(var registro in registros)
		{
			enteros.Add(Int32.Parse(registro));
		}
		enteros.Sort();
		enteros.Reverse();
		Guardar(enteros);
	}
	
	static void Guardar(ArrayList enteros)
	{
		int i = 0;
		foreach(var registro in enteros)
		{
			File.AppendAllText("C:\\users\\joe\\ranking.txt", "Puesto numero " + i + ": " + registro + "\n");
			i++;
		}
		
	}
	
}

