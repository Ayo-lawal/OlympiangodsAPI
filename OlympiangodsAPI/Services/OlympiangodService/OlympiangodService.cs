namespace OlympiangodsAPI.Services.OlympiangodService
{
    public class OlympiangodService : IOlympiangodService
    {

        private static List<Olympiangod> olympiangods = new List<Olympiangod> {
                new Olympiangod
                {
                    Id = 1,
                    Name = "Zeus",
                    PowerDomain = "Sky / Lightning / Thunder",
                    RomanName = "Jupiter",
                    Alias = "Sky Daddy"
                },
                new Olympiangod
                {
                    Id = 2,
                    Name = "Poseidon",
                    PowerDomain = "Sea / Horses / Earthquake",
                    RomanName = "Neptune",
                    Alias = "Greek Sea god"
                },
                new Olympiangod
                {
                    Id = 3,
                    Name = "Hades",
                    PowerDomain = "Underworld / Death / Soul / Wealth",
                    RomanName = "Pluto",
                    Alias = "god of the Underworld"
                },
                new Olympiangod
                {
                    Id = 4,
                    Name = "Hera",
                    PowerDomain = "Underworld / Death / Soul / Wealth",
                    RomanName = "Juno",
                    Alias = "Queen goddes of Olympus"
                },
                new Olympiangod
                {
                    Id = 5,
                    Name = "Hermes",
                    PowerDomain = "Deception / Luck / Dream / Speed",
                    RomanName = "Mercury",
                    Alias = "Messenger of the gods / Dream god"
                }
            };

        public List<Olympiangod> Addgod(Olympiangod god)
        {
            olympiangods.Add(god);
            return olympiangods;
        }

        public List<Olympiangod>? Deletegod(int id)
        {
            var god = olympiangods.Find(x => x.Id == id);
            if (god is null)
                return null;

            olympiangods.Remove(god);
            return olympiangods;
        }

        public List<Olympiangod> GetAllgods()
        {
            return olympiangods;
        }

        public Olympiangod? GetbyId(int id)
        {
            var god = olympiangods.Find(x => x.Id == id);
            if (god is null)
                return null; 
            
            return god;
        }

        public List<Olympiangod>? Updategod(int id, Olympiangod request)
        {
            var god = olympiangods.Find(x => x.Id == id);
            if (god is null)
                return null;

            god.Name = request.Name;
            god.PowerDomain = request.PowerDomain;
            god.RomanName = request.RomanName;
            god.Alias = request.Alias;

            return olympiangods;

            
        }
    }
}
