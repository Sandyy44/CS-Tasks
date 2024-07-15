using System;
public class HTMLElement
{
  string type;
  string value;

  public HTMLElement()
  {

  }
  public HTMLElement(string type, string value)
  {
    this.type = type;
    this.value = type;
  }

  public void SetType(string type)
  {
    this.type = type;
  }
  public string GetType()
  {
    return type;
  }
  public void SetValue(string value)
  {
    this.value = value;
  }
  public string GetValue()
  {
    return value;
  }

  public virtual void render()
  {
    Console.WriteLine($"HTML Element Type: {type} , HTML Element Value: {value}");
  }
  public override string ToString()
  {
    return $"HTML Element Type: {type} , HTML Element Value: {value}";
  }




}