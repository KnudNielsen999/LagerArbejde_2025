using System.ComponentModel.DataAnnotations;

namespace Winston_ERP_SystemVersion1.Lager_Repos
{
    public class Lager_Data
    {
        public int Id { get; set; }
        public string? vareNummer { get; set; }
        public string? vareTekst { get; set; }
        public DateTime? oprDato { get; set; }
        public double? vareMaengde { get; set; }
        public string? enheder { get; set; }
        public double? kostPris { get; set; }
        public double? maxLager { get; set; }
        public double? minLager { get; set; }
        public double? salgsPris { get; set; }
        public DateTime? sidsteLagerBevDato { get; set; }
        public DateTime? sidsteBesstillingsDato { get; set; }
        public double? bestiltAntal { get; set; }
        public DateTime? lagerOptaltDato { get; set; }
    }
}
