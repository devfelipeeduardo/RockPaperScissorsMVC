using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsMVC.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RockPaperScissorsMVC.Controllers
{
    public class JogoController : Controller
    {
        public ActionResult Index()
        {
            var jogo = ObterJogoDaSessao();
            return View(jogo);
        }

        [HttpPost]
        public ActionResult Jogar(string escolhaJogador)
        {
            var jogo = ObterJogoDaSessao();
            jogo.EscolherOpcao(escolhaJogador);
            jogo.DeterminarResultado();

            HttpContext.Session.SetString("Jogo", JsonConvert.SerializeObject(jogo));

            return View("/Views/Home/Index.cshtml", jogo);

        }

        private JogoModel ObterJogoDaSessao()
        {
            var jogoJson = HttpContext.Session.GetString("Jogo");
            return jogoJson != null ? JsonConvert.DeserializeObject<JogoModel>(jogoJson) ?? new JogoModel() : new JogoModel();
        }
    }
}
