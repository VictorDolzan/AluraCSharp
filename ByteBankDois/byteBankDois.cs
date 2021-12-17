using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

using CSharpAluraDois.ByteBankDois;
namespace CSharpAluraDois.ByteBankDois
{
    class byteBankDois
    {
        public static void ExecutarByteBankDois()
        {
            ContaCorrente conta = new ContaCorrente();


           // conta.titular = "Jasmin";
            conta.saldo = 200;
            //Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
        }
    }
}