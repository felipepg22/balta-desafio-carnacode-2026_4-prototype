namespace PrototypeDesignChallenge.Models.Interfaces;

public interface IPrototype<T>
{
    T Clone();
}