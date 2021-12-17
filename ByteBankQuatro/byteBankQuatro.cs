using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

using CSharpAluraDois.byteBankCinco;

namespace CSharpAluraDois.ByteBankQuatro
{
    class byteBankQuatro
    {
        public static void ExecutarByteBankQuatro()
        {
            ContaCorrente contaDoVictor = new ContaCorrente();

            contaDoVictor.titular.nomeCliente = "Victor";

            Console.WriteLine($"O saldo da conta do {contaDoVictor.titular} é: {contaDoVictor.saldo}");
            bool resultadoSaque = contaDoVictor.Sacar(500);
            Console.WriteLine($"Após o saque de {resultadoSaque} o valor da conta é:{contaDoVictor.saldo}");
            contaDoVictor.Depositar(500);
            Console.WriteLine($"Após depositar, o valor é: R${contaDoVictor.saldo}");

            ContaCorrente contaDaJasmin = new ContaCorrente();
            contaDaJasmin.titular.nomeCliente = "Jasmin";

            Console.WriteLine($"Saldo do Victor é R${contaDoVictor.saldo}");
            Console.WriteLine($"Saldo da Jasmin é R${contaDaJasmin.saldo}");

            bool resultadoTransferencia = contaDoVictor.Transferir(200, contaDaJasmin);

            Console.WriteLine($"Saldo do Victor é R${contaDoVictor.saldo}");
            Console.WriteLine($"Saldo da Jasmin é R${contaDaJasmin.saldo}");

            Console.WriteLine($"Resultado da trânsferência é: {resultadoTransferencia}");

            contaDaJasmin.Transferir(100, contaDoVictor);

            Console.WriteLine($"Saldo do Victor é R${contaDoVictor.saldo}");
            Console.WriteLine($"Saldo da Jasmin é R${contaDaJasmin.saldo}");
        }
    }
}