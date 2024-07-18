public class ImageElement : HTMLElement
{
  
  string src;
  public ImageElement()
  {
  SetType("img");
  }
  public ImageElement(string src)
  {
    SetType("img");
    this.src=src;
    SetValue($"src=\"{src}\"");
  }
  

  public void SetImgSrc(string src)
  {
    SetValue($"src=\"{src}\"");
  }
  public string GetImgSrc()
  {
    return GetValue();
  }  
  public override void render()
  {
    Console.WriteLine($"<{GetType()} {GetValue()}>");
  }
  public override string ToString()
  {
    return $"<{GetType()} {GetValue()}>";
  }




}