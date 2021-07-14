
using System.Xml.Serialization;

namespace TacticsBoard
{
  [XmlType(TypeName = "SavedLayout")]
  public class SavedLayout
  {
    private string fieldTypeTag;
    private string name;
    private string category;
    private string description;
    private FieldLayout layout;

    [XmlElement(ElementName = "FieldTypeTag")]
    public string FieldTypeTag
    {
      get { return fieldTypeTag; }
      set { fieldTypeTag = value; }
    }

    [XmlElement(ElementName = "Name")]
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    [XmlElement(ElementName = "Category")]
    public string Category
    {
      get { return category; }
      set { category = value; }
    }

    [XmlElement(ElementName = "Description")]
    public string Description
    {
      get { return description; }
      set { description = value; }
    }

    [XmlElement(ElementName = "Layout")]
    public FieldLayout Layout
    {
      get { return layout; }
      set { layout = value; }
    }

    public SavedLayout()
    {
      name = "";
      category = "";
      description = "";
      layout = new FieldLayout();
      fieldTypeTag = "";
    }

    public SavedLayout(string name, string category, string description, FieldLayout layout, string fieldTypeTag)
    {
      this.name = name;
      this.category = category;
      this.description = description;
      this.layout = layout;
      this.fieldTypeTag = fieldTypeTag;
    }
  }
}
