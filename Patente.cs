/*
Algoritmo CBU
*/


IDictionary<long, string> dict = new Dictionary<long, string>();

//http://www.bcra.gob.ar/SistemasFinancierosYdePagos/Sistema_financiero_nomina_de_entidades.asp?bco=AAA00&tipo=1
dict.Add(00007, 	"BANCO DE GALICIA Y BUENOS AIRES S.A.U.");
dict.Add(00011, 	"BANCO DE LA NACION ARGENTINA");
dict.Add(00014, 	"BANCO DE LA PROVINCIA DE BUENOS AIRES");
dict.Add(00015, 	"INDUSTRIAL AND COMMERCIAL BANK OF CHINA");
dict.Add(00016, 	"CITIBANK N.A.");
dict.Add(00017, 	"BBVA BANCO FRANCES S.A.");
dict.Add(00020, 	"BANCO DE LA PROVINCIA DE CORDOBA S.A.");
dict.Add(00027, 	"BANCO SUPERVIELLE S.A.");
dict.Add(00029, 	"BANCO DE LA CIUDAD DE BUENOS AIRES");
dict.Add(00034, 	"BANCO PATAGONIA S.A.");
dict.Add(00044, 	"BANCO HIPOTECARIO S.A.");
dict.Add(00045, 	"BANCO DE SAN JUAN S.A.");
dict.Add(00060, 	"BANCO DEL TUCUMAN S.A.");
dict.Add(00065, 	"BANCO MUNICIPAL DE ROSARIO");
dict.Add(00072, 	"BANCO SANTANDER RIO S.A.");
dict.Add(00083, 	"BANCO DEL CHUBUT S.A.");
dict.Add(00086, 	"BANCO DE SANTA CRUZ S.A.");
dict.Add(00093, 	"BANCO DE LA PAMPA SOCIEDAD DE ECONOMÍA M");
dict.Add(00094, 	"BANCO DE CORRIENTES S.A.");
dict.Add(00097, 	"BANCO PROVINCIA DEL NEUQUÉN SOCIEDAD ANÓ");
dict.Add(00143, 	"BRUBANK S.A.U.");
dict.Add(00147, 	"BANCO INTERFINANZAS S.A.");
dict.Add(00150, 	"HSBC BANK ARGENTINA S.A.");
dict.Add(00165, 	"JPMORGAN CHASE BANK, NATIONAL ASSOCIATIO");
dict.Add(00191, 	"BANCO CREDICOOP COOPERATIVO LIMITADO");
dict.Add(00198, 	"BANCO DE VALORES S.A.");
dict.Add(00247, 	"BANCO ROELA S.A.");
dict.Add(00254, 	"BANCO MARIVA S.A.");
dict.Add(00259, 	"BANCO ITAU ARGENTINA S.A.");
dict.Add(00262, 	"BANK OF AMERICA, NATIONAL ASSOCIATION");
dict.Add(00266, 	"BNP PARIBAS");
dict.Add(00268, 	"BANCO PROVINCIA DE TIERRA DEL FUEGO");
dict.Add(00269, 	"BANCO DE LA REPUBLICA ORIENTAL DEL URUGU");
dict.Add(00277, 	"BANCO SAENZ S.A.");
dict.Add(00281, 	"BANCO MERIDIAN S.A.");
dict.Add(00285, 	"BANCO MACRO S.A.");
dict.Add(00299, 	"BANCO COMAFI SOCIEDAD ANONIMA");
dict.Add(00300, 	"BANCO DE INVERSION Y COMERCIO EXTERIOR S");
dict.Add(00301, 	"BANCO PIANO S.A.");
dict.Add(00305, 	"BANCO JULIO SOCIEDAD ANONIMA");
dict.Add(00309, 	"BANCO RIOJA SOCIEDAD ANONIMA UNIPERSONAL");
dict.Add(00310, 	"BANCO DEL SOL S.A.");
dict.Add(00311, 	"NUEVO BANCO DEL CHACO S. A.");
dict.Add(00312, 	"BANCO VOII S.A.");
dict.Add(00315, 	"BANCO DE FORMOSA S.A.");
dict.Add(00319, 	"BANCO CMF S.A.");
dict.Add(00321, 	"BANCO DE SANTIAGO DEL ESTERO S.A.");
dict.Add(00322, 	"BANCO INDUSTRIAL S.A.");
dict.Add(00330, 	"NUEVO BANCO DE SANTA FE SOCIEDAD ANONIMA");
dict.Add(00331, 	"BANCO CETELEM ARGENTINA S.A.");
dict.Add(00332, 	"BANCO DE SERVICIOS FINANCIEROS S.A.");
dict.Add(00336, 	"BANCO BRADESCO ARGENTINA S.A.U.");
dict.Add(00338, 	"BANCO DE SERVICIOS Y TRANSACCIONES S.A.");
dict.Add(00339, 	"RCI BANQUE S.A.");
dict.Add(00340, 	"BACS BANCO DE CREDITO Y SECURITIZACION S");
dict.Add(00341, 	"BANCO MASVENTAS S.A.");
dict.Add(00384, 	"WILOBANK S.A.");
dict.Add(00386, 	"NUEVO BANCO DE ENTRE RÍOS S.A.");
dict.Add(00389, 	"BANCO COLUMBIA S.A.");
dict.Add(00426, 	"BANCO BICA S.A.");
dict.Add(00431, 	"BANCO COINAG S.A.");
dict.Add(00432, 	"BANCO DE COMERCIO S.A.");
dict.Add(44059, 	"FORD CREDIT COMPAÑIA FINANCIERA S.A.");
dict.Add(44077, 	"COMPAÑIA FINANCIERA ARGENTINA S.A.");
dict.Add(44088, 	"VOLKSWAGEN FINANCIAL SERVICES COMPAÑIA F");
dict.Add(44090, 	"CORDIAL COMPAÑÍA FINANCIERA S.A.");
dict.Add(44092, 	"FCA COMPAÑIA FINANCIERA S.A.");
dict.Add(44093, 	"GPAT COMPAÑIA FINANCIERA S.A.U.");
dict.Add(44094, 	"MERCEDES-BENZ COMPAÑÍA FINANCIERA ARGENT");
dict.Add(44095, 	"ROMBO COMPAÑÍA FINANCIERA S.A.");
dict.Add(44096, 	"JOHN DEERE CREDIT COMPAÑÍA FINANCIERA S.");
dict.Add(44098, 	"PSA FINANCE ARGENTINA COMPAÑÍA FINANCIER");
dict.Add(44099, 	"TOYOTA COMPAÑÍA FINANCIERA DE ARGENTINA");
dict.Add(44100, 	"FINANDINO COMPAÑIA FINANCIERA S.A.");
dict.Add(45056, 	"MONTEMAR COMPAÑIA FINANCIERA S.A.");
dict.Add(45072, 	"TRANSATLANTICA COMPAÑIA FINANCIERA S.A.");
dict.Add(65203, 	"CAJA DE CREDITO \"CUENCA\" COOPERATIVA LIM");


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
		Console.WriteLine("Banco: " + CBU.Substring(0, 3) + " - " + dict[Int32.Parse(CBU.Substring(0, 3))]);
		Console.WriteLine("Sucursal: " + CBU.Substring(3, 4));
		Console.WriteLine("Cuenta: " + CBU.Substring(8, 13));
	}
}
