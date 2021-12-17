using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

//using CSharpAluraDois.ByteBank;
using CSharpAluraDois.byteBankCinco;

class ContaCorrente
{
    // public string titular = "";
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo = 100;


    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        return true;
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}



