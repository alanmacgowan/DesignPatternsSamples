class WordBuilder : DocumentBuilder
{
    public WordBuilder()
    {
        _document = new Document("Word");
    }
    public override void BuildHeader()
    {
        _document["header"] = "word file header";
    }
    public override void BuildBody()
    {
        _document["body"] = "word file body";
    }
    public override void BuildMenu()
    {
        _document["menu"] = "word file menu";
    }
    public override void BuildFooter()
    {
        _document["footer"] = "word file footer";
    }
}