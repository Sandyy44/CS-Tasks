class Program
{
  static void Main(string[] args)
  {
    HTMLElement htmlEle = new HTMLElement("Random HTML ELEMENT", " Random Value");
    TextElement txtEle = new TextElement("12px", "RED");
    H1Element h1 = new H1Element("GREEN");
    H2Element h2 = new H2Element("BLUE");
    ImageElement img = new ImageElement("https//jkghghscfjc.com");

    List<HTMLElement> arrayOfObjects = new List<HTMLElement> {
      htmlEle,
      txtEle,
      h1,
      h2,
      img
    };
    foreach(HTMLElement obj in arrayOfObjects){
        obj.render();
        Console.WriteLine();
    }
    

  }
}
