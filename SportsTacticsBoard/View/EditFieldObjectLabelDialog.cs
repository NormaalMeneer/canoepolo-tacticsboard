using System.Windows.Forms;

namespace TacticsBoard
{
  internal partial class EditFieldObjectLabelDialog : Form
  {
    public string FieldObjectName
    {
      get
      {
        return fieldObjectNameTextBox.Text;
      }
      set
      {
        fieldObjectNameTextBox.Text = value;
      }
    }

    public string CustomLabel
    {
      get
      {
        return customLabelTextBox.Text;
      }
      set
      {
        customLabelTextBox.Text = value;
      }
    }

    public EditFieldObjectLabelDialog()
    {
      InitializeComponent();
    }

    private void okButton_Click(object sender, System.EventArgs e)
    {
      if (customLabelTextBox.Text.Length > 2) {
        DialogResult dr = 
          GlobalizationAwareMessageBox.Show(
            this, 
            Properties.Resources.ResourceManager.GetString("CustomLabelLongerThanRecommended"), 
            this.Text, 
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Asterisk, 
            MessageBoxDefaultButton.Button2, 
            (MessageBoxOptions)0);
        if (dr != System.Windows.Forms.DialogResult.Yes) {
          this.DialogResult = System.Windows.Forms.DialogResult.None;
        }
      }
    }
  }
}
