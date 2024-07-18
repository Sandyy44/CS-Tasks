public class H2Element : TextElement
{
  string fontColor;
  public H2Element()
  {
  SetType("h2");
  }
  public H2Element(string fontColor)
  {
    SetType("h2");
    SetFontSize("15px");
    SetFontColor(fontColor);
    SetValue($"Color=\"{fontColor}\" Size=\"15px\"");
  }
  

  public string GetFontSizeH2()
  {
    return GetFontSize();
  }
  public void SetFontColorH2(string fontColor)
  {
    SetFontColor(fontColor);
  }
  public string GetFontColorH2()
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