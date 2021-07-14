
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace TacticsBoard
{
  [XmlType(TypeName = "Layout")]
  public class FieldLayout
  {
    [XmlElement(ElementName = "Entry")]
    public Collection<LayoutEntry> Entries
    {
      get
      {
        return entries;
      }
    }
    private Collection<LayoutEntry> entries;

    public FieldLayout()
    {
      entries = new Collection<LayoutEntry>();
    }

    public void AddEntry(string tag, PointF pos, bool hidden, double rotationangle)
    {
      entries.Add(new LayoutEntry(tag, pos, hidden, rotationangle));
    }

    public void AddEntry(string tag, float posX, float posY, bool hidden, double rotationangle)
    {
      entries.Add(new LayoutEntry(tag, posX, posY, hidden, rotationangle));
    }

    public void AddEntry(string tag, PointF pos, double rotationangle = 0)
    {
      entries.Add(new LayoutEntry(tag, pos, false, rotationangle));
    }

    public void AddEntry(string tag, float posX, float posY, double rotationangle)
    {
      entries.Add(new LayoutEntry(tag, posX, posY, false, rotationangle));
    }

    private LayoutEntry FindEntry(string tag)
    {
      foreach (LayoutEntry entry in entries) {
        if (entry.Tag == tag) {
          return entry;
        }
      }
      return null;
    }

    public bool HasEntry(string tag)
    {
      return (FindEntry(tag) != null);
    }

   public double getRotationAngle(string tag)
        {
            LayoutEntry e = FindEntry(tag);
            return e.Angle;
        }

    public PointF GetEntryPosition(string tag)
    {
      LayoutEntry e = FindEntry(tag);
      return new PointF(e.PositionX, e.PositionY);
    }

    public void RemoveEntry(string tag)
    {
      // Not particularily efficient, but works
      entries.Remove(FindEntry(tag));
    }

    [XmlIgnore]
    public ICollection<string> Tags
    {
      get {
        List<string> l = new List<string>();
        foreach (LayoutEntry e in entries) {
          l.Add(e.Tag);
        }
        return l;
      }
    }
  }
}
