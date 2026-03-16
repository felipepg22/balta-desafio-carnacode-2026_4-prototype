using PrototypeDesignChallenge.Models.Interfaces;

namespace PrototypeDesignChallenge.Models;

public class Margins : IPrototype<Margins>
{
    public int Top { get; set; }
    public int Bottom { get; set; }
    public int Left { get; set; }
    public int Right { get; set; }
    
    public Margins Clone()
    {
        return (Margins)MemberwiseClone();
    }
}