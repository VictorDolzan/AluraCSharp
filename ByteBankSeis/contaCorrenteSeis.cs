using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraDois.byteBankSeis
{
    public class ContaCorrenteSeis
    {
        // public string titular = "";
        public ClienteSeis TitularSeis { get; set; }
       
        public int AgenciaSeis { get; set; }

        public int NumeroSeis { get; set; }
       
        private double _saldoSeis = 100;

        public double SaldoSeis
        {
            get
            {
                return _saldoSeis;
            }
            set
            {
                if(value < 0)
                {
                    return;
                } 
                _saldoSeis = value;
            }
        }       
        public bool Sacar(double valor)
        {
            if (this._saldoSeis < valor)
            {
                return false;
            }

            this._saldoSeis -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldoSeis += valor;
        }

        public bool Transferir(double valor, ContaCorrenteSeis contaDestino)
        {
            if (this._saldoSeis < valor)
            {
                return false;
            }

            this._saldoSeis -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
