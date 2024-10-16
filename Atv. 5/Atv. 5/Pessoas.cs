namespace Atv._5
{
    public class Pessoas
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Envelhecer (int anos)
        {
            Idade += anos;

        }

        public void FontVida(int anos)
        {
            Idade -= anos;
        }
    }
    public class Funcionario : Pessoas
    {

    }
}
