string vatCode = "00883601007";
CheckVatCode(vatCode);

void CheckVatCode(string vatCode)
{
	//T = (X+Y) mod 10 = 0
	//X = Somma delle cifre pari (partendo da c=0)
	//Y = Somma dei doppi delle cifre dispari, sottraendo 9 se il doppio della cifre è superiore a 9
	var sum = 0;
	for (var c = 0; c < vatCode.Length; c++)
	{
         var intNumber = Int32.Parse(vatCode[c].ToString());
		if (c % 2 != 0)
		{
			//Dispari
			if (intNumber * 2 > 9)
				sum += (intNumber * 2) - 9;
			else
				sum += intNumber * 2;

			continue;
		}

		if (c % 2 == 0)
		{
			//Pari
			sum += intNumber;
		}
	}

	//Se divideno la somma per 10 il resto è 0, la partita iva è valida
	if (sum % 10 == 0)
     {
         Console.WriteLine("VALIDA");
         return;
     }
				
     Console.WriteLine("NON VALIDA");
}