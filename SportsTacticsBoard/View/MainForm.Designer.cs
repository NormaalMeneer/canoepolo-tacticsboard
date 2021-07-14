
using System;

namespace TacticsBoard
{
  partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sequenceToolString = new System.Windows.Forms.ToolStrip();
            this.goToFirstToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.previousLayoutInSequence = new System.Windows.Forms.ToolStripButton();
            this.currentLayoutNumber = new System.Windows.Forms.ToolStripTextBox();
            this.nextLayoutInSequence = new System.Windows.Forms.ToolStripButton();
            this.goToLastToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.repeatToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recordNewPositionButton = new System.Windows.Forms.ToolStripButton();
            this.recordOverCurrentPositionButton = new System.Windows.Forms.ToolStripButton();
            this.removeCurrentPositionFromSequenceButton = new System.Windows.Forms.ToolStripButton();
            this.revertCurrentLayoutToSavedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showMovementButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.sequenceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSequenceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSequenceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exportSequenceToImageFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToAviFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSequenceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSequenceAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTofileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingSurfaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orientationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.changePlayingSurfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.playSequenceTimer = new System.Windows.Forms.Timer(this.components);
            this.fieldControl = new TacticsBoard.FieldControl();
            this.sequenceToolString.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequenceToolString
            // 
            this.sequenceToolString.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToFirstToolStripButton,
            this.previousLayoutInSequence,
            this.currentLayoutNumber,
            this.nextLayoutInSequence,
            this.goToLastToolStripButton,
            this.toolStripSeparator11,
            this.playToolStripButton,
            this.repeatToolStripButton,
            this.toolStripSeparator2,
            this.recordNewPositionButton,
            this.recordOverCurrentPositionButton,
            this.removeCurrentPositionFromSequenceButton,
            this.revertCurrentLayoutToSavedButton,
            this.toolStripSeparator1,
            this.showMovementButton,
            this.toolStripSeparator10});
            resources.ApplyResources(this.sequenceToolString, "sequenceToolString");
            this.sequenceToolString.Name = "sequenceToolString";
            // 
            // goToFirstToolStripButton
            // 
            this.goToFirstToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToFirstToolStripButton.Image = global::TacticsBoard.Properties.Resources.DataContainer_MoveFirstHS;
            this.goToFirstToolStripButton.Name = "goToFirstToolStripButton";
            resources.ApplyResources(this.goToFirstToolStripButton, "goToFirstToolStripButton");
            this.goToFirstToolStripButton.Click += new System.EventHandler(this.goToFirstToolStripButton_Click);
            // 
            // previousLayoutInSequence
            // 
            this.previousLayoutInSequence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousLayoutInSequence.Image = global::TacticsBoard.Properties.Resources.DataContainer_MovePreviousHS;
            resources.ApplyResources(this.previousLayoutInSequence, "previousLayoutInSequence");
            this.previousLayoutInSequence.Name = "previousLayoutInSequence";
            this.previousLayoutInSequence.Click += new System.EventHandler(this.PreviousLayoutInSequence_Click);
            // 
            // currentLayoutNumber
            // 
            this.currentLayoutNumber.Name = "currentLayoutNumber";
            this.currentLayoutNumber.ReadOnly = true;
            resources.ApplyResources(this.currentLayoutNumber, "currentLayoutNumber");
            // 
            // nextLayoutInSequence
            // 
            this.nextLayoutInSequence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextLayoutInSequence.Image = global::TacticsBoard.Properties.Resources.DataContainer_MoveNextHS;
            resources.ApplyResources(this.nextLayoutInSequence, "nextLayoutInSequence");
            this.nextLayoutInSequence.Name = "nextLayoutInSequence";
            this.nextLayoutInSequence.Click += new System.EventHandler(this.NextLayoutInSequence_Click);
            // 
            // goToLastToolStripButton
            // 
            this.goToLastToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToLastToolStripButton.Image = global::TacticsBoard.Properties.Resources.DataContainer_MoveLastHS;
            resources.ApplyResources(this.goToLastToolStripButton, "goToLastToolStripButton");
            this.goToLastToolStripButton.Name = "goToLastToolStripButton";
            this.goToLastToolStripButton.Click += new System.EventHandler(this.GoToLastToolStripButton_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // playToolStripButton
            // 
            this.playToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playToolStripButton.Image = global::TacticsBoard.Properties.Resources.PlayHS;
            this.playToolStripButton.Name = "playToolStripButton";
            resources.ApplyResources(this.playToolStripButton, "playToolStripButton");
            this.playToolStripButton.Click += new System.EventHandler(this.PlayToolStripButton_Click);
            // 
            // repeatToolStripButton
            // 
            this.repeatToolStripButton.CheckOnClick = true;
            this.repeatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.repeatToolStripButton.Image = global::TacticsBoard.Properties.Resources.RepeatHS;
            resources.ApplyResources(this.repeatToolStripButton, "repeatToolStripButton");
            this.repeatToolStripButton.Name = "repeatToolStripButton";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // recordNewPositionButton
            // 
            this.recordNewPositionButton.Image = global::TacticsBoard.Properties.Resources.RecordHS;
            resources.ApplyResources(this.recordNewPositionButton, "recordNewPositionButton");
            this.recordNewPositionButton.Name = "recordNewPositionButton";
            this.recordNewPositionButton.Click += new System.EventHandler(this.RecordNewPositionButton_Click);
            // 
            // recordOverCurrentPositionButton
            // 
            this.recordOverCurrentPositionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.recordOverCurrentPositionButton, "recordOverCurrentPositionButton");
            this.recordOverCurrentPositionButton.Name = "recordOverCurrentPositionButton";
            this.recordOverCurrentPositionButton.Click += new System.EventHandler(this.RecordOverCurrentPositionButton_Click);
            // 
            // removeCurrentPositionFromSequenceButton
            // 
            this.removeCurrentPositionFromSequenceButton.Image = global::TacticsBoard.Properties.Resources.DeleteHS;
            resources.ApplyResources(this.removeCurrentPositionFromSequenceButton, "removeCurrentPositionFromSequenceButton");
            this.removeCurrentPositionFromSequenceButton.Name = "removeCurrentPositionFromSequenceButton";
            this.removeCurrentPositionFromSequenceButton.Click += new System.EventHandler(this.RemoveCurrentPositionFromSequenceButton_Click);
            // 
            // revertCurrentLayoutToSavedButton
            // 
            this.revertCurrentLayoutToSavedButton.Image = global::TacticsBoard.Properties.Resources.Edit_UndoHS;
            resources.ApplyResources(this.revertCurrentLayoutToSavedButton, "revertCurrentLayoutToSavedButton");
            this.revertCurrentLayoutToSavedButton.Name = "revertCurrentLayoutToSavedButton";
            this.revertCurrentLayoutToSavedButton.Click += new System.EventHandler(this.RevertCurrentLayoutToSavedButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // showMovementButton
            // 
            this.showMovementButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.showMovementButton, "showMovementButton");
            this.showMovementButton.Name = "showMovementButton";
            this.showMovementButton.Click += new System.EventHandler(this.showMovementButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sequenceMenuItem,
            this.layoutsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.playingSurfaceMenuItem});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // sequenceMenuItem
            // 
            this.sequenceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSequenceMenuItem,
            this.openSequenceMenuItem,
            this.toolStripSeparator8,
            this.exportSequenceToImageFilesMenuItem,
            this.exportToAviFileMenuItem,
            this.toolStripSeparator7,
            this.saveSequenceMenuItem,
            this.saveSequenceAsMenuItem,
            this.toolStripSeparator5,
            this.exitMenuItem});
            this.sequenceMenuItem.Name = "sequenceMenuItem";
            resources.ApplyResources(this.sequenceMenuItem, "sequenceMenuItem");
            // 
            // newSequenceMenuItem
            // 
            this.newSequenceMenuItem.Image = global::TacticsBoard.Properties.Resources.NewDocumentHS;
            this.newSequenceMenuItem.Name = "newSequenceMenuItem";
            resources.ApplyResources(this.newSequenceMenuItem, "newSequenceMenuItem");
            this.newSequenceMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openSequenceMenuItem
            // 
            this.openSequenceMenuItem.Image = global::TacticsBoard.Properties.Resources.openHS;
            this.openSequenceMenuItem.Name = "openSequenceMenuItem";
            resources.ApplyResources(this.openSequenceMenuItem, "openSequenceMenuItem");
            this.openSequenceMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // exportSequenceToImageFilesMenuItem
            // 
            this.exportSequenceToImageFilesMenuItem.Name = "exportSequenceToImageFilesMenuItem";
            resources.ApplyResources(this.exportSequenceToImageFilesMenuItem, "exportSequenceToImageFilesMenuItem");
            this.exportSequenceToImageFilesMenuItem.Click += new System.EventHandler(this.saveSequenceToImageFilesToolStripMenuItem_Click);
            // 
            // exportToAviFileMenuItem
            // 
            this.exportToAviFileMenuItem.Name = "exportToAviFileMenuItem";
            resources.ApplyResources(this.exportToAviFileMenuItem, "exportToAviFileMenuItem");
            this.exportToAviFileMenuItem.Click += new System.EventHandler(this.exportToAviFileMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // saveSequenceMenuItem
            // 
            this.saveSequenceMenuItem.Image = global::TacticsBoard.Properties.Resources.saveHS;
            this.saveSequenceMenuItem.Name = "saveSequenceMenuItem";
            resources.ApplyResources(this.saveSequenceMenuItem, "saveSequenceMenuItem");
            this.saveSequenceMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveSequenceAsMenuItem
            // 
            this.saveSequenceAsMenuItem.Name = "saveSequenceAsMenuItem";
            resources.ApplyResources(this.saveSequenceAsMenuItem, "saveSequenceAsMenuItem");
            this.saveSequenceAsMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.saveTofileToolStripMenuItem});
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            resources.ApplyResources(this.layoutsToolStripMenuItem, "layoutsToolStripMenuItem");
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            resources.ApplyResources(this.copyMenuItem, "copyMenuItem");
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // saveTofileToolStripMenuItem
            // 
            this.saveTofileToolStripMenuItem.Name = "saveTofileToolStripMenuItem";
            resources.ApplyResources(this.saveTofileToolStripMenuItem, "saveTofileToolStripMenuItem");
            this.saveTofileToolStripMenuItem.Click += new System.EventHandler(this.saveTofileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem,
            this.readMeMenuItem,
            this.licenseMenuItem});
            this.helpToolStripMenuItem.Image = global::TacticsBoard.Properties.Resources.Help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            resources.ApplyResources(this.helpMenuItem, "helpMenuItem");
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // readMeMenuItem
            // 
            this.readMeMenuItem.Name = "readMeMenuItem";
            resources.ApplyResources(this.readMeMenuItem, "readMeMenuItem");
            this.readMeMenuItem.Click += new System.EventHandler(this.readMeMenuItem_Click);
            // 
            // licenseMenuItem
            // 
            this.licenseMenuItem.Name = "licenseMenuItem";
            resources.ApplyResources(this.licenseMenuItem, "licenseMenuItem");
            this.licenseMenuItem.Click += new System.EventHandler(this.licenseMenuItem_Click);
            // 
            // playingSurfaceMenuItem
            // 
            this.playingSurfaceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orientationToolStripMenuItem,
            this.resetViewToolStripMenuItem,
            this.toolStripSeparator14,
            this.changePlayingSurfaceToolStripMenuItem});
            this.playingSurfaceMenuItem.Name = "playingSurfaceMenuItem";
            resources.ApplyResources(this.playingSurfaceMenuItem, "playingSurfaceMenuItem");
            // 
            // orientationToolStripMenuItem
            // 
            this.orientationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.orientationToolStripMenuItem.Name = "orientationToolStripMenuItem";
            resources.ApplyResources(this.orientationToolStripMenuItem, "orientationToolStripMenuItem");
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            resources.ApplyResources(this.horizontalToolStripMenuItem, "horizontalToolStripMenuItem");
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            resources.ApplyResources(this.verticalToolStripMenuItem, "verticalToolStripMenuItem");
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItem_Click);
            // 
            // resetViewToolStripMenuItem
            // 
            this.resetViewToolStripMenuItem.Name = "resetViewToolStripMenuItem";
            resources.ApplyResources(this.resetViewToolStripMenuItem, "resetViewToolStripMenuItem");
            this.resetViewToolStripMenuItem.Click += new System.EventHandler(this.ResetViewToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            // 
            // changePlayingSurfaceToolStripMenuItem
            // 
            this.changePlayingSurfaceToolStripMenuItem.Name = "changePlayingSurfaceToolStripMenuItem";
            resources.ApplyResources(this.changePlayingSurfaceToolStripMenuItem, "changePlayingSurfaceToolStripMenuItem");
            this.changePlayingSurfaceToolStripMenuItem.Click += new System.EventHandler(this.newPlayingSurfaceTypeMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // playSequenceTimer
            // 
            this.playSequenceTimer.Interval = 1000;
            this.playSequenceTimer.Tick += new System.EventHandler(this.PlaySequenceTimer_Tick);
            // 
            // fieldControl
            // 
            this.fieldControl.AllowInteraction = true;
            this.fieldControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fieldControl.CustomLabelProvider = null;
            resources.ApplyResources(this.fieldControl, "fieldControl");
            this.fieldControl.FieldType = null;
            this.fieldControl.IsDirty = false;
            this.fieldControl.IsViewDirty = false;
            this.fieldControl.Name = "fieldControl";
            this.fieldControl.ShowMovementLines = true;
            this.fieldControl.Tool = TacticsBoard.Tool.MoveObjects;
            this.fieldControl.ToolMode = TacticsBoard.ToolMode.MultiUse;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldControl);
            this.Controls.Add(this.sequenceToolString);
            this.Controls.Add(this.mainMenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.sequenceToolString.ResumeLayout(false);
            this.sequenceToolString.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ToolStrip sequenceToolString;
    private System.Windows.Forms.ToolStripButton recordNewPositionButton;
    private System.Windows.Forms.ToolStripButton previousLayoutInSequence;
    private System.Windows.Forms.ToolStripTextBox currentLayoutNumber;
    private System.Windows.Forms.ToolStripButton nextLayoutInSequence;
    private System.Windows.Forms.ToolStripButton recordOverCurrentPositionButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton removeCurrentPositionFromSequenceButton;
    private System.Windows.Forms.ToolStripButton revertCurrentLayoutToSavedButton;
    private System.Windows.Forms.MenuStrip mainMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem sequenceMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openSequenceMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveSequenceMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveSequenceAsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newSequenceMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton showMovementButton;
    private FieldControl fieldControl;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem playingSurfaceMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportSequenceToImageFilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToAviFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveTofileToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    private System.Windows.Forms.ToolStripMenuItem licenseMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem readMeMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripButton goToFirstToolStripButton;
    private System.Windows.Forms.ToolStripButton playToolStripButton;
    private System.Windows.Forms.Timer playSequenceTimer;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    private System.Windows.Forms.ToolStripButton goToLastToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
    private System.Windows.Forms.ToolStripMenuItem orientationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetViewToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton repeatToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem changePlayingSurfaceToolStripMenuItem;
    }
}

