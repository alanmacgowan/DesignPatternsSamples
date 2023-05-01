class HtmlBuilder : DocumentBuilder
{

    public HtmlBuilder()
    {
        _document = new Document("Html");
    }

    public override IDocumentBuilder BuildHeader()
    {
        _document["header"] = "<header>Header</header>";
        return this;
    }

    public override IDocumentBuilder BuildBody()
    {
        _document["body"] = "<body>HTML doc body</body>";
        return this;
    }

    public override IDocumentBuilder BuildMenu()
    {
        _document["menu"] = "<menu>Menu 1, Menu 2</menu>";
        return this;
    }

    public override IDocumentBuilder BuildFooter()
    {
        _document["footer"] = "<footer>HTML doc footer</footer>";
        return this;
    }

}