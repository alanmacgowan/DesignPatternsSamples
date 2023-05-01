
DocumentBuilder builder;

//using a director
DocumentDirector director = new DocumentDirector();

builder = new WordBuilder();
director.Construct(builder);
builder.Document.Show();

builder = new ExcelBuilder();
director.Construct(builder);
builder.Document.Show();

builder = new HtmlBuilder();
director.Construct(builder);
builder.Document.Show();

//using builder directly, fluent interface

builder = new HtmlBuilder();
builder.BuildHeader()
       .BuildBody()
       .BuildFooter();
builder.Document.Show();

Console.ReadKey();