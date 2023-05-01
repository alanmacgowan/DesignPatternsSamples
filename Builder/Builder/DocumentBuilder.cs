abstract class DocumentBuilder : IDocumentBuilder
{
    protected Document _document;

    public Document Document
    {
        get { return _document; }
    }

    public abstract IDocumentBuilder BuildHeader();
    public abstract IDocumentBuilder BuildBody();
    public abstract IDocumentBuilder BuildMenu();
    public abstract IDocumentBuilder BuildFooter();
}