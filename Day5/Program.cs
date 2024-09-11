//Task: Create an HTMLElement class with type and value attributes,
//along with constructors, getters, setters, a render method to print element info, and a ToString method to return the element info.
//Then, create ImageElement and TextElement classes that inherit from HTMLElement.
//The ImageElement class should have an additional src attribute, constructors, getters, setters, render, and ToString methods.
//The TextElement class should have additional fontColor and fontSize attributes, constructors, getters, setters, render, and ToString methods.
//Create H1Element and H2Element classes that inherit from TextElement. Implement constructors, getters, setters, render, and ToString methods for these classes.
//Finally, create objects of these different HTML elements, add them all to a List, and print the contents of that list.

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
