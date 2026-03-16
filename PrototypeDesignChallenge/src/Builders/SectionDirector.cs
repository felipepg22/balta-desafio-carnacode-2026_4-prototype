using PrototypeDesignChallenge.Models;

namespace PrototypeDesignChallenge.Builders;

public class SectionDirector
{
    public List<Section> BuildSectionsForServiceContract()
    {
        var sectionBuilder = new SectionBuilder();
        
        var sections = new List<Section>();
        
        Section section1 = sectionBuilder.WithName("Cláusula 1 - Objeto")
            .WithContent("O presente contrato de serviço tem por objeto...")
            .IsEditable()
            .Build();

        Section section2 = sectionBuilder.WithName("Cláusula 2 - Prazo")
            .WithContent("O prazo de vigência será de...")
            .IsEditable()
            .Build();

        Section section3 = sectionBuilder.WithName("Cláusula 3 - Valor")
            .WithContent("O valor total do contrato é de...")
            .IsEditable()
            .Build();

        sections.Add(section1);
        sections.Add(section2);
        sections.Add(section3);
        
        return sections;
    }
    
    public List<Section> BuildSectionsForConsultingContract()
    {
        var sectionBuilder = new SectionBuilder();
        
        var sections = new List<Section>();
        
        Section section1 = sectionBuilder.WithName("Cláusula 1 - Objeto")
            .WithContent("O presente contrato de consultoria tem por objeto...")
            .IsEditable()
            .Build();

        Section section2 = sectionBuilder.WithName("Cláusula 2 - Prazo")
            .WithContent("O prazo de vigência será de...")
            .IsEditable()
            .Build();

        sections.Add(section1);
        sections.Add(section2);
        
        return sections;
    }
}