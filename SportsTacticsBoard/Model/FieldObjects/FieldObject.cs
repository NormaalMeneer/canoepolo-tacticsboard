using System;
using System.Drawing;

namespace TacticsBoard
{
    public interface ICustomLabelProvider
    {
        string GetCustomLabel(string tag);
        void UpdateCustomLabel(string tag, string label);
        void RemoveCustomLabel(string tag);
    }

    abstract class FieldObject
    {
        public abstract string Tag { get; }
        public abstract string Label { get; }

        public ICustomLabelProvider CustomLabelProvider { get; set; }

        public PointF Position
        {
            get { return position; }
            set { position = value; }
        }

        public double rotationangle
        {
            get; set;
        }



        private float displayRadiusX;
        private float DisplayRadiusX
        {
            get { return displayRadiusX; }
        }

        private float displayRadiusY;
        private float DisplayRadiusY
        {
            get { return displayRadiusY; }
        }

        public virtual string Name
        {
            get
            {
                return Properties.Resources.ResourceManager.GetString("FieldObject_" + Tag);
            }
        }

        public bool ContainsPoint(PointF pt)
        {
            RectangleF rect = GetRectangle();
            return rect.Contains(pt);
        }

        public virtual RectangleF GetRectangle()
        {
            return GetRectangleAt(position);
        }

        public RectangleF GetRectangleAt(PointF pos)
        {
            return new RectangleF(pos.X - DisplayRadiusX,
              pos.Y - DisplayRadiusY, DisplayRadiusX * 2, DisplayRadiusY * 2);
        }

        public void Draw(Graphics graphics)
        {
            DrawAt(graphics, Position, this.rotationangle);
        }

        protected string LabelText
        {
            get
            {
                if (null != CustomLabelProvider)
                {
                    string s = CustomLabelProvider.GetCustomLabel(Tag);
                    // Explicitly allow and empty string
                    if (null != s)
                    {
                        return s;
                    }
                }
                // Return the "hard-coded" label
                return Label;
            }
        }

        public virtual void DrawAt(Graphics graphics, PointF pos, double angle)
        {
            if (null == graphics)
            {
                throw new ArgumentNullException("graphics");
            }
            RectangleF rect = GetRectangleAt(pos);
            using (Brush fillBrush = new SolidBrush(FillBrushColor))
            {
                graphics.FillEllipse(fillBrush, rect);
            }
            if (OutlinePenWidth > 0.0)
            {
                using (Pen outlinePen = new Pen(OutlinePenColor, OutlinePenWidth))
                {
                    graphics.DrawEllipse(outlinePen, rect);
                }
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

        public void DrawMovementLine(Graphics graphics, PointF endPoint)
        {
            DrawMovementLineFrom(graphics, Position, endPoint);
        }

        public void DrawMovementLineFrom(Graphics graphics, PointF startPoint, PointF endPoint)
        {
            if (null == graphics)
            {
                throw new ArgumentNullException("graphics");
            }
            using (Pen movementPen = GetMovementPen())
            {
                graphics.DrawLine(movementPen, startPoint, endPoint);
            }
        }

        protected FieldObject(float posX, float posY, float dispRadius)
        {
            position.X = posX;
            position.Y = posY;
            displayRadiusX = dispRadius;
            displayRadiusY = dispRadius;
        }

        protected FieldObject(float posX, float posY, float dispRadiusX, float dispRadiusY)
        {
            position.X = posX;
            position.Y = posY;
            displayRadiusX = dispRadiusX;
            displayRadiusY = dispRadiusY;
        }

        private Color fillBrushColor = Color.White;
        public Color FillBrushColor
        {
            get { return fillBrushColor; }
            set { fillBrushColor = value; }
        }

        private Color outlinePenColor = Color.White;
        public Color OutlinePenColor
        {
            get { return outlinePenColor; }
            set { outlinePenColor = value; }
        }

        private Color labelBrushColor = Color.Black;
        public Color LabelBrushColor
        {
            get { return labelBrushColor; }
            set { labelBrushColor = value; }
        }

        protected Brush LabelBrush
        {
            get { return new SolidBrush(LabelBrushColor); }
        }

        protected virtual int LabelFontSize
        {
            get { return 9; }
        }

        private Color movementPenColor = Color.White;
        public Color MovementPenColor
        {
            get { return movementPenColor; }
            set { movementPenColor = value; }
        }

        private float outlinePenWidth = 1.0F;
        public float OutlinePenWidth
        {
            get { return outlinePenWidth; }
            set { outlinePenWidth = value; }
        }

        private float movementPenWidth = 3.0F;
        public float MovementPenWidth
        {
            get { return movementPenWidth; }
            set { movementPenWidth = value; }
        }

        protected virtual float[] MovementPenDashPattern
        {
            get { return null; }
        }

        public virtual bool ShowsLabel
        {
            get { return true; }
        }

        protected bool HasLabel
        {
            get { return !String.IsNullOrEmpty(LabelText); }
        }

        private Pen GetMovementPen()
        {
            Pen result = null;
            Pen p = null;
            try
            {
                p = new Pen(MovementPenColor, MovementPenWidth);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                float[] dashPattern = MovementPenDashPattern;
                if (null != dashPattern)
                {
                    p.DashPattern = dashPattern;
                }
                result = p;
                p = null;
                return result;
            }
            finally
            {
                if (null != p)
                {
                    p.Dispose();
                }
            }
        }

        private PointF position;

    }
}
