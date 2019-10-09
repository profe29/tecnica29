String Tarjeta = "";
int Acumulador = 0;
int DigitoActual;
int DigitoVerificador;

/*
Algoritmo Luhn

Dada una secuencia de 16 dígitos,
se toman los primeros 15,
a las posiciones pares se las 
multiplica por 2, si el resultado 
tiene 2 dígitos (> 10), se suman esos 
2 dígitos para obtener 1 dígito.
Finalmente se suman esos valores
obtenidos a los valores de las 
posiciones impares.
El resultado de la suma total se multiplica
por 9, el último dígito del número obtenido 
es el dígito verificador (última posición
en el número de tarjeta).

Se utiliza para tarjetas de crédito,
débito, tarjetas SUBE.
*/

Console.WriteLine("Ingrese los 16 digitos de la tarjeta sin espacios ni guiones:");
Tarjeta = Console.ReadLine();

for(int i = 0; i < 15; i++)
{
	DigitoActual = Int32.Parse(Tarjeta[i].ToString());
	if(0 == (i%2))
	{
		if(DigitoActual< 5)
		{
			Acumulador += (DigitoActual*2);
		}
		else
		{
			Acumulador += ( ((DigitoActual*2)/10) + ((DigitoActual*2)%10) );
		}		
	}
	else
	{
		Acumulador += DigitoActual;
	}
}
DigitoVerificador = (Acumulador * 9) % 10;

if(DigitoVerificador == Int32.Parse(Tarjeta[15].ToString()))
{
	Console.WriteLine("Numero de tarjeta VALIDO");
}
else
{
	Console.WriteLine("Numero de tarjeta NO VALIDO");
}
