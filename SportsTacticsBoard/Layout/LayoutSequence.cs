
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace TacticsBoard
{
  [XmlType(TypeName = "CanoepoloTacticsBoardDocument")]
  public class LayoutSequence
  {
    private string fieldTypeTag;

    [XmlElement(ElementName = "fieldType")]
    public string FieldTypeTag
    {
      get { return fieldTypeTag; }
      set { fieldTypeTag = value; }
    }

        private int playersPerTeam;
    [XmlElement (ElementName = "PlayersPerTeam")]    
    public int PlayersPerTeam
        {
            get { return playersPerTeam; }
            set { playersPerTeam = value; }
        }

        private int amountofballs;
        [XmlElement(ElementName = "amountOfBalls")]
        public int AmountOfBalls
        {
            get { return amountofballs; }
            set { amountofballs = value; }
        }

    [XmlElement(ElementName = "layoutSequence")]
    public Collection<FieldLayout> Sequence
    {
      get
      {
        return sequence;
      }
    }
    private Collection<FieldLayout> sequence;

    [XmlArray(ElementName = "customLabels")]
    public CustomLabelCollection CustomLabels
    {
      get
      {
        return customLabels;
      }
    }
    private CustomLabelCollection customLabels;

    public LayoutSequence()
    {
      sequence = new Collection<FieldLayout>();
      customLabels = new CustomLabelCollection();
    }

    public LayoutSequence(string fieldTypeTag)
    {
      sequence = new Collection<FieldLayout>();
      customLabels = new CustomLabelCollection();
      this.fieldTypeTag = fieldTypeTag;
    }

    public int NumberOfLayouts
    {
      get { return sequence.Count; }
    }

    public FieldLayout GetLayout(int index)
    {
      if ((index >= 0) && (index < sequence.Count)) {
        return sequence[index];
      } else {
        return null;
      }
    }

    public void SetLayout(int index, FieldLayout layout)
    {
      if ((index >= 0) && (index < sequence.Count)) {
        sequence[index] = layout;
      }
    }

    public int AddNewLayout(int index, FieldLayout layout)
    {
      if (index >= sequence.Count) {
        sequence.Add(layout);
        return sequence.Count - 1;
      } else {
        sequence.Insert(index, layout);
        return index;
      }
    }

    public void RemoveFromSequence(int index)
    {
      if ((index >= 0) && (index < sequence.Count)) {
        sequence.RemoveAt(index);
      }
    }

    public string GetCustomLabel(string tag)
    {
      if (null == customLabels) {
        return null;
      }
      return customLabels.Get(tag);
    }

    public void AddOrUpdateCustomLabel(string tag, string customLabel)
    {
      if (null == customLabels) {
        return;
      }
      customLabels.AddOrUpdate(tag, customLabel);
    }

    public void RemoveCustomLabel(string tag)
    {
      if (null == customLabels) {
        return;
      }
      customLabels.Remove(tag);
    }
  }
}
