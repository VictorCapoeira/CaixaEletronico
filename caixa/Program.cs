public class caixa{
    public double saldo {get; set;}
    public string conta {get; set;}
    public int id {get;}

    public caixa(double s, string c, int i){
        saldo = s;
        conta = c;
        id = id;
    }
}

class Program{
    caixa conta1 = new caixa(1500, "Corrente", 1);
    caixa conta2 = new caixa(1000, "Salario", 2);
}

