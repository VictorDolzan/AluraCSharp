using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraDois.byteBankSeis
{
    public class ByteBankSeis
    {
        public static void ExecutarByteBankSeis()
        {
            ContaCorrenteSeis contaByteSeis = new ContaCorrenteSeis();
            ClienteSeis cliente = new ClienteSeis();

            cliente.NomeCliente = "Victor";
            cliente.CPFCliente = "149.600.547-35";
            cliente.ProfissaoCliente = "Desenvolvedor";

            contaByteSeis.SaldoSeis = 400;

            contaByteSeis.TitularSeis = cliente;

            Console.WriteLine(contaByteSeis.TitularSeis.NomeCliente);
            Console.WriteLine(contaByteSeis.TitularSeis.CPFCliente);
            Console.WriteLine(contaByteSeis.SaldoSeis);
        }
    }
}