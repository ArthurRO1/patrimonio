Calculadora calc = new Calculadora();

//string nome = new string("Arthur");

calc.Valor1 = 5;
calc.Valor2 = 10;

//Calculadora calc2 = calc;
//calc2.valor1 = 3;
//calc2.valor2 = 3;

Console.WriteLine(calc.somar());

Console.WriteLine(calc.subtrair());

Console.WriteLine(calc.multiplicar());

Console.WriteLine(calc.dividir());

class Calculadora
{
    public int Valor1 {get; set;}

    public int Valor2 {get; set;}

    public int somar()
    {
        return Valor1 + Valor2;
    }
    public int subtrair()
    {
        return Valor1 - Valor2;
    }
    public int multiplicar()
    {
        return Valor1 * Valor2;
    }
    public int dividir()
    {
        return Valor1 / Valor2;
    }


}

