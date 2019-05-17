using System.Collections.Generic;

namespace ClienteConta.Pessoas
{
    public class ListaDeClientes : ContasDoBanco.Conta
    {
        public void ClientesDoBanco()
        {
            PessoaFisica Fisico = new PessoaFisica()
            {
                Nome = "Adalberto",
                CPF = "123456666-12",
                NumeroDaConta = 12345679,
               // SaldoDaConta = 3.786m
            };

            PessoaFisica Fisico2 = new PessoaFisica()
            {
                Nome = "Adelina",
                CPF = "132435466-01",
                NumeroDaConta = 122356,
               // SaldoDaConta = 123.786m
            };

            PessoaJuridica Juridico = new PessoaJuridica()
            {
                Nome = "La Cena Ltda",
                CNPJ = "092872873/0001-98",
                NumeroDaConta = 129856,
                SaldoDaConta = 923.456m
            };

            //ADICIONANDO CLIENTES PF NA LISTA
            List<PessoaFisica> clientes = new List<PessoaFisica>();
            clientes.Add(Fisico);
            clientes.Add(Fisico2);

            //ADICIONANDO CLIENTES PJ NA LISTA
            List<PessoaJuridica> cliente = new List<PessoaJuridica>();
            cliente.Add(Juridico);

            //CONTA POUPANÇA
            ContasDoBanco.ContaPoupança Poupanca = new ContasDoBanco.ContaPoupança()
            {
                NumeroDaConta = 12345679,
                SaldoDaConta = 31.356m
            };

            //CONTAS CORRENTES
            ContasDoBanco.ContaCorrente Corrente = new ContasDoBanco.ContaCorrente()
            {
                NumeroDaConta = 129856,
                SaldoDaConta = 21.356m
            };

            ContasDoBanco.ContaCorrente Corrente1 = new ContasDoBanco.ContaCorrente()
            {
                NumeroDaConta = 129856,
                SaldoDaConta = 123.356m
            };

            ContasDoBanco.ContaCorrente Corrente2 = new ContasDoBanco.ContaCorrente()
            {
                NumeroDaConta = 12345679,
                SaldoDaConta = 11.356m
            };

            //CONTAS INVESTIMENTOS PJ
            ContasDoBanco.ContaInvestimento investimento = new ContasDoBanco.ContaInvestimento()
            {
                NumeroDaConta = 120156,
                SaldoDaConta = 821.356m
            };

            ContasDoBanco.ContaInvestimento investimento1 = new ContasDoBanco.ContaInvestimento()
            {
                NumeroDaConta = 345234,
                SaldoDaConta = 423.218m
            };

            ContasDoBanco.ContaInvestimento investimento2 = new ContasDoBanco.ContaInvestimento()
            {
                NumeroDaConta = 345253,
                SaldoDaConta = 435.678m
            };

            ContasDoBanco.ContaInvestimento investimento3 = new ContasDoBanco.ContaInvestimento()
            {
                NumeroDaConta = 237367,
                SaldoDaConta = 123.567m
            };

            ContasDoBanco.ContaInvestimento investimento4 = new ContasDoBanco.ContaInvestimento()
            {
                NumeroDaConta = 678967,
                SaldoDaConta = 345.634m
            };

            ContasDoBanco.ContaInvestimento investimento5 = new ContasDoBanco.ContaInvestimento()
            {
                NumeroDaConta = 678567,
                SaldoDaConta = 345.244m
            };

            //CONTAS INVESTIMENTO PF
            ContasDoBanco.ContaInvestimento investimento6 = new ContasDoBanco.ContaInvestimento()
            {
                NumeroDaConta = 122356,
                SaldoDaConta = 55.244m
            };
        }
    }
}