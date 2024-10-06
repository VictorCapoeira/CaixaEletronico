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
    static void vefConta(caixa caixa){
        Console.WriteLine($"ID da conta: {caixa.id}");
        Console.WriteLine($"Tipo de conta: {caixa.conta}");
        Console.WriteLine($"Saldo disponivel: {caixa.saldo}");
    }
    static void saque(caixa caixa){
        Console.WriteLine("Informe o valor do saque: ");
        double saque = double.Parse(Console.ReadLine());
        if(saque < 500){
            caixa.saldo = caixa.saldo - saque;
            Console.WriteLine("Saque realizado com sucesso!");
        }else
            Console.WriteLine("Limite de saque invalido!");
        
    }
    static void deposito(caixa caixa){
        Console.WriteLine("Informe o valor do deposito: ");
        double deposito = double.Parse(Console.ReadLine());
        caixa.saldo = caixa.saldo + deposito;
        Console.WriteLine("Deposito realizado com sucesso!");
    }

}

