class ExcelBuilder : DocumentBuilder
{
    public ExcelBuilder()
    {
        _document = new Document("Excel");
    }

    public override IDocumentBuilder BuildHeader()
    {
        _document["header"] = "---excel file header----";
        return this;
    }

    public override IDocumentBuilder BuildBody()
    {
        _document["body"] = "---excel file body----";
        return this;
    }

    public override IDocumentBuilder BuildMenu()
    {
        _document["menu"] = "---excel file menu----";
        return this;
    }

    public override IDocumentBuilder BuildFooter()
    {
        _document["footer"] = "---excel file footer----";
        return this;
    }

}