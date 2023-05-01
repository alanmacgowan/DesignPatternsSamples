class HtmlBuilder : DocumentBuilder
{
    public HtmlBuilder()
    {
        _document = new Document("Html");
    }
    public override void BuildHeader()
    {
        _document["header"] = "<header>Header</header>";
    }
    public override void BuildBody()
    {
        _document["body"] = "<body>HTML doc body</body>";
    }
    public override void BuildMenu()
    {
        _document["menu"] = "<menu>Menu 1, Menu 2</menu>";
    }
    public override void BuildFooter()
    {
        _document["footer"] = "<footer>HTML doc footer</footer>";
    }
}