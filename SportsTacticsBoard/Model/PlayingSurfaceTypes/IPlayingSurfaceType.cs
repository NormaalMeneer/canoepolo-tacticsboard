
using System.Collections.ObjectModel;

using System.Drawing;

namespace TacticsBoard
{
  /// <summary>
  /// Defines the interface that all playing surfaces must implement.
  /// </summary>
   interface IPlayingSurfaceType
  {
    /// <summary>
    /// Defines a tag string that uniquely identifies the playing surface type. 
    /// This must be unique across all playing supported surfaces and is 
    /// used to match up tactical layout sequences and layouts when stored 
    /// on disk with the playing surface classes.
    /// </summary>
    string Tag { get; }

    /// <summary>
    /// Provides a displayable name to show to users to identify this 
    /// playing surface type.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Defines the length of the playing surface in the preferred 
    /// units used by the playing surface. This is often yards, feet, 
    /// or metres.
    /// </summary>
    float Length { get; }

    /// <summary>
    /// Defines the width of the playing surface in the preferred 
    /// units used by the playing surface. This is often yards, feet, 
    /// or metres.
    /// </summary>
    float Width { get; }

    /// <summary>
    /// Defines the margin around the playing surface (between the edge 
    /// of the window and the playing surface edge) in the playing 
    /// surface's units.
    /// </summary>
    float Margin { get; }

    /// <summary>
    /// The color of the majority of the playing surface.
    /// </summary>
    Color SurfaceColor { get; }

    /// <summary>
    /// Retrieves a collection of the objects that can be manipulated
    /// on the playing surface and form part of a layout and tactical 
    /// sequence.
    /// </summary>
    Collection<FieldObject> StandardObjects { get; }

    /// <summary>
    /// Retrieves the initial layout of the objects on the field.
    /// </summary>
    FieldLayout DefaultLayout { get; }


        int amountOfBalls { get; set; }
        int PlayersPerTeam { get; set; }


        /// <summary>
        /// Retrieves a collection of field object tag strings representing
        /// the specified team.
        /// </summary>
        /// <param name="team">The team to retrieve the field objects for.</param>
        /// <returns>A collection of field object tag strings.</returns>
        ReadOnlyCollection<string> GetTeam(FieldObjects.NumberedCanoe.TeamId team);

    /// <summary>
    /// Draws the playing surface markings into the supplied graphics 
    /// object. The playing surface's origin is a (0.0, 0.0) and the 
    /// markings must be drawn using the playing surface's preferred
    /// units of measure using floating point graphics units.
    /// </summary>
    /// <param name="graphics">The graphics object to draw into.</param>
    void DrawMarkings(Graphics graphics);
  }
}
