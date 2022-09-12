using System;
using System.Globalization;
using System.Xml;

namespace Atividade5
{
    internal class Conta
    {

        // Atributos 

        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; private set; }


        // Construtores
        public Conta(int numero_Conta, string titular_Conta, double deposito_inicial)
        {
            NumeroConta = numero_Conta;
            TitularConta = titular_Conta;
            Deposito(deposito_inicial);
        }

        public Conta (int numero_conta, string titular_conta) 
        {
            NumeroConta = numero_conta;
            TitularConta = titular_conta;
            SaldoConta = 0; 
        
        }

        // Metodos e Funções
        public void Deposito(double valor_deposito)
        {
            SaldoConta = SaldoConta + valor_deposito;
        }

        public void Saque(double valor_saque)
        {
            int taxa = 5;

            SaldoConta = SaldoConta - valor_saque - taxa; 
        }

    public override string ToString()
    {
        return "Conta: " + NumeroConta + ", " + "titular: " + TitularConta + ", " + "Saldo: $ " + SaldoConta;
    }

       



    }


}

