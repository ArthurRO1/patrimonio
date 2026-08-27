class Conta
{
    private double saldo;
    private bool especial;

    public string Numero{ get; set; } =  "";


    public double Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value < 0 && !Especial)
                throw new Exception("Saldo não pode ser negativo");
            else
            {
                saldo = value;
            }
            
        }
    }

   
    public bool Especial
    {
        get
        {
            return especial;
        }
        set
        {
            
            if (Idade < 18 && value == true)
                throw new Exception("Menores de idade não podem ter conta especial");
            else
            {
                especial = value;
            }
            
        }
    }

    public int Idade{get;set;}
}
   



