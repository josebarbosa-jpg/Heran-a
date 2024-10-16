namespace Atv._07
{
    public abstract class ContaGenerica
    {
        public string Banco {  get; set; }
        public int Agencia { get; set; } 
        public string Conta {  get; set; }
        public int Saldo { get; set; }

        public abstract void Depositar();
        public abstract void Sacar();
    }

    public class ContaCorrente : ContaGenerica
    {
        public int limite { get; set; }
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 100 reais");
        }

        public override void Sacar()
        {
            Console.WriteLine("Você sacou 100 reais");
        }
    }
}
