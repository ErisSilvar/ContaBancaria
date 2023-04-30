using System;

class Program {
  public static void Main (string[] args) {
    ContaBanco c1 = new ContaBanco();
        c1.DefinirLimite(100);   
        c1.senha("123");
        
            if (!c1.SenhaValida("123")){
            Console.WriteLine("Senha incorreta");
            return;
        }
        
        c1.depositar(200); 
  
        if (!c1.sacar(2)){    
        }else{
            Console.WriteLine("Seu saldo atual é: " + c1.saldo);
        }
       }
    }  