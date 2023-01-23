namespace OlympiangodsAPI.Services.OlympiangodService
{
    public interface IOlympiangodService
    {
        List<Olympiangod> GetAllgods();

        Olympiangod? GetbyId(int id);

        List<Olympiangod> Addgod(Olympiangod god);

        List<Olympiangod>? Updategod(int id, Olympiangod request);

        List<Olympiangod>? Deletegod(int id);
    }
}
