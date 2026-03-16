using PrototypeDesignChallenge.Models.Interfaces;

namespace PrototypeDesignChallenge.Models;

public class DocumentStyle : IPrototype<DocumentStyle>
{
    public string FontFamily { get; set; }
    public int FontSize { get; set; }
    public string HeaderColor { get; set; }
    public string LogoUrl { get; set; }
    public Margins PageMargins { get; set; }
    
    public DocumentStyle Clone()
    {
        return new DocumentStyle
        {
            FontFamily = this.FontFamily,
            FontSize = this.FontSize,
            HeaderColor = this.HeaderColor,
            LogoUrl = this.LogoUrl,
            PageMargins = this.PageMargins
        };
    }
}