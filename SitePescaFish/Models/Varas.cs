namespace SitePescaFish.Models
{
    public class Varas
    {
        public string NomeVara { get; set; } = "";
        public string SubtVara { get; set; } = "";
        public string CaminhoImg { get; set; } = "";

        public Varas selectVaras()
        {
            Varas objVaras = new Varas();
            return objVaras;
        }
    }
}
