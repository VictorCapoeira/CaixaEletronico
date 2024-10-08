﻿public class caixa{
    public double saldo {get; set;}
    public string conta {get; set;}
    public string extrato {get; set;}
    public int id {get;}

    public caixa(double s, string c, int i){
        saldo = s;
        conta = c;
        id = id;
        extrato = "";
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
            caixa.extrato += $"- {saque} \n";
        }else
            Console.WriteLine("Limite de saque invalido!");
        
    }
    static void deposito(caixa caixa){
        Console.WriteLine("Informe o valor do deposito: ");
        double deposito = double.Parse(Console.ReadLine());
        caixa.saldo = caixa.saldo + deposito;
        caixa.extrato += $"+ {deposito} \n";
        Console.WriteLine("Deposito realizado com sucesso!");
    }

    static void transferencia(caixa caixa, caixa caixa2){
        Console.WriteLine($"Saldo inicial da conta 2 (apenas por referencia de estudo): {caixa2.saldo}");
        Console.WriteLine("Informe o valor da transferencia: ");
        double transferencia = double.Parse(Console.ReadLine());
        if(transferencia < caixa.saldo){
            caixa2.saldo = caixa2.saldo + transferencia;
            caixa.saldo = caixa.saldo - transferencia;
            Console.WriteLine("Transferencia realizado com sucesso!");
            caixa.extrato += $"- {transferencia} \n";
        }else
            Console.WriteLine("Transferencia invalida!");
        Console.WriteLine($"Saldo final da conta 2 (apenas por referencia de estudo): {caixa2.saldo}");
    }

    static void Main(){
        caixa conta1 = new caixa(1500, "Corrente", 1);
        caixa conta2 = new caixa(1000, "Salario", 2);
        bool vef = true;
        int contalogin = 1;
        do
        {
            Console.WriteLine("Banco eletronico. Escolha a opção que deseja: \n 1 - verificar conta \n 2 - Realizar saque \n 3 - Realizar deposito \n 4 - Realizar transferencia \n 5 - Extrato \n 6 - Sair");
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
                    Console.WriteLine("Extrato da conta: ");
                    if(contalogin == 1)
                        Console.WriteLine(conta1.extrato);
                    if(contalogin == 2)
                        Console.WriteLine(conta2.extrato);
                    break;             
                case "6": 
                    vef = false;
                    break;                   
            }
            Console.ReadKey();
            Console.Clear();
        } while (vef);
    }
    

}

