class ExcelBuilder : DocumentBuilder
{
    public ExcelBuilder()
    {
        _document = new Document("Excel");
    }
    public override void BuildHeader()
    {
        _document["header"] = "---excel file header----";
    }
    public override void BuildBody()
    {
        _document["body"] = "---excel file body----";
    }
    public override void BuildMenu()
    {
        _document["menu"] = "---excel file menu----";
    }
    public override void BuildFooter()
    {
        _document["footer"] = "---excel file footer----";
    }
}