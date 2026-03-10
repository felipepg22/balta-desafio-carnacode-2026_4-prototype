using PrototypeDesignChallenge.Models.Interfaces;

namespace PrototypeDesignChallenge.Models;

public class DocumentTemplate : IPrototype
{
    public IPrototype Clone()
    {
        return (IPrototype)MemberwiseClone();
    }
}