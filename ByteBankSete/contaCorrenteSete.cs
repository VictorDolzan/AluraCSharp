using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraDois.byteBankSete
{
    public class ContaCorrenteSete
    {
        // public string titular = "";
        public ClienteSete TitularSete { get; set; }

        public int AgenciaSete { get; set; }

        public int NumeroSete { get; set; }
      
        private double _saldoSete = 100;

        public double SaldoSete
        {
            get
            {
                return _saldoSete;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldoSete = value;
            }
        }
        public bool Sacar(double valor)
        {
            if (this._saldoSete < valor)
            {
                return false;
            }

            this._saldoSete -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldoSete += valor;
        }

        public bool Transferir(double valor, ContaCorrenteSete contaDestino)
        {
            if (this._saldoSete < valor)
            {
                return false;
            }

            this._saldoSete -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
