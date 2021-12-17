using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

using CSharpAluraDois.ByteBank;
namespace CSharpAluraDois.ByteBank
{
    class byteBank
    {
        public static void ExecutarConta()
        {
            ContaCorrente contaDoVictor = new ContaCorrente();

           // contaDoVictor.titular = "Victor";
            contaDoVictor.agencia = 863;
            contaDoVictor.numero = 863452;
            contaDoVictor.saldo = 1325;

            //Console.WriteLine($"O nome do titular da conta é: {contaDoVictor.titular}");
            //Console.WriteLine($"O número da Agência do titular {contaDoVictor.titular} é: {contaDoVictor.agencia}");
            //Console.WriteLine($"O número da conta do titular {contaDoVictor.titular} é {contaDoVictor.numero}");
            //Console.WriteLine($"O saldo da conta {contaDoVictor.numero} do titular {contaDoVictor.titular} é: R${contaDoVictor.saldo}");


            contaDoVictor.saldo += 200;

            //Console.WriteLine($"O saldo Atuaizado da conta {contaDoVictor.numero} do titular {contaDoVictor.titular} é: R${contaDoVictor.saldo}");


            Console.ReadLine();
        }
    }
}