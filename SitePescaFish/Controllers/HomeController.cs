using Microsoft.AspNetCore.Mvc;
using SitePescaFish.Models;
using System.Diagnostics;

namespace SitePescaFish.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Peixes()
        {
            List<Peixes> peixes = new List<Peixes>
            {
                new Peixes
                {
                    NomePeixe = "Lambari",
                    TxtPeixe = "Um peixe pequeno de �gua doce, muito comum em rios e lagos da regi�o  paulista. � popular para pesca esportiva e como isca para peixes  maiores.",
                    CaminhoImg = "~/img/lambari.jpg.",
                },
                new Peixes
                {
                    NomePeixe = "Traira",
                    TxtPeixe = "A tra�ra � um peixe de �gua doce agressivo e voraz, com corpo robusto e dentes afiados, comum em rios e lagoas da Am�rica do Sul.",
                    CaminhoImg = "~/img/traira.jpg",
                },
                new Peixes
                {
                    NomePeixe = "Pacu",
                    TxtPeixe = "O pacu � um peixe de �gua doce de corpo alto e comprimido, com dentes que lembram os humanos, encontrado em rios da Bacia do Prata e do Amazonas.",
                    CaminhoImg = "~/img/pacu.png",
                },
                new Peixes
                {
                    NomePeixe = "Pintado",
                    TxtPeixe = "O pintado � um peixe de �gua doce com corpo alongado e pintas escuras, t�pico dos rios do Pantanal e Bacia do Prata, apreciado na pesca esportiva e culin�ria.",
                    CaminhoImg = "~/img/Pintado.png",
                },
            };
            return View(peixes);
        }
        
        public IActionResult Manual()
        {
            TxtManual txtManual = new TxtManual();

            txtManual.TxtIntro = "Pescar � uma atividade relaxante e emocionante que pode ser praticada em diversos ambientes, como rios, lagos, mares e represas. Este manual oferece uma vis�o geral das t�cnicas, equipamentos e dicas essenciais para come�ar a pescar.";

            txtManual.TxtEquip1 = "Varas de Pesca: Escolha a vara adequada para o tipo de pesca que deseja praticar (spinning, casting, fly, etc.)";
            txtManual.TxtEquip2 = "Molinete/Carretilha: Equipamento usado para lan�ar e recolher a linha. Molinetes s�o mais f�ceis para iniciantes, enquantos carretilhas oferecem mais controle para pescadores experientes.";
            txtManual.TxtEquip3 = "Linhas: Selecione a linha com resist�ncia adequada para o tipo de peixe que pretende capturar. Linhas monofilamento s�o vers�teis, enquanto linhas de fluorocarbono s�o quase invis�veis na �gua.";
            txtManual.TxtEquip4 = "Anz�is: Dispon�veis em diversos tamanhos e formatos. Escolha o tamanho certo para o peixe alvo.";
            txtManual.TxtEquip5 = "Iscas: Podem ser naturais (Minhocas, Insetos) ou artificiais (plugs, spinners). A escolha depende do tipo de peixe e do ambiente.";

            txtManual.TxtTipos1 = "Pesca com Isca Artificial: Usar iscas que imitam presas naturais dos peixes. Requer t�cnicas espec�ficas de lan�amento e recolhimento.";
            txtManual.TxtTipos2 = "Pesca com Isca Natural: Utiliza iscas vivas ou mortas. � ideal para iniciantes, pois � mais simples e eficaz.";
            txtManual.TxtTipos3 = "Pesca de fly: T�cnica especializada que utiliza uma linha pesada e uma isca leve (mosca). � ideal para rios e lagos";

            txtManual.TxtTecn1 = "Lan�amento com Molinete: Abra o arco do molinete, segure a linha com o dedo indicador, lance a vara para tr�s e depois para frente, liberando a linha no movimento para frente.";
            txtManual.TxtTecn2 = "Lan�amento com Carretilha: Pressione o bot�o da carretilha, segure o carretel com o polegar, lance a vara para tr�s e depois para frente, liberando o carretel no movimento para frente.";

            txtManual.TxtDicas1 = "Escolha do local: Pesquise locais onde h� maior concentra��o de peixes. Observe a presen�a de vegeta��o subaqu�tica, pedras e outros abrigos naturais.";
            txtManual.TxtDicas2 = "Horario de Pesca: Pesque no �nicio da manh� ou no fim da tarde, quando os peixes est�o mais ativos.";
            txtManual.TxtDicas3 = "Clima e Mar�s: Esteja atento �s condi��es clim�ticas e �s mar�s, pois elas influenciam o comportamento dos peixes.";
            txtManual.TxtDicas4 = "Sil�ncio e Discri��o: Mantenha-se silencioso e evite movimentos bruscos para n�o assustar os peixes.";

            txtManual.TxtSeg1 = "Equipamento de Seguran�a: Use coletes salva-vidas se estiver pescando em barcos. Tenha uma caixa de primeiros socorros a m�o";
            txtManual.TxtSeg2 = "Regulamenta��o Local: Respeite as leis de pesca da regi�o, incluindo limites de tamanho e quantidade de peixes permitidos. Obtenha as licensas necess�rias.";
            txtManual.TxtSeg3 = "Sustentabilidade: Pratique a pesca sustent�vel, capturando apenas o que vai consumir e liberando os peixes menores ou esp�cies em risco.";

            txtManual.TxtManu1 = "Limpeza e Armazenamento: Lave os equipamentos com agu� doce ap�s cada uso, especialmente se pescou em �gua salgada. Armazene varas e molinetes em lugares secos e protegidos.";
            txtManual.TxtManu2 = "Inspe��o Regular: Verifique regularmente linhas, anz�is e iscas para garantir que est�o em boas condi��es. Substitua itens desgastados.";

            txtManual.TxtConc1 = "Pescar � uma atividade que pode proporcionar momentos de tranquilidade e emo��o. Com o equipamento certo, t�cnicas adequadas e respeito � natureza, voc� estar� pronto para aproveitar tudo o que a pesca tem a oferecer. Boa pesca!";
            return View(txtManual);
        }

        public IActionResult Locais()
        {
            return View();
        }

        public IActionResult Iscas()
        {
            List<Iscas> iscas = new List<Iscas>
            {
                new Iscas
                {
                    NomeIsca = "Iscas Artificiais",
                    CaminhoImg = "~/img/Isca1.png",
                },
                new Iscas
                {
                    NomeIsca = "Pequenos Peixes",
                    CaminhoImg = "~/img/Isca2.png",
                },
                new Iscas
                {
                    NomeIsca = "Ra��o para Peixes",
                    CaminhoImg = "~/img/Isca3.png",
                },
                new Iscas
                {
                    NomeIsca = "Minhoca",
                    CaminhoImg = "~/img/Isca4.png",
                },
            };
            return View(iscas); 
        }

        public IActionResult Varas()
        {
            List<Varas> varas = new List<Varas>
            {
                new Varas
                {
                    NomeVara = "Vara de Pesca Telesc�pica",
                    SubtVara = "Para pescas em geral",
                    CaminhoImg = "~/img/vara1.png",
                },
                new Varas
                {
                    NomeVara = "Vara de Pesca de Surfcasting",
                    SubtVara = "Para lan�amentos a partir da praia",
                    CaminhoImg = "~/img/vara2.png",
                },
                new Varas
                {
                    NomeVara = "Vara de Pesca de Fundo",
                    SubtVara = "Para peixes que habitam o fundo",
                    CaminhoImg = "~/img/vara3.png",
                },
                new Varas
                {
                    NomeVara = "Vara de Pesca de Mar",
                    SubtVara = "Para pesca em alto-mar",
                    CaminhoImg = "~/img/vara4.png",
                },
            };
            return View(varas);
        }

        public IActionResult Santos()
        {
            return View();
        }

        public IActionResult Guaruja()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
