using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

public class MODUL7
{
    public glossary glossary { get; set; }

    public MODUL7() { }
    public MODUL7(glossary GL)
    {
        this.glossary = GL;
    }

}

public class glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
    public glossary() { }
    public glossary(string title, GlossDiv GD)
    {
        this.title = title;
        this.GlossDiv = GD;
    }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }

    public GlossDiv() { }
    public GlossDiv(string title, GlossList GL)
    {
        this.title = title;
        this.GlossList = GL;
    }
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
    

    public GlossList() { }
    public GlossList(GlossEntry GE)
    {
        this.GlossEntry = GE;
    }


}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }

    public GlossEntry(string id, string SA, string GT, string AC, string AB, GlossDef GD, string GS)
    {
        this.ID = id;
        this.SortAs = SA;
        this.GlossTerm = GT;
        this.Acronym = AC;
        this.Abbrev = AB;
        this.GlossDef = GD;
        this.GlossSee = GS;
    }
    public GlossEntry() { }
}

public class GlossDef
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }

    public GlossDef() { }
    public GlossDef(string para, List<string> GlossSeeAlso)
    {
        this.para = para;
        this.GlossSeeAlso = GlossSeeAlso;
    }
}