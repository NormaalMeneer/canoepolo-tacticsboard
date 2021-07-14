
namespace TacticsBoard
{
  partial class SelectPlayingSurfaceType
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPlayingSurfaceType));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Playerslbl = new System.Windows.Forms.Label();
            this.Ballslbl = new System.Windows.Forms.Label();
            this.Playerstxt = new System.Windows.Forms.TextBox();
            this.Ballstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // fieldTypeComboBox
            // 
            resources.ApplyResources(this.fieldTypeComboBox, "fieldTypeComboBox");
            this.fieldTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldTypeComboBox.FormattingEnabled = true;
            this.fieldTypeComboBox.Name = "fieldTypeComboBox";
            this.fieldTypeComboBox.Sorted = true;
            // 
            // Playerslbl
            // 
            resources.ApplyResources(this.Playerslbl, "Playerslbl");
            this.Playerslbl.Name = "Playerslbl";
            // 
            // Ballslbl
            // 
            resources.ApplyResources(this.Ballslbl, "Ballslbl");
            this.Ballslbl.Name = "Ballslbl";
            // 
            // Playerstxt
            // 
            resources.ApplyResources(this.Playerstxt, "Playerstxt");
            this.Playerstxt.Name = "Playerstxt";
            this.Playerstxt.Leave += new System.EventHandler(this.Playerstxt_Leave);
            // 
            // Ballstxt
            // 
            resources.ApplyResources(this.Ballstxt, "Ballstxt");
            this.Ballstxt.Name = "Ballstxt";
            this.Ballstxt.Leave += new System.EventHandler(this.Ballstxt_Leave);
            // 
            // SelectPlayingSurfaceType
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.Ballstxt);
            this.Controls.Add(this.Playerstxt);
            this.Controls.Add(this.Ballslbl);
            this.Controls.Add(this.Playerslbl);
            this.Controls.Add(this.fieldTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPlayingSurfaceType";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox fieldTypeComboBox;
        private System.Windows.Forms.Label Playerslbl;
        private System.Windows.Forms.Label Ballslbl;
        private System.Windows.Forms.TextBox Playerstxt;
        private System.Windows.Forms.TextBox Ballstxt;
    }
}