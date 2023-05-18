using System;
namespace Atividade
{
    class Program
    {
        static void Main (string [] args)
        {
            float valpag;
            Console.WriteLine ("Cliente é Pessoa física(p) ou Jurídica(j)? ");
            string Tipo = Console.ReadLine();
            if (Tipo == "p")
            {  

           Pessoafisica pf = new Pessoafisica();
           Console.WriteLine ("Informe seu nome: ");
           pf.nomef = Console.ReadLine();
           Console.WriteLine ("Informe seu endereço: ");
           pf.endf = Console.ReadLine();
           Console.WriteLine ("Informe seu RG: ");
           pf.rg = Console.ReadLine();
           Console.WriteLine ("Informe seu CPF: ");
           pf.cpf = Console.ReadLine();
           Console.WriteLine ("Informe o valor da compra: ");
           valpag = float.Parse(Console.ReadLine()) ;
           pf.Pagarimpost(valpag);
           Console.WriteLine("========PESSOA FÍSICA=======");
           Console.WriteLine("NOME DO CLIENTE: " + pf.nomef);
           Console.WriteLine("ENDEREÇO DO CLIENTE: " + pf.endf);
           Console.WriteLine("RG: "+ pf.rg);
           Console.WriteLine("CPF: "+ pf.cpf);
           Console.WriteLine("VALOR DA COMPRA: "+ valpag);
           Console.WriteLine("TOTAL A PAGAR: "+ pf.total);
   
            }




           else 
           {
            Console.WriteLine("Digite (p) para Pessoa física e (f) para Júridica.");
           }
        
            if (Tipo == "j")
            {
                Pessoajuridica pj = new Pessoajuridica();
                Console.WriteLine("Nome da Empresa: ");
                pj.nomej = Console.ReadLine();
                Console.WriteLine("Endereço da Empresa: ");
                pj.endj = Console.ReadLine();
                Console.WriteLine("CNPJ da Empresa: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("IE da Empresa: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Valor da compra: ");
                valpag = float.Parse( Console.ReadLine());
                Console.WriteLine("========PESSOA JUÍDICA=======");
                Console.WriteLine("NOME DO CLIENTE: " + pj.nomej);
                Console.WriteLine("ENDEREÇO DO CLIENTE: " + pj.endj);
                Console.WriteLine("CNPJ: "+ pj.cnpj);
                Console.WriteLine("IE: "+ pj.ie);
                Console.WriteLine("VALOR DA COMPRA: "+ valpag);
                Console.WriteLine("TOTAL A PAGAR: "+ pj.total);
            }  
              else 
           {
            Console.WriteLine("Digite (p) para Pessoa física e (f) para Júridica.");
           }
        
            
            
        }
    }
}