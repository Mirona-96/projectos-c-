using System.Globalization;

class Conta
{
    public int _numeroConta { get; private set; }  
    public string NomeTitular { get; set; }
    public double SaldoConta { get; set; }
    public int Nib { get; set; }

    CultureInfo culture = CultureInfo.InvariantCulture;

    public Conta (int numeroConta, string nomeTitular, double saldoConta, int nib)
    {   _numeroConta = numeroConta;
        NomeTitular = nomeTitular;
        SaldoConta = saldoConta;
        Nib= nib;
    }

    public Conta()
    {

    }

    public void deposito (double valor)
    {
        SaldoConta += valor;
        Console.WriteLine("\nSaldo: " + SaldoConta + " MZN");
    }

    public void saque (double valor)
    {
        double saldoInicial = SaldoConta;
        double taxaSaque = 5.00; 
        if (SaldoConta >= valor)
        {
            SaldoConta -= (valor + taxaSaque);
            Console.WriteLine("Saldo da Conta: " + SaldoConta + " MZN");
        } else
        {
            SaldoConta = saldoInicial;
            Console.WriteLine("impossível realizar a operação" +
                "\nSaldo da Conta: " + SaldoConta + " MZN");
        }
    }

    public void transferencia (double valor, Conta contaDestino)
    {
        double saldoInicial = SaldoConta;
        if (SaldoConta >= valor)
        {
            SaldoConta -= valor;
            contaDestino.SaldoConta += valor;
            Console.WriteLine("Operacao realizada com sucesso, montante tranferido para a conta" + contaDestino.Nib + ". \nSaldo da Conta: " + " MZN");
        } else
        {
            SaldoConta = saldoInicial;
            Console.WriteLine("Saldo insuficiente para realizar a transferência "
                + "\nSaldo da Conta: " + SaldoConta + " MZN");
        }
    }

    public void pgtoServico (double valor)
    {
        double saldoInicial = SaldoConta;
        if (SaldoConta >= valor)
        {
            SaldoConta -= valor;
            Console.WriteLine("Saldo da Conta: " + SaldoConta + " MZN");
        } else
        {
            SaldoConta = saldoInicial;
            Console.WriteLine("Saldo insuficiente para realizar o pagamento do servico" 
                + "\nSaldo da Conta: " + SaldoConta + " MZN");
        }

    }

    public void Imprimir()
    {
        Console.WriteLine("\nnumero da conta: " + _numeroConta
           + "\nTitular da conta: " + NomeTitular
           + "\nNIB: " + Nib
           + "\nSaldo da Conta: " + SaldoConta.ToString("F2", culture) + " MZN") ; 
    }
}
