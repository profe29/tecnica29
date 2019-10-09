/*
Algoritmo Cuil

*/

const int Hombre = 0;
const int Mujer = 1;
const int Sociedad = 2;

String DNI = "";
int sexo = Hombre;

String prefijo;
int DigitoActual;
String temp;

int[] coeficientes = {5, 4, 3, 2, 7, 6, 5, 4, 3, 2};
int Acumulador = 0;
int resto;
int DigitoVerificador = 0;

Console.WriteLine("Ingrese el DNI (8 digitos, sin puntos):");
DNI = Console.ReadLine();

Console.WriteLine("Ingrese el sexo (Hombre=0,  Mujer=1,  Sociedad=2):");
sexo = Int32.Parse(Console.ReadLine());


prefijo = "  ";
switch(sexo)
{
	case Hombre:
		prefijo = "20";
	break;
	
	case Mujer:
		prefijo = "27";
	break;
	
	case Sociedad:
		prefijo = "30";
	break;
}


temp = prefijo + DNI;


Acumulador = 0;
for(int i = 0; i < 10; i++)
{
	DigitoActual = Int32.Parse(temp[i].ToString());
	Acumulador = Acumulador + coeficientes[i] * DigitoActual;
}
resto = Acumulador % 11;

switch(resto)
{
	case 0:
		DigitoVerificador = 0;
	break;
	
	case 1:
		if(Hombre == sexo)
		{
			DigitoVerificador = 9;
			prefijo = "23";
		}
		else if(Mujer == sexo)
		{
			DigitoVerificador = 4;
			prefijo = "23";
		}
	break;
	
	default:
		DigitoVerificador = 11 - resto;
	break;
}

Console.WriteLine("CUIL: " + prefijo + "-" + DNI + "-" + DigitoVerificador);
