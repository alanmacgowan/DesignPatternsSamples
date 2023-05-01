DocumentBuilder builder;

DocumentConstructor constructor = new DocumentConstructor();

builder = new WordBuilder();
constructor.Construct(builder);
builder.Document.Show();

builder = new ExcelBuilder();
constructor.Construct(builder);
builder.Document.Show();

builder = new HtmlBuilder();
constructor.Construct(builder);
builder.Document.Show();

Console.ReadKey();