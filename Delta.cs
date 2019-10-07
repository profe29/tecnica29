/*
Carga un archivo en un array, recorre el array y
convierte cada elemento en entero.  
Calcula la variacion en porcentaje y la guarda 
en otro archivo.
*/

class Delta
{
    static void Main(string[] args)
    {		
		int delta;
		int actual;
		int anterior;
		ArrayList porcentajes = new ArrayList();
		float porcentaje;

		String[] registros = File.ReadAllLines("C:\\users\\joe\\mediciones.txt");
		
		anterior = Int32.Parse(registros[0]);
		foreach(var registro in registros)
		{
			actual = Int32.Parse(registro);
			delta = actual - anterior;
			porcentaje = delta / (float)anterior;
			porcentajes.Add(porcentaje);
			
			anterior = actual;
		}
		
		Guardar(porcentajes);
	}
	
	static void Guardar(ArrayList porcentajes)
	{
		foreach(var registro in porcentajes)
		{
			File.AppendAllText("C:\\users\\joe\\porcentajes.txt", registro + "%\n");
		}
	}
	
}

