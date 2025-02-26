namespace RockPaperScissorsMVC.Models
{
    public class OpcaoEscolhidaModel
    {
        public List<string> Opcoes { get; set; }

        public OpcaoEscolhidaModel()
        {
            Opcoes = new List<string> { "Pedra", "Papel", "Tesoura" };
        }

    }
}

