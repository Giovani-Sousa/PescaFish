namespace SitePescaFish.Models
{
    public class TxtManual
    {
        public string TxtIntro { get; set; }


        public string TxtEquip1 { get; set; } = "";
        public string TxtEquip2 { get; set; } = "";
        public string TxtEquip3 { get; set; } = "";
        public string TxtEquip4 { get; set; } = "";
        public string TxtEquip5 { get; set; } = "";

        
        public string TxtTipos1 { get; set; } = "";
        public string TxtTipos2 { get; set; } = "";
        public string TxtTipos3 { get; set; } = "";

        
        public string TxtTecn1 { get; set; } = "";
        public string TxtTecn2 { get; set; } = "";

        
        public string TxtDicas1 { get; set; } = "";
        public string TxtDicas2 { get; set; } = "";
        public string TxtDicas3 { get; set; } = "";
        public string TxtDicas4 { get; set; } = "";


        public string TxtSeg1 { get; set; } = "";
        public string TxtSeg2 { get; set; } = "";
        public string TxtSeg3 { get; set; } = "";

        
        public string TxtManu1 { get; set; } = "";
        public string TxtManu2 { get; set; } = "";


        public string TxtConc1 { get; set; } = "";

        public TxtManual selectTxtManual()
        {
            TxtManual objTxtManual = new TxtManual();
            return objTxtManual;
        }
    }
}
