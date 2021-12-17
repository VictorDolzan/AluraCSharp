using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraDois.byteBankSeis
{
    public class ClienteSeis
    {
        private string _cpfSeis;
        public string NomeCliente { get; set; }
        public string CPFCliente 
        {
             get
             {
                return _cpfSeis;
             } 
             set
             {
                _cpfSeis = value;
             } 
        }
        public string ProfissaoCliente { get; set; }
    }
}