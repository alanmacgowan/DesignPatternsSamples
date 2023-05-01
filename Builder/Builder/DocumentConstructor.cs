class DocumentConstructor
{

    public void Construct(DocumentBuilder documentBuilder)
    {
        documentBuilder.BuildHeader();
        documentBuilder.BuildBody();
        documentBuilder.BuildMenu();
        documentBuilder.BuildFooter();
    }
}