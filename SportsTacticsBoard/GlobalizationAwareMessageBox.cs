using System.Globalization;
using System.Windows.Forms;

namespace TacticsBoard
{
  // Code for this class is from Microsoft documentation on resolving FxCop error:
  //       Help         : http://www.gotdotnet.com/team/fxcop/docs/rules.aspx?version=1.35&url=/Globalization/SpecifyMessageBoxOptions.html  (String)
  //       Category     : Microsoft.Globalization  (String)
  //       CheckId      : CA1300  (String)
  //       RuleFile     : Globalization Rules  (String)
  //       Info         : "In order to run correctly on right-to-left systems, 
  //                      all calls to MessageBox.Show should use the overload 
  //                      that specifies MessageBoxOptions as an argument. Programs 
  //                      should detect whether they are running on a right-to-left 
  //                      system at run-time and pass the appropriate MessageBoxOptions 
  //                      value in order to display correctly."
  //
  // URL resolves to:
  //  http://msdnwiki.microsoft.com/en-us/mtpswiki/9357a724-026e-4a3d-a03a-f14635064ec6.aspx
  //
  public static class GlobalizationAwareMessageBox
  {

    public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
    {

      if (IsRightToLeft(owner)) {
        options |= MessageBoxOptions.RtlReading |
                   MessageBoxOptions.RightAlign;
      }

      return MessageBox.Show(owner, text, caption,
                             buttons, icon, defaultButton, options);
    }

    private static bool IsRightToLeft(IWin32Window owner)
    {

      Control control = owner as Control;
      if (control != null) {
        return control.RightToLeft == RightToLeft.Yes;
      }

      // If no parent control is available, ask the CurrentUICulture
      // if we are running under right-to-left.
      return CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft;
    }
  }
}