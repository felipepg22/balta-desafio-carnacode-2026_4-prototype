using PrototypeDesignChallenge.Models;

namespace PrototypeDesignChallenge.Builders;

public class SectionBuilder : ISectionBuilder
{
    private Section _section = new Section();
    
    public ISectionBuilder WithName(string name)
    {
        _section.Name = name;
        return this;
    }

    public ISectionBuilder WithContent(string content)
    {
        _section.Content = content;
        return this;
    }

    public ISectionBuilder IsEditable()
    {
        _section.IsEditable = true;
        return this;
    }

    public ISectionBuilder WithPlaceholders(List<string> placeholders)
    {
        _section.Placeholders = placeholders;
        return this;
    }

    public Section Build()
    {
        var built = _section;
        _section = new Section();
        return built;
    }
}