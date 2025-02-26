namespace RockPaperScissorsMVC.Models
{
    public class JogadorModel
    {
        public string Nome { get; set; }
        OpcaoEscolhidaModel opcaoEscolhida { get; set; }

        public JogadorModel(string nome)
        {
            Nome = nome;
        }

        public OpcaoEscolhidaModel EscolheOpcao()
        {
            Console.WriteLine("Escolha uma opção: ");
            return opcaoEscolhida;
        }

    }
}
