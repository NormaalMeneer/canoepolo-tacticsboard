
using System;

using System.Windows.Forms;

namespace TacticsBoard
{
  static class Program
  {
    const string CultureOption = "-culture";

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      System.Globalization.CultureInfo culture = null;
      for (int index = 0; (index < args.Length); index++) {
        if (string.Compare(args[index], CultureOption, StringComparison.OrdinalIgnoreCase) == 0) {
          index++;
          if (index >= args.Length) {
            // Missing parameter
            var msg = string.Format(System.Globalization.CultureInfo.CurrentCulture, global::TacticsBoard.Properties.Resources.MissingCultureOptionValue_Format, CultureOption);
            GlobalizationAwareMessageBox.Show(null, msg, global::TacticsBoard.Properties.Resources.InvalidParametersTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
            return;
          }
          try {
            culture = new System.Globalization.CultureInfo(args[index]);
          } catch (ArgumentException) {
            var msg = string.Format(System.Globalization.CultureInfo.CurrentCulture, global::TacticsBoard.Properties.Resources.InvalidCultureOption_Format, CultureOption, args[index]);
            GlobalizationAwareMessageBox.Show(null, msg, global::TacticsBoard.Properties.Resources.InvalidParametersTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
            return;
          }
        }
      }

      if (null != culture) {
        try {
          System.Threading.Thread.CurrentThread.CurrentCulture = culture;
          System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
        } catch (NotSupportedException) {
          var msg = string.Format(System.Globalization.CultureInfo.CurrentCulture, global::TacticsBoard.Properties.Resources.InvalidCultureOption_Format, CultureOption, culture.Name);
          GlobalizationAwareMessageBox.Show(null, msg, global::TacticsBoard.Properties.Resources.InvalidParametersTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
          return;
        }
      }

      System.Diagnostics.Trace.TraceInformation("System.Threading.Thread.CurrentThread.CurrentCulture.Name={0}", System.Threading.Thread.CurrentThread.CurrentCulture.Name);
      System.Diagnostics.Trace.TraceInformation("System.Threading.Thread.CurrentThread.CurrentUICulture.Name={0}", System.Threading.Thread.CurrentThread.CurrentUICulture.Name);
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }
  }
}