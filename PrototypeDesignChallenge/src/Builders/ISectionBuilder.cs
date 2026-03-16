using PrototypeDesignChallenge.Models;

namespace PrototypeDesignChallenge.Builders;

public interface ISectionBuilder
{
    ISectionBuilder WithName(string name);
    ISectionBuilder WithContent(string content);
    ISectionBuilder IsEditable();
    ISectionBuilder WithPlaceholders(List<string> placeholders);
    Section Build();
}