namespace RestApi.Interfaces;

public interface IBird : IAnimal
{
    string Fly();
    string BuildNest();
    string LayEggs();
}