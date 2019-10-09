IDictionary<char, string> dict = new Dictionary<char, string>();
dict.Add('A',"14");
dict.Add('B',"01");
dict.Add('C',"00");
dict.Add('D',"16");
dict.Add('E',"05");
dict.Add('F',"20");
dict.Add('G',"19");
dict.Add('H',"09");
dict.Add('I',"24");
dict.Add('J',"07");
dict.Add('K',"21");
dict.Add('L',"08");
dict.Add('M',"04");
dict.Add('N',"13");
dict.Add('O',"25");
dict.Add('P',"22");
dict.Add('Q',"18");
dict.Add('R',"10");
dict.Add('S',"02");
dict.Add('T',"06");
dict.Add('U',"12");
dict.Add('V',"23");
dict.Add('W',"11");
dict.Add('X',"03");
dict.Add('Y',"15");
dict.Add('Z',"17");

String patente;
int Acumulador1 = 0;
int Acumulador2 = 0;
int verificador = 0;

Console.WriteLine("Ingrese la patente y presione <ENTER>");
patente = Console.ReadLine();
patente = patente.ToUpper();

char digito;
String temp = "";
for(int i = 0; i < 3; i++)
{
	digito = patente[i];
	temp = temp + dict[digito];
}

temp = temp + patente.Substring(3);
Console.WriteLine(temp);
Acumulador1 = 0;
Acumulador2 = 0;
for(int i = 0; i < temp.Length; i++)
{
	if(0 == (i%2))
	{
		Acumulador1 += Int32.Parse(temp[i].ToString());
	}
	else
	{
		Acumulador2 += Int32.Parse(temp[i].ToString());
	}
}

if(Acumulador1 > 10)
{
	Acumulador1 = (Acumulador1/10) + (Acumulador1%10);
}

if(Acumulador2 > 10)
{
	Acumulador2 = (Acumulador2/10) + (Acumulador2%10);
}

verificador = 10 * Acumulador1 + Acumulador2;

Console.WriteLine("El verificador de " + patente + " es: " + verificador);
