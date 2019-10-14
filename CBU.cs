/*
Algoritmo CBU
*/

int[] ponderador1 = {7, 1, 3, 9, 7, 1, 3};
int[] ponderador2 = {3, 9, 7, 1, 3, 9, 7, 1, 3, 9, 7, 1, 3};
 
int DigitoActual;
int acumulador = 0;
int resultado1 = 0;
int resultado2 = 0;
int DigitoVerificador = 0;
String CBU;
int diferencia;

Console.WriteLine("Ingrese el CBU (22 digitos):");
CBU = Console.ReadLine();


//Validacion de primer bloque
acumulador = 0;
DigitoVerificador = Int32.Parse(CBU[7].ToString());
for(int i = 0; i < 7; i++)
{
	DigitoActual = Int32.Parse(CBU[i].ToString());
	acumulador = acumulador + ponderador1[i] * DigitoActual;
}
diferencia = 10 - (acumulador % 10);
if(diferencia == DigitoVerificador)
{
	if(acumulador != 0)
	{
		//CBU OK
		Console.WriteLine("Primer bloque CBU correcto");
		resultado1 = 1;
	}
	else
	{
		//ERROR
		Console.WriteLine("CBU incorrecto");
	}
}
else if( (0 == DigitoVerificador) && (10 == diferencia) )
{
	//CBU OK
	Console.WriteLine("Primer bloque CBU correcto");
	resultado1 = 1;
}
else
{
	//ERROR
	Console.WriteLine("CBU incorrecto");
}



if(1 == resultado1)
{
	//Validacion de segundo bloque
	acumulador = 0;
	DigitoVerificador = Int32.Parse(CBU[21].ToString());
	for(int i = 0; i < 13; i++)
	{
		DigitoActual = Int32.Parse(CBU[i+8].ToString());
		acumulador = acumulador + ponderador2[i] * DigitoActual;
	}
	diferencia = 10 - (acumulador % 10);
	if(diferencia == DigitoVerificador)
	{
		if(acumulador != 0)
		{
			//CBU OK
			Console.WriteLine("Segundo bloque CBU correcto");
			resultado2 = 1;
		}
		else
		{
			//ERROR
			Console.WriteLine("CBU incorrecto");
		}
	}
	else if( (0 == DigitoVerificador) && (10 == diferencia) )
	{
		//CBU OK
		Console.WriteLine("Segundo bloque CBU correcto");
		resultado2 = 1;
	}
	else
	{
		//ERROR
		Console.WriteLine("CBU incorrecto");
	}
	
	if(1 == resultado2)
	{
		Console.WriteLine("Banco: " + CBU.Substring(0, 3));
		Console.WriteLine("Sucursal: " + CBU.Substring(3, 4));
		Console.WriteLine("Cuenta: " + CBU.Substring(8, 13));
	}
}
