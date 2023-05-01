class WordBuilder : DocumentBuilder
{

    public WordBuilder()
    {
        _document = new Document("Word");
    }

    public override IDocumentBuilder BuildHeader()
    {
        _document["header"] = "word file header";
        return this;
    }

    public override IDocumentBuilder BuildBody()
    {
        _document["body"] = "word file body";
        return this;
    }

    public override IDocumentBuilder BuildMenu()
    {
        _document["menu"] = "word file menu";
        return this;
    }

    public override IDocumentBuilder BuildFooter()
    {
        _document["footer"] = "word file footer";
        return this;
    }

}