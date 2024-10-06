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
    
    static void vefConta(caixa caixa){
        Console.WriteLine($"ID da conta: {caixa.id}");
        Console.WriteLine($"Tipo de conta: {caixa.conta}");
        Console.WriteLine($"Saldo disponivel: {caixa.saldo}");
    }
    static void saque(caixa caixa){
        Console.WriteLine("Informe o valor do saque: ");
        double saque = double.Parse(Console.ReadLine());
        if(saque < 500 && saque < caixa.saldo){
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

    static void transferencia(caixa caixa, caixa caixa2){
        Console.WriteLine("Informe o valor da transferencia: ");
        double transferencia = double.Parse(Console.ReadLine());
        if(transferencia < caixa.saldo){
            caixa2.saldo = caixa2.saldo + transferencia;
            caixa.saldo = caixa.saldo - transferencia;
            Console.WriteLine("Transferencia realizado com sucesso!");
        }else
            Console.WriteLine("Transferencia invalida!");
    }

    static void Main(){
        caixa conta1 = new caixa(1500, "Corrente", 1);
        caixa conta2 = new caixa(1000, "Salario", 2);
        bool vef = true;
        int contalogin = 1;
        do
        {
            Console.WriteLine("Banco eletronico. Escolha a opção que deseja: \n 1 - verificar conta \n 2 - Realizar saque \n 3 - Realizar deposito \n 4 - Realizar transferencia \n 5 - Sair");
            string esc = Console.ReadLine();
            switch(esc){
                case "1":
                    if(contalogin == 1)
                        vefConta(conta1);
                    if(contalogin == 2)
                        vefConta(conta2);
                    break;
                case "2": 
                    if(contalogin == 1)
                        saque(conta1);
                    if(contalogin == 2)
                        saque(conta2);
                    break;      
                case "3": 
                    if(contalogin == 1)
                        deposito(conta1);
                    if(contalogin == 2)
                        deposito(conta2);
                    break;          
                case "4": 
                    if(contalogin == 1)
                        transferencia(conta1, conta2);
                    if(contalogin == 2)
                        transferencia(conta2, conta1);
                    break;             
                case "5": 
                    vef = false;
                    break;                   
            }
        } while (vef);
    }
    

}

