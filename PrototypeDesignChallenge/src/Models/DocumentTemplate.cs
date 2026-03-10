using PrototypeDesignChallenge.Models.Interfaces;

namespace PrototypeDesignChallenge.Models;

public class DocumentTemplate : IPrototype
{
    public string Title { get; set; }
    public string Category { get; set; }
    public List<Section> Sections { get; set; }
    public DocumentStyle Style { get; set; }
    public List<string> RequiredFields { get; set; }
    public Dictionary<string, string> Metadata { get; set; }
    public ApprovalWorkflow Workflow { get; set; }
    public List<string> Tags { get; set; }

    public DocumentTemplate()
    {
        Sections = new List<Section>();
        RequiredFields = new List<string>();
        Metadata = new Dictionary<string, string>();
        Tags = new List<string>();
    }
    
    public IPrototype Clone()
    {
        return new DocumentTemplate
        {
            Title = this.Title,
            Category = this.Category,
            Sections = this.Sections,
            Style = this.Style,
            RequiredFields = this.RequiredFields,
            Metadata = this.Metadata,
            Workflow = this.Workflow,
            Tags = this.Tags
        };
    }
}