using System.Net.WebSockets;

namespace RockPaperScissorsMVC.Models
{
    public class JogoModel
    {

        private List<string> Opcoes { get; set; }
        public string OpcaoJogador { get; private set; }
        public string OpcaoComputador { get; private set; }
        public string Resultado { get; private set; }
        public int PontuacaoJogador { get; set; }
        public int PontuacaoComputador { get; set; }

        public JogoModel()
        {
            Opcoes = new List<string> { "Pedra", "Papel", "Tesoura" };
        }


        public void EscolherOpcao(string opcaoJogador)
        {
            OpcaoJogador = opcaoJogador;
            var random = new Random();
            OpcaoComputador = Opcoes[random.Next(Opcoes.Count)];
        }

        public void DeterminarResultado()
        {
            if (OpcaoJogador == OpcaoComputador)
            {
                Resultado = "Empate";
            }
            else if ((OpcaoJogador == "Pedra" && OpcaoComputador == "Tesoura") ||
                     (OpcaoJogador == "Tesoura" && OpcaoComputador == "Papel") ||
                     (OpcaoJogador == "Papel" && OpcaoComputador == "Pedra"))
            {
                Resultado = "Você Venceu!";
                PontuacaoJogador += 1;
            } else
            {
                Resultado = "Você Perdeu!";
                PontuacaoComputador += 1;
            }
        }
    }
}
