using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraDois.byteBankOito
{
    public class ByteBankOito
    {
        public static void ExecutarByteBankOito()
        {
            ContaCorrenteOito contaOito = new ContaCorrenteOito(867, 86712540);

            Console.WriteLine(contaOito.AgenciaOito);
            Console.WriteLine(contaOito.NumeroOito);

            ContaCorrenteOito contaVictor = new ContaCorrenteOito(867, 86712541);
            ContaCorrenteOito contaJasmin = new ContaCorrenteOito(867, 86712542);

            Console.WriteLine(ContaCorrenteOito._TotalDeContasCriadasOito);

            
        }
    }
}