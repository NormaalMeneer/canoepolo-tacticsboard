using System.Drawing;

namespace TacticsBoard.FieldObjects
{
  class Referee : Person
  {
    private string label;
    public override string Label
    {
      get { return label; }
    }

    private string tag;
    public override string Tag
    {
      get { return tag; }
    }

    protected override int LabelFontSize
    {
      get {
        if (LabelText.Length > 1) {
          return 6;
        } else {
          return 9;
        }
      }
    }

    public Referee(string _label, string _tag, float posX, float posY, float dispRadius) :
      base(posX, posY, dispRadius)
    {
      label = _label;
      tag = _tag;
      FillBrushColor = Color.Black;
      MovementPenColor = Color.Black;
      LabelBrushColor = Color.White;
    }
  }
}
