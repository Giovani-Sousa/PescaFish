namespace SitePescaFish.Models
{
    public class Peixes
    {
        public string NomePeixe { get; set; } = "";
        public string TxtPeixe { get; set; } = "";
        public string CaminhoImg { get; set; } = "";

        public Peixes selectVaras()
        {
            Peixes objPeixes = new Peixes();
            return objPeixes;
        }
    }
}
