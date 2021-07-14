using TacticsBoard.FieldObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TacticsBoard.FieldObjects
{
    class LineRef : Referee
    {

    public LineRef(string _label, string _tag, float posX, float posY, float dispRadius) :
     base(_label, _tag, posX, posY, dispRadius)
        {
            FillBrushColor = Color.Black;
            MovementPenColor = Color.Black;
            LabelBrushColor = Color.White;
        }
    }
}
