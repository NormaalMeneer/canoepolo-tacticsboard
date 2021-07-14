using System.Xml.Serialization;

namespace TacticsBoard
{
  [XmlType(TypeName = "customLabel")]
  public sealed class CustomLabel
  {
    [XmlAttribute("objectTag")]
    public string Tag { get; set; }

    [XmlAttribute("label")]
    public string Label { get; set; }
  }
}
