using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace TacticsBoard.PlayingSurfaceTypes
{
    class CanoepoloHalf : TacticsBoard.IPlayingSurfaceType
    {

        /// <summary>
        /// Implements a half canoepolo pitch.
        /// 
        /// Playing surface units are in metres and the default pitch 
        /// dimensions are 35 metres by 23 metres. Pitch is drawn to
        /// correct dimensions without any specific compromises.
        /// This only shows half of the field
        /// </summary>
        private const float fieldLength = 35.0F / 2;
        private const float fieldWidth = 23.0F;
        private const float margin = 3.25F;
        private const float linePenWidth = 0.08F;
        private const float playerSizeY = 0.3F;
        private const float playerSizeX = 1.5F;
        private const float playerSize = 0.5F;
        private const float ballSize = 0.3F;
        private const float goalWidth = 2.00F;
        private const float fieldObjectOutlinePenWidth = 0.05F;
        private const float fieldObjectMovementPenWidth = fieldObjectOutlinePenWidth * 3.0F;

        public int amountOfBalls { get; set; }
        public int PlayersPerTeam { get; set; }

        public string Tag { get { return "Canoepolo_Half"; } }

        public string Name
        {
            get { return Properties.Resources.ResourceManager.GetString("FieldType_" + Tag); }
        }

        public float Length
        {
            get { return fieldLength; }
        }

        public float Width
        {
            get { return fieldWidth; }
        }

        public float Margin
        {
            get { return margin; }
        }

        public Color SurfaceColor
        {
            get { return Color.LightSkyBlue; }
        }

        public Collection<FieldObject> StandardObjects
        {
            get
            {
                List<FieldObject> fieldObjects = new List<FieldObject>();

                // Create the players
                for (int i = 1; i <= PlayersPerTeam; i++)
                {
                    fieldObjects.Add(new FieldObjects.NumberedCanoe(i, FieldObjects.NumberedCanoe.TeamId.Attacking, playerSizeX, playerSizeY));
                    fieldObjects.Add(new FieldObjects.NumberedCanoe(i, FieldObjects.NumberedCanoe.TeamId.Defending, playerSizeX, playerSizeY));
                }

                // Add the ball
                float offset = ballSize;
                for (int i = 1; i <= amountOfBalls; i++)
                {
                    fieldObjects.Add(new FieldObjects.Ball(0.0F, (Width / 2) - ((amountOfBalls) * offset) + offset * i * 2, ballSize,i));

                }

                // Add the referees
                fieldObjects.Add(new FieldObjects.Referee("R1", "Referee_" + "_1", Length / 2, Width + (playerSize * 2.05F), playerSize));
                fieldObjects.Add(new FieldObjects.Referee("R2", "Referee_" + "_2", Length / 2, -(playerSize * 2.05F), playerSize));

                // Add the line referees
                fieldObjects.Add(new FieldObjects.LineRef("L1", "LineRef_" + "_1", 0, Width + (playerSize * 2.05F), playerSize));
                fieldObjects.Add(new FieldObjects.LineRef("L2", "LineRef_" + "_2", Length, -(playerSize * 2.05F), playerSize));


                // Adjust various parameters for all the field objects
                foreach (FieldObject fo in fieldObjects)
                {
                    fo.OutlinePenWidth = fieldObjectOutlinePenWidth;
                    fo.MovementPenWidth = fieldObjectMovementPenWidth;
                }

                return new Collection<FieldObject>(fieldObjects);
            }
        }

        public CanoepoloHalf(int numberOfPlayers = 5, int amountOfBalls = 1)
        {
            this.amountOfBalls = amountOfBalls;
            this.PlayersPerTeam = numberOfPlayers;
        }

        public CanoepoloHalf() : this(5,1)
        {
      
        }

        private void AppendPlayerPositions(FieldLayout layout, FieldObjects.NumberedCanoe.TeamId teamId, bool putOnLeftSide)
        {
            const float spacing = playerSizeX * 2F;
            const float benchIndent = -6.0F;
            const float benchDistanceFromField = 2.5F;

            float benchY = 0.0F - benchDistanceFromField;
            float benchStartPos = benchIndent;
            if (!putOnLeftSide)
            {
                benchStartPos += Length;
            }

            for (int playerNumber = 1; playerNumber <= PlayersPerTeam; playerNumber++)
            {
                if (playerNumber <= 5)
                {
                    string playerTag = FieldObjects.NumberedCanoe.ComposeTag(teamId, playerNumber);
                    layout.AddEntry(playerTag, benchStartPos + (spacing * playerNumber), benchY, 0);
                }
                else
                {
                    string playerTag = FieldObjects.NumberedCanoe.ComposeTag(teamId, playerNumber);
                    layout.AddEntry(playerTag, benchStartPos + (spacing * (playerNumber - 5)), benchY + 0.7F, 0);
                }
            }
        }

        public FieldLayout DefaultLayout
        {
            get
            {
                FieldLayout layout = new FieldLayout();
                AppendPlayerPositions(layout, TacticsBoard.FieldObjects.NumberedCanoe.TeamId.Attacking, true);
                AppendPlayerPositions(layout, TacticsBoard.FieldObjects.NumberedCanoe.TeamId.Defending, false);
                return layout;
            }
        }

        public ReadOnlyCollection<string> GetTeam(TacticsBoard.FieldObjects.NumberedCanoe.TeamId team)
        {
            List<string> playersOnTeam = new List<string>();
            for (int i = 1; i <= PlayersPerTeam; i++)
            {
                playersOnTeam.Add(FieldObjects.NumberedCanoe.ComposeTag(team, i));
            }
            return new ReadOnlyCollection<string>(playersOnTeam);
        }

        public void DrawMarkings(Graphics graphics)
        {
            // Create the pens for drawing the field lines with
            using (Pen linePen = new Pen(Color.White, linePenWidth))
            {
                using (Pen additionalMarkPen = new Pen(Color.White, 0.06F))
                {
                    using (Brush lineBrush = new SolidBrush(Color.White))
                    {

                        const float fieldCentreY = fieldWidth / 2;

                        const float sixmeters = 6.0F;
                        const float nowaitzone = 4.0F;


                        // ... The goal and touch lines
                        graphics.DrawRectangle(linePen, 0.0F, 0.0F, Length, Width);


                        #region Draw the goal
                        // ... The goal
                        const float goalDepth = 1.0F;
                        const float goalWidthAtCentreOfPosts = goalWidth + linePenWidth;
                        const float goalTop = (fieldWidth / 2) - (goalWidthAtCentreOfPosts / 2);
                        const float goalBottom = goalTop + goalWidthAtCentreOfPosts;
                        graphics.DrawLines(linePen, new PointF[] {
              new PointF(Length, goalTop),
              new PointF(Length + goalDepth, goalTop),
              new PointF(Length + goalDepth, goalBottom),
              new PointF(Length, goalBottom)
            });
                        #endregion


                        #region Draw the forbiden wait zones
                        graphics.DrawLine(linePen, Length, fieldCentreY - nowaitzone, Length + 0.4F, fieldCentreY - nowaitzone);
                        graphics.DrawLine(linePen, Length, fieldCentreY + nowaitzone, Length + 0.4F, fieldCentreY + nowaitzone);
                        #endregion


                        #region Draw the 6m line
                        graphics.DrawLine(linePen, Length - sixmeters, 0.0F, Length - sixmeters, Width);
                        #endregion
                    }
                }
            }
        }
    }
}


