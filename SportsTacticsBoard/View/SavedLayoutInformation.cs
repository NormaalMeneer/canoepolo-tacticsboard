using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TacticsBoard
{
  public partial class SavedLayoutInformation : Form
  {
    internal class SavedLayoutEntryItem
    {
      public string Tag { get; set; }
      public string Name { get; set; }

      public override string ToString()
      {
        if (string.IsNullOrEmpty(Name)) {
          return Tag;
        }
        return Name;
      }
    }

    public SavedLayoutInformation()
    {
      InitializeComponent();
    }

    internal static SavedLayout AskUserForSavedLayoutDetails(ICollection<FieldObject> fieldObjects, string fieldTypeTag, string[] existingLayoutCategories)
    {
      using (SavedLayoutInformation dialog = new SavedLayoutInformation()) {
        foreach (var fo in fieldObjects) {
          SavedLayoutEntryItem e = new SavedLayoutEntryItem()
          {
            Tag = fo.Tag,
            Name = fo.Name
          };
          dialog.entriesListBox.Items.Add(e, true);
        }
        dialog.categoryComboBox.DataSource = existingLayoutCategories;
        dialog.categoryComboBox.SelectedIndex = -1; // make sure nothing is specified at first

        if (dialog.ShowDialog() == DialogResult.OK) {
          FieldLayout layout = FieldControl.ConvertFieldObjectsToLayout(fieldObjects);
          for (int index = 0; index < dialog.entriesListBox.Items.Count; index++) {
            if (!dialog.entriesListBox.GetItemChecked(index)) {
              layout.RemoveEntry(((SavedLayoutEntryItem)(dialog.entriesListBox.Items[index])).Tag);
            }
          }
          return new SavedLayout(dialog.nameTextBox.Text, dialog.categoryComboBox.Text, dialog.descriptionTextBox.Text, layout, fieldTypeTag);
        }
        return null;
      }
    }

    private void nameTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (nameTextBox.Text.Trim().Length == 0)
      {
        errorProvider.SetError(nameTextBox, Properties.Resources.SavedLayoutInformation_ErrorMessage_NameMustNotBeBlank);
        e.Cancel = true;
        return;
      }
    }

    private void nameTextBox_Validated(object sender, EventArgs e)
    {
      errorProvider.SetError(nameTextBox, string.Empty);
    }

    private void entriesListBox_Validating(object sender, CancelEventArgs e)
    {
      if (entriesListBox.CheckedItems.Count == 0)
      {
        errorProvider.SetError(entriesListBox, Properties.Resources.SavedLayoutInformation_ErrorMessage_AtLeastOneItemMustBeChecked);
        e.Cancel = true;
        return;
      }
    }

    private void entriesListBox_Validated(object sender, EventArgs e)
    {
      errorProvider.SetError(entriesListBox, string.Empty);
    }
  }
}