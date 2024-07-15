using System;
public class TextElement : HTMLElement
{
  string fontSize;
  string fontColor;

  public TextElement()
  {
  SetType("Text");
  }
  public TextElement(string fontSize, string fontColor)
  {
    
    this.fontSize = fontSize;
    this.fontColor = fontColor;
    SetType("Text");
    SetValue($"Color=\"{fontColor}\" Size=\"{fontSize}\"");
  }
  

  public void SetFontSize(string fontSize)
  {
    this.fontSize = fontSize;
  }
  public string GetFontSize()
  {
    return fontSize;
  }
  public void SetFontColor(string fontColor)
  {
    this.fontColor = fontColor;
  }
  public string GetFontColor()
  {
    return fontColor;
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