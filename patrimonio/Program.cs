//Calculadora calc = new Calculadora();

//string nome = new string("Arthur");

//calc.Valor1 = 5;
//calc.Valor2 = 10;

//Calculadora calc2 = calc;
//calc2.valor1 = 3;
//calc2.valor2 = 3;

//Console.WriteLine(calc.somar());

//Console.WriteLine(calc.subtrair());

//Console.WriteLine(calc.multiplicar());

//Console.WriteLine(calc.dividir());

//class Calculadora
//{
  //  public int Valor1 {get; set;}

//    public int Valor2 {get; set;}

  //  public int somar()
    //{
      //  return Valor1 + Valor2;
    //}
    //public int subtrair()
    //{
      //  return Valor1 - Valor2;
    //}
    //public int multiplicar()
    //{
      //  return Valor1 * Valor2;
    //}
    //public int dividir()
    //{
    //    return Valor1 / Valor2;
    //}


//}

Conta conta = new Conta();

conta.Numero = "123";
conta.Idade = 25;
conta.Especial = true;
conta.Saldo = -1000;

Console.WriteLine($"Numero da conta: {conta.Numero}");
Console.WriteLine($"Saldo da conta: {conta.Saldo}");
Console.WriteLine($"Especial da conta: {conta.Especial}");

Console.WriteLine("Precion enter");

using Patrimonio.Dominio;

Client cli01 = new Client();
cli01.Id = 0;
cli01.Nome = "User";
cli01.Nascimento = new DateTime(1985, 10, 1);
Console.WriteLine(cli01.Nascimento);

Client cli02 = new Client(1, "Arthur", new DateTime(2006, 11, 14));

Console.WriteLine(cli02.Nascimento);

