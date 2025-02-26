namespace RockPaperScissorsMVC.Models
{
    public class JogoModel
    {
        public JogadorModel Jogador { get; set; }

        public JogoModel()
        {

            JogadorModel jogador1 = new JogadorModel("");
            JogadorModel jogador2 = new JogadorModel("");


        }

        public void IniciarJogo()
        {

            Console.WriteLine("Digite o nome dos jogadores");

            Console.WriteLine("Jogador 1: ");
            var nomeJogador1 = Console.ReadLine();

            Console.WriteLine("Jogador 2: ");
            var nomeJogador2 = Console.ReadLine();

        }

    }
}
