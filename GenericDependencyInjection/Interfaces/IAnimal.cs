namespace RestApi.Interfaces;

public interface IAnimal
{
    string Name { get; set; }
    int Age { get; set; }
    string Gender { get; set; }
    string Eat();
    string Sleep();
}