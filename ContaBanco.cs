using System;

public class ContaBanco
{
    private UInt32 Numero;
    private Decimal Saldo;
    private Decimal Limite;
    private String strSenha;

    public void senha(String novaSenha)
    {
        if (novaSenha.Length > 12)
        {
            throw new ArgumentException("A senha deve ter até 12 caracteres.");
        }
        strSenha = novaSenha;
    }

    public Double gerador()
    {
        return Math.Floor(new Random().NextDouble() * 1000) + 1;
    }

    public bool DefinirLimite(Decimal valor)
    {
        Limite = valor;
        return true;
    }

    public bool sacar(Decimal valor)
    {
        if (valor > (this.saldo + this.Limite))
        {
            return false;
        }
        this.Saldo -= valor;
        if (this.saldo < 0)
        {
            Console.WriteLine("Saldo insuficiente");
            this.Saldo += valor; 
            return false;
        }
        return true;
    }

    public bool depositar(Decimal valor)
    {
        Saldo = Saldo = valor;
        return true;
    }

    public String sugerirSenha()
    {
        return "1234567";
        
    }

    public bool SenhaValida(String SenhaDigitada)
    {
        return (SenhaDigitada == strSenha);
    }

    public Decimal saldo
    {
        get { return Saldo; }
    }
}
