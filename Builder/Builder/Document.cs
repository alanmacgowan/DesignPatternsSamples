class Document
{
    private string _documentType;
    private Dictionary<string, string> _parts = new Dictionary<string, string>();

    public Document(string documentType)
    {
        this._documentType = documentType;
    }

    public string this[string key]
    {
        get { return _parts[key]; }
        set { _parts[key] = value; }
    }
    public void Show()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Document Type: {0}", _documentType);
        Console.WriteLine(" Header : {0}", _parts["header"]);
        Console.WriteLine(" Body : {0}", _parts["body"]);
        Console.WriteLine(" Menu: {0}", _parts["menu"]);
        Console.WriteLine(" Footer : {0}", _parts["footer"]);
    }
}