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
                    TxtPeixe = "Um peixe pequeno de água doce, muito comum em rios e lagos da região  paulista. É popular para pesca esportiva e como isca para peixes  maiores.",
                    CaminhoImg = "~/img/lambari.jpg.",
                },
                new Peixes
                {
                    NomePeixe = "Traira",
                    TxtPeixe = "A traíra é um peixe de água doce agressivo e voraz, com corpo robusto e dentes afiados, comum em rios e lagoas da América do Sul.",
                    CaminhoImg = "~/img/traira.jpg",
                },
                new Peixes
                {
                    NomePeixe = "Pacu",
                    TxtPeixe = "O pacu é um peixe de água doce de corpo alto e comprimido, com dentes que lembram os humanos, encontrado em rios da Bacia do Prata e do Amazonas.",
                    CaminhoImg = "~/img/pacu.png",
                },
                new Peixes
                {
                    NomePeixe = "Pintado",
                    TxtPeixe = "O pintado é um peixe de água doce com corpo alongado e pintas escuras, típico dos rios do Pantanal e Bacia do Prata, apreciado na pesca esportiva e culinária.",
                    CaminhoImg = "~/img/Pintado.png",
                },
            };
            return View(peixes);
        }
        
        public IActionResult Manual()
        {
            TxtManual txtManual = new TxtManual();

            txtManual.TxtIntro = "Pescar é uma atividade relaxante e emocionante que pode ser praticada em diversos ambientes, como rios, lagos, mares e represas. Este manual oferece uma visão geral das técnicas, equipamentos e dicas essenciais para começar a pescar.";

            txtManual.TxtEquip1 = "Varas de Pesca: Escolha a vara adequada para o tipo de pesca que deseja praticar (spinning, casting, fly, etc.)";
            txtManual.TxtEquip2 = "Molinete/Carretilha: Equipamento usado para lançar e recolher a linha. Molinetes são mais fáceis para iniciantes, enquantos carretilhas oferecem mais controle para pescadores experientes.";
            txtManual.TxtEquip3 = "Linhas: Selecione a linha com resistência adequada para o tipo de peixe que pretende capturar. Linhas monofilamento são versáteis, enquanto linhas de fluorocarbono são quase invisíveis na água.";
            txtManual.TxtEquip4 = "Anzóis: Disponíveis em diversos tamanhos e formatos. Escolha o tamanho certo para o peixe alvo.";
            txtManual.TxtEquip5 = "Iscas: Podem ser naturais (Minhocas, Insetos) ou artificiais (plugs, spinners). A escolha depende do tipo de peixe e do ambiente.";

            txtManual.TxtTipos1 = "Pesca com Isca Artificial: Usar iscas que imitam presas naturais dos peixes. Requer técnicas específicas de lançamento e recolhimento.";
            txtManual.TxtTipos2 = "Pesca com Isca Natural: Utiliza iscas vivas ou mortas. É ideal para iniciantes, pois é mais simples e eficaz.";
            txtManual.TxtTipos3 = "Pesca de fly: Técnica especializada que utiliza uma linha pesada e uma isca leve (mosca). É ideal para rios e lagos";

            txtManual.TxtTecn1 = "Lançamento com Molinete: Abra o arco do molinete, segure a linha com o dedo indicador, lance a vara para trás e depois para frente, liberando a linha no movimento para frente.";
            txtManual.TxtTecn2 = "Lançamento com Carretilha: Pressione o botão da carretilha, segure o carretel com o polegar, lance a vara para trás e depois para frente, liberando o carretel no movimento para frente.";

            txtManual.TxtDicas1 = "Escolha do local: Pesquise locais onde há maior concentração de peixes. Observe a presença de vegetação subaquática, pedras e outros abrigos naturais.";
            txtManual.TxtDicas2 = "Horario de Pesca: Pesque no ínicio da manhã ou no fim da tarde, quando os peixes estão mais ativos.";
            txtManual.TxtDicas3 = "Clima e Marés: Esteja atento às condições climáticas e às marés, pois elas influenciam o comportamento dos peixes.";
            txtManual.TxtDicas4 = "Silêncio e Discrição: Mantenha-se silencioso e evite movimentos bruscos para não assustar os peixes.";

            txtManual.TxtSeg1 = "Equipamento de Segurança: Use coletes salva-vidas se estiver pescando em barcos. Tenha uma caixa de primeiros socorros a mão";
            txtManual.TxtSeg2 = "Regulamentação Local: Respeite as leis de pesca da região, incluindo limites de tamanho e quantidade de peixes permitidos. Obtenha as licensas necessárias.";
            txtManual.TxtSeg3 = "Sustentabilidade: Pratique a pesca sustentável, capturando apenas o que vai consumir e liberando os peixes menores ou espécies em risco.";

            txtManual.TxtManu1 = "Limpeza e Armazenamento: Lave os equipamentos com aguá doce após cada uso, especialmente se pescou em água salgada. Armazene varas e molinetes em lugares secos e protegidos.";
            txtManual.TxtManu2 = "Inspeção Regular: Verifique regularmente linhas, anzóis e iscas para garantir que estão em boas condições. Substitua itens desgastados.";

            txtManual.TxtConc1 = "Pescar é uma atividade que pode proporcionar momentos de tranquilidade e emoção. Com o equipamento certo, técnicas adequadas e respeito à natureza, você estará pronto para aproveitar tudo o que a pesca tem a oferecer. Boa pesca!";
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
                    NomeIsca = "Ração para Peixes",
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
                    NomeVara = "Vara de Pesca Telescópica",
                    SubtVara = "Para pescas em geral",
                    CaminhoImg = "~/img/vara1.png",
                },
                new Varas
                {
                    NomeVara = "Vara de Pesca de Surfcasting",
                    SubtVara = "Para lançamentos a partir da praia",
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
