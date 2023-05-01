abstract class DocumentBuilder
{
    protected Document _document;

    public Document Document
    {
        get { return _document; }
    }

    public abstract void BuildHeader();
    public abstract void BuildBody();
    public abstract void BuildMenu();
    public abstract void BuildFooter();
}