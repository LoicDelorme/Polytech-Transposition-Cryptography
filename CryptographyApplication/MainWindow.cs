using CryptographyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void leaveSoftwareMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutSoftwareMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logiciel réalisé par DELORME Loïc et KASPRZYK Nicolas.\n\nModule ISI - Polytech Lyon");
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            ITranspositionAlgorithm transpositionAlgorithm = new TranspositionCryptographyAlgorithm(this.encryptionKeyTextBox.Text);
            this.encryptionResultRichTextBox.Text = transpositionAlgorithm.encrypt(this.encryptionTextRichTextBox.Text);
        }

        private void decryptionButton_Click(object sender, EventArgs e)
        {
            ITranspositionAlgorithm transpositionAlgorithm = new TranspositionCryptographyAlgorithm(this.decryptionKeyTextBox.Text);
            this.decryptionResultRichTextBox.Text = transpositionAlgorithm.decrypt(this.decryptionTextRichTextBox.Text);
        }

        private void handleTabControl_Selected(Object sender, TabControlEventArgs e)
        {
            TabPage selectedTabPage = (sender as TabControl).SelectedTab;
            if (selectedTabPage.Equals(this.encryptionTabPage))
            {
                this.encryptionKeyTextBox.Text = this.decryptionKeyTextBox.Text;
                this.encryptionTextRichTextBox.Text = this.decryptionResultRichTextBox.Text;
                this.encryptionResultRichTextBox.Text = "";
            }
            else
            {
                this.decryptionKeyTextBox.Text = this.encryptionKeyTextBox.Text;
                this.decryptionTextRichTextBox.Text = this.encryptionResultRichTextBox.Text;
                this.decryptionResultRichTextBox.Text = "";
            }
        }
    }
}
