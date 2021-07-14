using System;
using System.Windows.Forms;

namespace TacticsBoard
{
    public partial class SelectPlayingSurfaceType : Form
    {
        public  int AmountPlayers { get; set; }
        public  int AmountBalls { get; set; }

        public SelectPlayingSurfaceType()
        {
            InitializeComponent();
        }

        internal static IPlayingSurfaceType AskUserForFieldType()
        {
            using (SelectPlayingSurfaceType sftDialog = new SelectPlayingSurfaceType())
            {
                //sftDialog.saveAsDefaultCheckBox.Checked = saveAsDefaultChecked;
                sftDialog.fieldTypeComboBox.DataSource = MainForm.AvailableFieldTypes;
                sftDialog.fieldTypeComboBox.DisplayMember = "Tag";
                sftDialog.Playerstxt.Text = "5";
                sftDialog.AmountPlayers = 5;
                sftDialog.Ballstxt.Text = "1";
                sftDialog.AmountBalls = 1;
                if (sftDialog.fieldTypeComboBox.Items.Count > 0)
                {

                    string defaultFieldType = global::TacticsBoard.Properties.Settings.Default.DefaultFieldType;
                    int selectedIndex = 0;
                    if (defaultFieldType != null)
                    {
                        int index = sftDialog.fieldTypeComboBox.FindStringExact(defaultFieldType);
                        if (index >= 0)
                        {
                            selectedIndex = index;
                        }
                    }
                    sftDialog.fieldTypeComboBox.SelectedIndex = selectedIndex;
                }
                if (sftDialog.ShowDialog() != DialogResult.OK)
                {
                    return null;
                }
                IPlayingSurfaceType selectedFieldType = (IPlayingSurfaceType)sftDialog.fieldTypeComboBox.SelectedItem;
                selectedFieldType.amountOfBalls = sftDialog.AmountBalls;
                selectedFieldType.PlayersPerTeam = sftDialog.AmountPlayers;
                return selectedFieldType;
            }
        }

        private void Playerstxt_Leave(object sender, System.EventArgs e)
        {
            try
            {
                AmountPlayers = int.Parse(Playerstxt.Text);
                if (AmountPlayers > 10)
                {
                    AmountPlayers = 5;
                }
            }
            catch (Exception)
            {
                AmountPlayers = 5;
            }
            finally
            {
                Playerstxt.Text = AmountPlayers.ToString();
            }
        }

        private void Ballstxt_Leave(object sender, EventArgs e)
        {
            try
            {
                AmountBalls = int.Parse(Ballstxt.Text);
                if(AmountBalls > 10)
                {
                    AmountBalls = 1;
                } 
            }
            catch (Exception)
            {
                AmountBalls = 1;
            }
            finally
            {
                Ballstxt.Text = AmountBalls.ToString();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Ballstxt_Leave(sender, e);
            Playerstxt_Leave(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}