namespace RestApi.Interfaces;

public interface ICanine : IAnimal
{
    string Bark();
    string Run();
    string Fetch();
}