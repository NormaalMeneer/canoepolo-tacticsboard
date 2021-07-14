using System;
using System.Drawing;
using System.Globalization;

namespace TacticsBoard.FieldObjects
{
  abstract class Player : Person
  {
    public enum TeamId {
      Attacking,
      Defending
    }

    private TeamId team;
    public TeamId Team
    {
      get { return team; }
    }

    public override string Tag
    {
      get { return ComposeTag(Team, Label); }
    }

    public override string Name
    {
      get { return ComposeName(Team, Label); }
    }

    public static string ComposeName(TeamId team, string playerLabel)
    {
      string nameFormat = Properties.Resources.ResourceManager.GetString("FieldObject_Player_Name_Format");
      string teamName = Properties.Resources.ResourceManager.GetString("TeamName_" + team.ToString());
      return String.Format(CultureInfo.CurrentUICulture, nameFormat, teamName, playerLabel);
    }

    public static string ComposeTag(TeamId team, string playerLabel)
    {
      return "Player_" + team.ToString() + "_" + playerLabel;
    }

    private static Color GetTeamColor(TeamId team)
    {
      switch (team) {
        case TeamId.Defending:
          return Color.Red;
        case TeamId.Attacking:
        default:
          return Color.Yellow;
      }
    }

    public Player(TeamId _team, float dispRadiusX, float dispRadiusY) :
      base(0.0F, 0.0F, dispRadiusX, dispRadiusY)
    {
      team = _team;
      OutlinePenColor = Color.White;
      MovementPenColor = GetTeamColor(team);
      FillBrushColor = GetTeamColor(team);
    }
  }
}
