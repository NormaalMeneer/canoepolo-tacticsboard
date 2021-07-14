using System.Collections.Generic;
using System.Xml.Serialization;

namespace TacticsBoard
{
  [XmlType(TypeName = "customLabelCollection")]
  public class CustomLabelCollection : ICollection<CustomLabel>
  {
    private Dictionary<string, CustomLabel> dictionary = new Dictionary<string, CustomLabel>();

    public string Get(string tag)
    {
      if (null == dictionary) {
        return null;
      }
      CustomLabel l;
      if (dictionary.TryGetValue(tag, out l)) {
        return l.Label;
      }
      return null;
    }

    public void AddOrUpdate(string tag, string customLabel)
    {
      CustomLabel l;
      if (dictionary.TryGetValue(tag, out l)) {
        l.Label = customLabel;
      } else {
        l = new CustomLabel() { Tag = tag, Label = customLabel };
        dictionary.Add(tag, l);
      }
    }

    public void Remove(string tag)
    {
      dictionary.Remove(tag);
    }

    #region ICollection<CustomLabel> Members

    public void Add(CustomLabel item)
    {
      if (null != item) {
        AddOrUpdate(item.Tag, item.Label);
      }
    }

    public void Clear()
    {
      dictionary.Clear();
    }

    public bool Contains(CustomLabel item)
    {
      if (null == item) {
        return false;
      }
      CustomLabel l;
      if (dictionary.TryGetValue(item.Tag, out l)) {
        return l.Label == item.Label;
      }
      return false;
    }

    public void CopyTo(CustomLabel[] array, int arrayIndex)
    {
      dictionary.Values.CopyTo(array, arrayIndex);
    }

    public int Count
    {
      get { return dictionary.Count; }
    }

    public bool IsReadOnly
    {
      get { return false; }
    }

    public bool Remove(CustomLabel item)
    {
      if (null == item) {
        return false;
      }
      CustomLabel l;
      if (dictionary.TryGetValue(item.Tag, out l)) {
        if (l.Label == item.Label) {
          dictionary.Remove(item.Tag);
          return true;
        }
      }
      return false;
    }

    #endregion

    #region IEnumerable<CustomLabel> Members

    public IEnumerator<CustomLabel> GetEnumerator()
    {
      return dictionary.Values.GetEnumerator();
    }

    #endregion

    #region IEnumerable Members

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    #endregion
  }
}