using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraDois.byteBankSete
{
    public class ByteBankSete
    {
        public static void ExecutarByteBankSeis()
        {
            ContaCorrenteSete contaSete = new ContaCorrenteSete();
            ClienteSete clienteV = new ClienteSete();

            clienteV.NomeClienteSete = "Victor Dolzan";
            clienteV.CPFClienteSete = "456.654.789-98";
            clienteV.ProfissaoClienteSete = "Desenvolvedor C#";

            contaSete.SaldoSete += 500;
            contaSete.TitularSete = clienteV;

            Console.WriteLine(contaSete.TitularSete.NomeClienteSete);
            Console.WriteLine(contaSete.TitularSete.CPFClienteSete);
            Console.WriteLine(contaSete.TitularSete.ProfissaoClienteSete);
            Console.WriteLine(contaSete.SaldoSete);
            
        }
    }
}