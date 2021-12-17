using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;


namespace CSharpAluraDois.ByteBankTres
{
    class byteBankTres
    {
        public static void ExecutarByteBankTres()
        {
            ContaCorrente contaDaJasmin = new ContaCorrente();
            //contaDaJasmin.titular = "Jasmin";
            contaDaJasmin.agencia = 863;
            contaDaJasmin.numero = 863452;

            ContaCorrente contaDaJasminYogananda = new ContaCorrente();
            //contaDaJasminYogananda.titular = "Jasmin";
            contaDaJasminYogananda.agencia = 863;
            contaDaJasminYogananda.numero = 863452;

            Console.WriteLine($"Igualdade de tipo de referência {contaDaJasmin == contaDaJasminYogananda}");

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine($"Igualdade de tipo de valor: {idade == idadeMaisUmaVez}");

            contaDaJasmin = contaDaJasminYogananda;
            Console.WriteLine(contaDaJasmin == contaDaJasminYogananda);

            contaDaJasmin.saldo = 300;
            Console.WriteLine(contaDaJasmin.saldo);
            Console.WriteLine(contaDaJasminYogananda);

          
        }
    }
}