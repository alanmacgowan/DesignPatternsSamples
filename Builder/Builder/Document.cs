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

        if (_parts.ContainsKey("header") && _parts["header"] != null)
            Console.WriteLine(" Header : {0}", _parts["header"]);

        if (_parts.ContainsKey("body") && _parts["body"] != null)
            Console.WriteLine(" Body : {0}", _parts["body"]);

        if(_parts.ContainsKey("menu") && _parts["menu"] != null)
            Console.WriteLine(" Menu: {0}", _parts["menu"]);

        if (_parts.ContainsKey("footer") && _parts["footer"] != null)
            Console.WriteLine(" Footer : {0}", _parts["footer"]);
    }
}