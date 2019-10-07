/*
Carga un archivo en un array de String, recorre 
el array y convierte cada elemento en entero.  
Los enteros se agregan a otro array que se ordena 
y se guarda en un archivo.
*/

class Ordena
{
    static void Main(string[] args)
    {		
		ArrayList enteros = new ArrayList();
		
		String[] registros = File.ReadAllLines("C:\\users\\joe\\mediciones.txt");

		foreach(var registro in registros)
		{
			enteros.Add(Int32.Parse(registro));
		}
		enteros.Sort();
		Guardar(enteros);
	}
	
	static void Guardar(ArrayList enteros)
	{
		foreach(var registro in enteros)
		{
			File.AppendAllText("C:\\users\\joe\\resultado.txt", registro + "\n");
		}
		
	}
	
}

