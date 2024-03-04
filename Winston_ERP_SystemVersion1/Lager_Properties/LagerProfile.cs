using AutoMapper;

namespace Winston_ERP_SystemVersion1.Lager_Repos
{
    // class til brug for Automapping
    public class LagerProfile:Profile
    {
        public LagerProfile()
        {
            CreateMap<Lager_Data, DisplayLagerData>();
            CreateMap<DisplayLagerData, Lager_Data>();

            // tillæg CreateMap<Lager_Data, DisplayLagerData>().
            //Formember(dest=> dest.varenummer, opt =>opt.MapFrom (src=> src.varenummer));
        }
    }
}
