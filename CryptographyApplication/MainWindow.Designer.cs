namespace CryptographyApplication
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.applicationTabControl = new System.Windows.Forms.TabControl();
            this.encryptionTabPage = new System.Windows.Forms.TabPage();
            this.encryptionKey = new System.Windows.Forms.Label();
            this.encryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.encryptionText = new System.Windows.Forms.Label();
            this.encryptionTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptionResult = new System.Windows.Forms.Label();
            this.encryptionResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.decryptionTabPage = new System.Windows.Forms.TabPage();
            this.decryptionKey = new System.Windows.Forms.Label();
            this.decryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.decryptionText = new System.Windows.Forms.Label();
            this.decryptionTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptionResult = new System.Windows.Forms.Label();
            this.decryptionResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveSoftwareMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSoftwareMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationTabControl.SuspendLayout();
            this.encryptionTabPage.SuspendLayout();
            this.decryptionTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationTabControl
            // 
            this.applicationTabControl.Controls.Add(this.encryptionTabPage);
            this.applicationTabControl.Controls.Add(this.decryptionTabPage);
            this.applicationTabControl.ImageList = this.images;
            this.applicationTabControl.Location = new System.Drawing.Point(0, 27);
            this.applicationTabControl.Name = "applicationTabControl";
            this.applicationTabControl.SelectedIndex = 0;
            this.applicationTabControl.Size = new System.Drawing.Size(824, 431);
            this.applicationTabControl.TabIndex = 1;
            this.applicationTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.handleTabControl_Selected);
            // 
            // encryptionTabPage
            // 
            this.encryptionTabPage.Controls.Add(this.encryptionKey);
            this.encryptionTabPage.Controls.Add(this.encryptionKeyTextBox);
            this.encryptionTabPage.Controls.Add(this.encryptionText);
            this.encryptionTabPage.Controls.Add(this.encryptionTextRichTextBox);
            this.encryptionTabPage.Controls.Add(this.encryptionResult);
            this.encryptionTabPage.Controls.Add(this.encryptionResultRichTextBox);
            this.encryptionTabPage.Controls.Add(this.encryptionButton);
            this.encryptionTabPage.ImageIndex = 0;
            this.encryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.encryptionTabPage.Name = "encryptionTabPage";
            this.encryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionTabPage.Size = new System.Drawing.Size(816, 405);
            this.encryptionTabPage.TabIndex = 0;
            this.encryptionTabPage.Text = "Chiffrement";
            this.encryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // encryptionKey
            // 
            this.encryptionKey.AutoSize = true;
            this.encryptionKey.Location = new System.Drawing.Point(40, 7);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(22, 13);
            this.encryptionKey.TabIndex = 0;
            this.encryptionKey.Text = "Clé";
            // 
            // encryptionKeyTextBox
            // 
            this.encryptionKeyTextBox.Location = new System.Drawing.Point(68, 7);
            this.encryptionKeyTextBox.Name = "encryptionKeyTextBox";
            this.encryptionKeyTextBox.Size = new System.Drawing.Size(740, 20);
            this.encryptionKeyTextBox.TabIndex = 1;
            // 
            // encryptionText
            // 
            this.encryptionText.AutoSize = true;
            this.encryptionText.Location = new System.Drawing.Point(28, 33);
            this.encryptionText.Name = "encryptionText";
            this.encryptionText.Size = new System.Drawing.Size(34, 13);
            this.encryptionText.TabIndex = 2;
            this.encryptionText.Text = "Texte";
            // 
            // encryptionTextRichTextBox
            // 
            this.encryptionTextRichTextBox.Location = new System.Drawing.Point(68, 33);
            this.encryptionTextRichTextBox.Name = "encryptionTextRichTextBox";
            this.encryptionTextRichTextBox.Size = new System.Drawing.Size(740, 150);
            this.encryptionTextRichTextBox.TabIndex = 3;
            this.encryptionTextRichTextBox.Text = "";
            // 
            // encryptionResult
            // 
            this.encryptionResult.AutoSize = true;
            this.encryptionResult.Location = new System.Drawing.Point(16, 189);
            this.encryptionResult.Name = "encryptionResult";
            this.encryptionResult.Size = new System.Drawing.Size(46, 13);
            this.encryptionResult.TabIndex = 4;
            this.encryptionResult.Text = "Résultat";
            // 
            // encryptionResultRichTextBox
            // 
            this.encryptionResultRichTextBox.Location = new System.Drawing.Point(68, 189);
            this.encryptionResultRichTextBox.Name = "encryptionResultRichTextBox";
            this.encryptionResultRichTextBox.Size = new System.Drawing.Size(740, 140);
            this.encryptionResultRichTextBox.TabIndex = 5;
            this.encryptionResultRichTextBox.Text = "";
            // 
            // encryptionButton
            // 
            this.encryptionButton.Location = new System.Drawing.Point(733, 335);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(75, 23);
            this.encryptionButton.TabIndex = 6;
            this.encryptionButton.Text = "Chiffrer";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // decryptionTabPage
            // 
            this.decryptionTabPage.Controls.Add(this.decryptionKey);
            this.decryptionTabPage.Controls.Add(this.decryptionKeyTextBox);
            this.decryptionTabPage.Controls.Add(this.decryptionText);
            this.decryptionTabPage.Controls.Add(this.decryptionTextRichTextBox);
            this.decryptionTabPage.Controls.Add(this.decryptionResult);
            this.decryptionTabPage.Controls.Add(this.decryptionResultRichTextBox);
            this.decryptionTabPage.Controls.Add(this.decryptionButton);
            this.decryptionTabPage.ImageIndex = 1;
            this.decryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.decryptionTabPage.Name = "decryptionTabPage";
            this.decryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.decryptionTabPage.Size = new System.Drawing.Size(816, 405);
            this.decryptionTabPage.TabIndex = 1;
            this.decryptionTabPage.Text = "Déchiffrement";
            this.decryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // decryptionKey
            // 
            this.decryptionKey.AutoSize = true;
            this.decryptionKey.Location = new System.Drawing.Point(40, 7);
            this.decryptionKey.Name = "decryptionKey";
            this.decryptionKey.Size = new System.Drawing.Size(22, 13);
            this.decryptionKey.TabIndex = 0;
            this.decryptionKey.Text = "Clé";
            // 
            // decryptionKeyTextBox
            // 
            this.decryptionKeyTextBox.Location = new System.Drawing.Point(68, 7);
            this.decryptionKeyTextBox.Name = "decryptionKeyTextBox";
            this.decryptionKeyTextBox.Size = new System.Drawing.Size(740, 20);
            this.decryptionKeyTextBox.TabIndex = 1;
            // 
            // decryptionText
            // 
            this.decryptionText.AutoSize = true;
            this.decryptionText.Location = new System.Drawing.Point(28, 33);
            this.decryptionText.Name = "decryptionText";
            this.decryptionText.Size = new System.Drawing.Size(34, 13);
            this.decryptionText.TabIndex = 2;
            this.decryptionText.Text = "Texte";
            // 
            // decryptionTextRichTextBox
            // 
            this.decryptionTextRichTextBox.Location = new System.Drawing.Point(68, 33);
            this.decryptionTextRichTextBox.Name = "decryptionTextRichTextBox";
            this.decryptionTextRichTextBox.Size = new System.Drawing.Size(740, 150);
            this.decryptionTextRichTextBox.TabIndex = 3;
            this.decryptionTextRichTextBox.Text = "";
            // 
            // decryptionResult
            // 
            this.decryptionResult.AutoSize = true;
            this.decryptionResult.Location = new System.Drawing.Point(16, 189);
            this.decryptionResult.Name = "decryptionResult";
            this.decryptionResult.Size = new System.Drawing.Size(46, 13);
            this.decryptionResult.TabIndex = 4;
            this.decryptionResult.Text = "Résultat";
            // 
            // decryptionResultRichTextBox
            // 
            this.decryptionResultRichTextBox.Location = new System.Drawing.Point(68, 189);
            this.decryptionResultRichTextBox.Name = "decryptionResultRichTextBox";
            this.decryptionResultRichTextBox.Size = new System.Drawing.Size(740, 140);
            this.decryptionResultRichTextBox.TabIndex = 5;
            this.decryptionResultRichTextBox.Text = "";
            // 
            // decryptionButton
            // 
            this.decryptionButton.Location = new System.Drawing.Point(733, 335);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(75, 23);
            this.decryptionButton.TabIndex = 6;
            this.decryptionButton.Text = "Déchiffrer";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "encryption.png");
            this.images.Images.SetKeyName(1, "decryption.png");
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaveSoftwareMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 20);
            this.fileMenu.Text = "Fichier";
            // 
            // leaveSoftwareMenuItem
            // 
            this.leaveSoftwareMenuItem.Name = "leaveSoftwareMenuItem";
            this.leaveSoftwareMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.leaveSoftwareMenuItem.Size = new System.Drawing.Size(154, 22);
            this.leaveSoftwareMenuItem.Text = "Quitter";
            this.leaveSoftwareMenuItem.Click += new System.EventHandler(this.leaveSoftwareMenuItem_Click);
            // 
            // informationMenu
            // 
            this.informationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSoftwareMenuItem});
            this.informationMenu.Name = "informationMenu";
            this.informationMenu.Size = new System.Drawing.Size(24, 20);
            this.informationMenu.Text = "?";
            // 
            // aboutSoftwareMenuItem
            // 
            this.aboutSoftwareMenuItem.Name = "aboutSoftwareMenuItem";
            this.aboutSoftwareMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutSoftwareMenuItem.Text = "À propos";
            this.aboutSoftwareMenuItem.Click += new System.EventHandler(this.aboutSoftwareMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.informationMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 456);
            this.Controls.Add(this.applicationTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Application de cryptographie";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.applicationTabControl.ResumeLayout(false);
            this.encryptionTabPage.ResumeLayout(false);
            this.encryptionTabPage.PerformLayout();
            this.decryptionTabPage.ResumeLayout(false);
            this.decryptionTabPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl applicationTabControl;
        private System.Windows.Forms.TabPage encryptionTabPage;
        private System.Windows.Forms.Label encryptionKey;
        private System.Windows.Forms.TextBox encryptionKeyTextBox;
        private System.Windows.Forms.Label encryptionText;
        private System.Windows.Forms.RichTextBox encryptionTextRichTextBox;
        private System.Windows.Forms.Label encryptionResult;
        private System.Windows.Forms.RichTextBox encryptionResultRichTextBox;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.TabPage decryptionTabPage;
        private System.Windows.Forms.Label decryptionKey;
        private System.Windows.Forms.TextBox decryptionKeyTextBox;
        private System.Windows.Forms.Label decryptionText;
        private System.Windows.Forms.RichTextBox decryptionTextRichTextBox;
        private System.Windows.Forms.Label decryptionResult;
        private System.Windows.Forms.RichTextBox decryptionResultRichTextBox;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem leaveSoftwareMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutSoftwareMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ImageList images;
    }
}

