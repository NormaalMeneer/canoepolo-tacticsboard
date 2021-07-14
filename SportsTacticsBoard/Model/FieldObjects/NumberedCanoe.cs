using System;
using System.Globalization;
using System.Drawing;

namespace TacticsBoard.FieldObjects
{
    class NumberedCanoe : Player
    {
        private PointF[] polynoompunten = new PointF[8];

        private int number;
        public int Number
        {
            get { return number; }
        }

        public override string Label
        {
            get { return Number.ToString(CultureInfo.CurrentCulture); }
        }

        public static string ComposeTag(TeamId team, int playerNumber)
        {
            return Player.ComposeTag(team, playerNumber.ToString(CultureInfo.InvariantCulture));
        }

        public NumberedCanoe(int _number, TeamId _team, float dispRadiusX, float dispRadiusY)
          : base(_team, dispRadiusX, dispRadiusY)
        {
            number = _number;

        }

        //Override DrawAt to make make it draw a canoe instead of circles
        public override void DrawAt(Graphics graphics, PointF pos, double angle)
        {
            if (null == graphics)
            {
                throw new ArgumentNullException("graphics");
            }
            RectangleF rect = GetRectangleAt(pos);
            //declaring the middle of the canoe as center for a rotation
            PointF m = new PointF(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);

            //Calculating the coordinates of the points which make up the canoe according to the rotation relative to the center of rotation
            polynoompunten[0] = new PointF( m.X + (((float) Math.Cos((angle)*Math.PI/180)) * (rect.Width/2)),               (m.Y) + ((float)Math.Sin((angle) * Math.PI / 180)) * (rect.Width/2) ); //rechtsmidden
            polynoompunten[1] = new PointF(m.X + (((float)Math.Cos((angle + 15) * Math.PI / 180)) * (140*rect.Height/100)), (m.Y) + ((float)Math.Sin((angle + 15) * Math.PI / 180)) * (140*rect.Height/100));
            polynoompunten[2] = new PointF( m.X + (((float)Math.Cos((angle + 90) * Math.PI / 180)) * (rect.Height/2)),      (m.Y) + ((float)Math.Sin((angle + 90) * Math.PI / 180)) * (rect.Height/2)); //middenboven
            polynoompunten[3] = new PointF(m.X + (((float)Math.Cos((angle + 165) * Math.PI / 180)) * (140 * rect.Height / 100)), (m.Y) + ((float)Math.Sin((angle + 165) * Math.PI / 180)) * (140 * rect.Height / 100));
            polynoompunten[4] = new PointF( m.X + (((float)Math.Cos((angle + 180) * Math.PI / 180)) * (rect.Width / 2)),    (m.Y) + ((float)Math.Sin((angle + 180) * Math.PI / 180)) * (rect.Width/2)); //linksmidden
            polynoompunten[5] = new PointF(m.X + (((float)Math.Cos((angle - 165) * Math.PI / 180)) * (140 * rect.Height / 100)), (m.Y) + ((float)Math.Sin((angle -165) * Math.PI / 180)) * (140 * rect.Height / 100));
            polynoompunten[6] = new PointF( m.X + (((float)Math.Cos((angle + 270) * Math.PI / 180)) * (rect.Height / 2)),   (m.Y) + ((float)Math.Sin((angle + 270) * Math.PI / 180)) * (rect.Height/2)); //middenonder
            polynoompunten[7] = new PointF(m.X + (((float)Math.Cos((angle -15) * Math.PI / 180)) * (140 * rect.Height / 100)), (m.Y) + ((float)Math.Sin((angle -15) * Math.PI / 180)) * (140 * rect.Height / 100));
            using (Brush fillBrush = new SolidBrush(FillBrushColor))
            {
                graphics.FillPolygon(fillBrush, polynoompunten);
            }
            if (OutlinePenWidth > 0.0)
            {
                using (Pen outlinePen = new Pen(OutlinePenColor, OutlinePenWidth))
                {
                    graphics.DrawPolygon(outlinePen, polynoompunten);
                }
            }
            //Drawing the triangle to show how the canoe is pointed
            Brush brush = new SolidBrush(Color.Black);
            if (this.Team == TeamId.Attacking)
            {
                //Calculating the coordinates of the triangle according to the rotation relative to the center of rotation for the attacking team
                PointF[] points = { new PointF(m.X + (((float)Math.Cos((angle) * Math.PI / 180)) * (6*(rect.Width/16))) , (m.Y) + ((float)Math.Sin((angle) * Math.PI / 180)) * (6*(rect.Width/16)))
                        , new PointF( m.X + ((float)Math.Cos((angle+15) * Math.PI / 180)) * (rect.Height), m.Y + ((float)Math.Sin((angle+15) * Math.PI / 180)) * (rect.Height))
                        , new PointF(m.X + (((float)Math.Cos((angle) * Math.PI / 180)) * (2*(rect.Width/16))) , (m.Y) + ((float)Math.Sin((angle) * Math.PI / 180)) * (2*(rect.Width/16)))
                        , new PointF( m.X + ((float)Math.Cos((angle-15) * Math.PI / 180)) * (rect.Height), m.Y + ((float)Math.Sin((angle-15) * Math.PI / 180)) * (rect.Height)) };
                graphics.FillPolygon(brush, points);
            }
            else
            {
                //Calculating the coordinates of the triangle according to the rotation relative to the center of rotation for the defending team
                PointF[] points = { new PointF(m.X + (((float)Math.Cos((angle) * Math.PI / 180)) * (-6*(rect.Width/16))) , (m.Y) + ((float)Math.Sin((angle) * Math.PI / 180)) * (-6*(rect.Width/16)))
                        , new PointF( m.X + ((float)Math.Cos((angle+15) * Math.PI / 180)) * (-rect.Height), m.Y + ((float)Math.Sin((angle+15) * Math.PI / 180)) * (-rect.Height))
                        , new PointF(m.X + (((float)Math.Cos((angle) * Math.PI / 180)) * (-2*(rect.Width/16))) , (m.Y) + ((float)Math.Sin((angle) * Math.PI / 180)) * (-2*(rect.Width/16)))
                        , new PointF( m.X + ((float)Math.Cos((angle-15) * Math.PI / 180)) * (-rect.Height), m.Y + ((float)Math.Sin((angle-15) * Math.PI / 180)) * (-rect.Height)) };
                graphics.FillPolygon(brush, points);
            }
            if (HasLabel)
            {
                float fontSize = LabelFontSize * (float)rect.Height / 18.0F;
                using (Font labelFont = new Font("Arial", fontSize, FontStyle.Bold))
                {
                    using (StringFormat strFormat = new StringFormat())
                    {
                        strFormat.Alignment = StringAlignment.Center;
                        strFormat.LineAlignment = StringAlignment.Center;
                        graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        try
                        {
                            graphics.DrawString(LabelText, labelFont, LabelBrush, rect, strFormat);
                        }
                        catch (System.Runtime.InteropServices.ExternalException)
                        {
                            // Sometimes we get a "generic error" from the GDI+ subsystem
                            // when resizing the window really small and then slowly larger 
                            // again. All the parameters seem correct, so we'll just catch and
                            // ignore this exception here.
                        }
                    }
                }
            }
        }
    }
}
