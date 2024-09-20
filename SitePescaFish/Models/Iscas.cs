namespace SitePescaFish.Models
{
    public class Iscas
    {
        public string NomeIsca { get; set; } = "";
        public string CaminhoImg { get; set; } = "";

        public Iscas selectIscas()
        {
            Iscas objIscas = new Iscas();
            return objIscas;
        }
    }
}
