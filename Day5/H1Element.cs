using System;
public class H1Element : TextElement
{
  string fontColor;
  public H1Element()
  {
  SetType("h1");
  }
  public H1Element(string fontColor)
  {
    SetType("h1");
    SetFontSize("30px");
    SetFontColor(fontColor);
    SetValue($"Color=\"{fontColor}\" Size=\"30px\"");
  }
  

  
  public string GetFontSizeH1()
  {
    return GetFontSize();
  }
  public void SetFontColorH1(string fontColor)
  {
    SetFontColor(fontColor);
  }
  public string GetFontColorH1()
  {
    return GetFontColor();
  }

  public override void render()
  {
    Console.WriteLine($"<{GetType()} {GetValue()}> {GetType()} </{GetType()}>");
  }
  public override string ToString()
  {
    return $"<{GetType()} {GetValue()}> {GetType()} </{GetType()}>";
  }




}