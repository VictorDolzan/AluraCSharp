using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;



namespace CSharpAluraDois.byteBankCinco
{
    class ByteBankCinco
    {
        public static void ExecutarByteBankCinco()
        {
            // Cliente gabriela = new Cliente();

            // gabriela.nomeCliente = "Gabriela";
            // gabriela.profissaoCliente = "Desenvolvedora C#";
            // gabriela.cpfCliente = "434.562.878-20";

            ContaCorrente contaGabriela = new ContaCorrente();

            //contaGabriela.titular = gabriela;
            contaGabriela.titular = new Cliente();
            contaGabriela.titular.nomeCliente = "Gabriela Costa";
            contaGabriela.titular.cpfCliente = "434.562.878-20";
            contaGabriela.titular.profissaoCliente = "Desenvolvedora C#";

            contaGabriela.saldo = 500;
            contaGabriela.agencia = 563;
            contaGabriela.numero = 5634527;            

            
            //Console.WriteLine(gabriela.nomeCliente); 
            Console.WriteLine(contaGabriela.titular.nomeCliente);
            Console.WriteLine(contaGabriela.titular.cpfCliente);
            Console.WriteLine(contaGabriela.titular.profissaoCliente);
            
        }
    }
}