using System.Drawing;

namespace TacticsBoard.FieldObjects
{
  class Ball : FieldObject
  {
    private string label = string.Empty;
        public int number
        {
            get; set;
        }
    public override string Label
    {
      get { return label; }
    }

    private string tag = "Ball";
    public override string Tag
    {
      get { return tag + "_"+ this.number; }
    }

    public override bool ShowsLabel
    {
      get { return false; }
    }

    public Ball(float posX, float posY, float dispRadius, int number) :
      base(posX, posY, dispRadius)
    {
      OutlinePenColor = Color.Black;
      FillBrushColor = Color.White;
      this.number = number;
    }

    public Ball(string label, string tag, float posX, float posY, float dispRadius)
      : base(posX, posY, dispRadius)
    {
      OutlinePenColor = Color.Black;
      FillBrushColor = Color.White;
      this.label = label;
      this.tag = tag;
    }

    protected override float[] MovementPenDashPattern
    {
      get { 
        return new float[] { 3.0F, 2.0F }; 
      }
    }
  }
}
