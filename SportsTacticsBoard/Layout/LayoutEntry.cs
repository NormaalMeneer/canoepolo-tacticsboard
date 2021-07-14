using System.Drawing;
using System.Xml.Serialization;


namespace TacticsBoard
{
  [XmlType(TypeName = "LayoutEntry")]
  public class LayoutEntry
  {
    public LayoutEntry() {
      Tag = string.Empty;
    }

    public LayoutEntry(string tag, float posX, float posY, bool hidden, double angle) {
      Tag = tag;
      PositionX = posX;
      PositionY = posY;
      Hidden = hidden;
      Angle = angle;
    }

    public LayoutEntry(string tag, PointF pt, bool hidden, double angle) {
      Tag = tag;
      PositionX = pt.X;
      PositionY = pt.Y;
      Hidden = hidden;
      Angle = angle;
    }

    [XmlAttribute(AttributeName = "tag")]
    public string Tag { get; set; }

    [XmlAttribute(AttributeName = "x")]
    public float PositionX { get; set; }

    [XmlAttribute(AttributeName = "y")]
    public float PositionY { get; set; }

        [XmlAttribute(AttributeName = "angle")]
        public double Angle { get; set; }

        [XmlAttribute(AttributeName = "hidden")]
    public bool Hidden { get; set; }
  }
}
