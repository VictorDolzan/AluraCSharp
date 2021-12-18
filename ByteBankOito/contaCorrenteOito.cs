using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace CSharpAluraDois.byteBankOito
{
    public class ContaCorrenteOito
    {
        // public string titular = "";
        public ClienteOito TitularOito { get; set; }

        public int AgenciaOito { get; set; }

        public int NumeroOito { get; set; }
      
        private double _saldoOito = 100;

        public double SaldoOito
        {
            get
            {
                return _saldoOito;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldoOito = value;
            }
        }
        public bool Sacar(double valor)
        {
            if (this._saldoOito < valor)
            {
                return false;
            }

            this._saldoOito -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldoOito += valor;
        }

        public bool Transferir(double valor, ContaCorrenteOito contaDestino)
        {
            if (this._saldoOito < valor)
            {
                return false;
            }

            this._saldoOito -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
