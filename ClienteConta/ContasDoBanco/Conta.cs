namespace ClienteConta.ContasDoBanco
{
    public class Conta
    {       
        public decimal SaldoDaConta { get; set; }
        public int NumeroDaConta { get; set; }
        public decimal RetirarSaldoDaConta { get; set; }

        public void DepositarEmConta(decimal novosaldo)
        {
            SaldoDaConta += novosaldo;
        }

    }
}
