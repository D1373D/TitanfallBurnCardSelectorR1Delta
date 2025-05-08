using BurnCardSelector.Properties;
using System.Reflection;

namespace BurnCardSelector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BurnCardFullList = new ListBox();
            BurnCardDisplayBox = new PictureBox();
            EquippedCard0 = new TextBox();
            EquippedCard1 = new TextBox();
            EquippedCard2 = new TextBox();
            Button_AddEquipped0 = new Button();
            Button_AddEquipped1 = new Button();
            Button_AddEquipped2 = new Button();
            CardInventoryTable = new DataGridView();
            Card = new DataGridViewTextBoxColumn();
            X = new DataGridViewTextBoxColumn();
            AddCardToInventory = new Button();
            InventoryQuantityButton = new NumericUpDown();
            button1 = new Button();
            ApplyProfile = new Button();
            LoadoutsListBox = new ListBox();
            InventoryTextBox = new TextBox();
            LoadoutsTextBox = new TextBox();
            LoadoutsSaveButton = new Button();
            LoadoutsLoadButton = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)BurnCardDisplayBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CardInventoryTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InventoryQuantityButton).BeginInit();
            SuspendLayout();
            // 
            // BurnCardFullList
            // 
            BurnCardFullList.BackColor = SystemColors.InactiveCaption;
            BurnCardFullList.Font = new Font("Franklin Gothic Medium", 10.8679247F, FontStyle.Bold);
            BurnCardFullList.FormattingEnabled = true;
            BurnCardFullList.ItemHeight = 21;
            BurnCardFullList.Location = new Point(549, 12);
            BurnCardFullList.Name = "BurnCardFullList";
            BurnCardFullList.Size = new Size(283, 739);
            BurnCardFullList.TabIndex = 2;
            BurnCardFullList.SelectedIndexChanged += BurnCardFullList_SelectedIndexChanged;
            // 
            // BurnCardDisplayBox
            // 
            BurnCardDisplayBox.Image = Resources.Active_Camo;
            BurnCardDisplayBox.InitialImage = Resources.Active_Camo;
            BurnCardDisplayBox.Location = new Point(12, 13);
            BurnCardDisplayBox.Name = "BurnCardDisplayBox";
            BurnCardDisplayBox.Size = new Size(525, 734);
            BurnCardDisplayBox.SizeMode = PictureBoxSizeMode.Zoom;
            BurnCardDisplayBox.TabIndex = 3;
            BurnCardDisplayBox.TabStop = false;
            // 
            // EquippedCard0
            // 
            EquippedCard0.BackColor = SystemColors.InactiveCaption;
            EquippedCard0.Font = new Font("Franklin Gothic Medium", 10.8679247F, FontStyle.Bold);
            EquippedCard0.Location = new Point(840, 39);
            EquippedCard0.Name = "EquippedCard0";
            EquippedCard0.Size = new Size(174, 26);
            EquippedCard0.TabIndex = 4;
            EquippedCard0.Text = "Empty";
            // 
            // EquippedCard1
            // 
            EquippedCard1.BackColor = SystemColors.InactiveCaption;
            EquippedCard1.Font = new Font("Franklin Gothic Medium", 10.8679247F, FontStyle.Bold);
            EquippedCard1.Location = new Point(840, 70);
            EquippedCard1.Name = "EquippedCard1";
            EquippedCard1.Size = new Size(174, 26);
            EquippedCard1.TabIndex = 4;
            EquippedCard1.Text = "Empty";
            // 
            // EquippedCard2
            // 
            EquippedCard2.BackColor = SystemColors.InactiveCaption;
            EquippedCard2.Font = new Font("Franklin Gothic Medium", 10.8679247F, FontStyle.Bold);
            EquippedCard2.Location = new Point(840, 101);
            EquippedCard2.Name = "EquippedCard2";
            EquippedCard2.Size = new Size(174, 26);
            EquippedCard2.TabIndex = 4;
            EquippedCard2.Text = "Empty";
            // 
            // Button_AddEquipped0
            // 
            Button_AddEquipped0.BackColor = Color.FromArgb(255, 192, 128);
            Button_AddEquipped0.BackgroundImage = Resources.plus;
            Button_AddEquipped0.BackgroundImageLayout = ImageLayout.Zoom;
            Button_AddEquipped0.Location = new Point(1014, 39);
            Button_AddEquipped0.Name = "Button_AddEquipped0";
            Button_AddEquipped0.Size = new Size(29, 29);
            Button_AddEquipped0.TabIndex = 5;
            Button_AddEquipped0.TextImageRelation = TextImageRelation.TextBeforeImage;
            Button_AddEquipped0.UseVisualStyleBackColor = false;
            Button_AddEquipped0.Click += Button_AddEquipped0_Click;
            // 
            // Button_AddEquipped1
            // 
            Button_AddEquipped1.BackColor = Color.FromArgb(255, 192, 128);
            Button_AddEquipped1.BackgroundImage = Resources.plus;
            Button_AddEquipped1.BackgroundImageLayout = ImageLayout.Zoom;
            Button_AddEquipped1.Location = new Point(1014, 70);
            Button_AddEquipped1.Name = "Button_AddEquipped1";
            Button_AddEquipped1.Size = new Size(29, 29);
            Button_AddEquipped1.TabIndex = 5;
            Button_AddEquipped1.TextImageRelation = TextImageRelation.TextBeforeImage;
            Button_AddEquipped1.UseVisualStyleBackColor = false;
            Button_AddEquipped1.Click += Button_AddEquipped1_Click;
            // 
            // Button_AddEquipped2
            // 
            Button_AddEquipped2.BackColor = Color.FromArgb(255, 192, 128);
            Button_AddEquipped2.BackgroundImage = Resources.plus;
            Button_AddEquipped2.BackgroundImageLayout = ImageLayout.Zoom;
            Button_AddEquipped2.Location = new Point(1014, 101);
            Button_AddEquipped2.Name = "Button_AddEquipped2";
            Button_AddEquipped2.Size = new Size(29, 29);
            Button_AddEquipped2.TabIndex = 5;
            Button_AddEquipped2.TextImageRelation = TextImageRelation.TextBeforeImage;
            Button_AddEquipped2.UseVisualStyleBackColor = false;
            Button_AddEquipped2.Click += Button_AddEquipped2_Click;
            // 
            // CardInventoryTable
            // 
            CardInventoryTable.AllowUserToAddRows = false;
            CardInventoryTable.AllowUserToDeleteRows = false;
            CardInventoryTable.AllowUserToResizeColumns = false;
            CardInventoryTable.AllowUserToResizeRows = false;
            CardInventoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CardInventoryTable.Columns.AddRange(new DataGridViewColumn[] { Card, X });
            CardInventoryTable.Location = new Point(838, 136);
            CardInventoryTable.MultiSelect = false;
            CardInventoryTable.Name = "CardInventoryTable";
            CardInventoryTable.ReadOnly = true;
            CardInventoryTable.RowHeadersVisible = false;
            CardInventoryTable.RowHeadersWidth = 25;
            CardInventoryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CardInventoryTable.Size = new Size(341, 247);
            CardInventoryTable.TabIndex = 7;
            // 
            // Card
            // 
            Card.HeaderText = "Card name";
            Card.MinimumWidth = 6;
            Card.Name = "Card";
            Card.ReadOnly = true;
            Card.Width = 270;
            // 
            // X
            // 
            X.HeaderText = "Quantity";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 70;
            // 
            // AddCardToInventory
            // 
            AddCardToInventory.BackColor = Color.FromArgb(255, 192, 128);
            AddCardToInventory.Font = new Font("Franklin Gothic Medium", 10.8679247F, FontStyle.Bold);
            AddCardToInventory.ForeColor = SystemColors.ControlText;
            AddCardToInventory.Location = new Point(838, 389);
            AddCardToInventory.Name = "AddCardToInventory";
            AddCardToInventory.Size = new Size(123, 33);
            AddCardToInventory.TabIndex = 8;
            AddCardToInventory.Text = "Add card";
            AddCardToInventory.UseVisualStyleBackColor = false;
            AddCardToInventory.Click += AddCard_Click;
            // 
            // InventoryQuantityButton
            // 
            InventoryQuantityButton.BackColor = SystemColors.InactiveCaption;
            InventoryQuantityButton.Font = new Font("Segoe UI", 11F);
            InventoryQuantityButton.Location = new Point(967, 389);
            InventoryQuantityButton.Name = "InventoryQuantityButton";
            InventoryQuantityButton.Size = new Size(71, 29);
            InventoryQuantityButton.TabIndex = 10;
            InventoryQuantityButton.Value = new decimal(new int[] { 3, 0, 0, 0 });
            InventoryQuantityButton.ValueChanged += QuantityChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Franklin Gothic Medium", 10.8679247F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1051, 389);
            button1.Name = "button1";
            button1.Size = new Size(128, 33);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += RemoveCards_Click;
            // 
            // ApplyProfile
            // 
            ApplyProfile.BackColor = Color.FromArgb(255, 192, 128);
            ApplyProfile.Font = new Font("Franklin Gothic Medium", 23.7735844F, FontStyle.Bold);
            ApplyProfile.Location = new Point(1049, 13);
            ApplyProfile.Name = "ApplyProfile";
            ApplyProfile.Size = new Size(130, 117);
            ApplyProfile.TabIndex = 11;
            ApplyProfile.Text = "Apply";
            ApplyProfile.UseVisualStyleBackColor = false;
            ApplyProfile.Click += ApplyProfile_Click;
            // 
            // LoadoutsListBox
            // 
            LoadoutsListBox.BackColor = SystemColors.InactiveCaption;
            LoadoutsListBox.Font = new Font("Franklin Gothic Medium", 10.8679247F, FontStyle.Bold);
            LoadoutsListBox.FormattingEnabled = true;
            LoadoutsListBox.ItemHeight = 21;
            LoadoutsListBox.Location = new Point(838, 458);
            LoadoutsListBox.Name = "LoadoutsListBox";
            LoadoutsListBox.Size = new Size(174, 109);
            LoadoutsListBox.TabIndex = 12;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.BackColor = SystemColors.InactiveCaption;
            InventoryTextBox.BorderStyle = BorderStyle.None;
            InventoryTextBox.Font = new Font("Franklin Gothic Medium", 16F, FontStyle.Bold);
            InventoryTextBox.Location = new Point(840, 12);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(203, 27);
            InventoryTextBox.TabIndex = 13;
            InventoryTextBox.Text = "INVENTORY";
            InventoryTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LoadoutsTextBox
            // 
            LoadoutsTextBox.BackColor = SystemColors.InactiveCaption;
            LoadoutsTextBox.BorderStyle = BorderStyle.None;
            LoadoutsTextBox.Font = new Font("Franklin Gothic Medium", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadoutsTextBox.Location = new Point(838, 424);
            LoadoutsTextBox.Name = "LoadoutsTextBox";
            LoadoutsTextBox.Size = new Size(341, 28);
            LoadoutsTextBox.TabIndex = 13;
            LoadoutsTextBox.Text = "LOADOUTS";
            LoadoutsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LoadoutsSaveButton
            // 
            LoadoutsSaveButton.BackColor = Color.FromArgb(255, 192, 128);
            LoadoutsSaveButton.Font = new Font("Franklin Gothic Medium", 23.7735844F, FontStyle.Bold);
            LoadoutsSaveButton.Location = new Point(1018, 458);
            LoadoutsSaveButton.Name = "LoadoutsSaveButton";
            LoadoutsSaveButton.Size = new Size(161, 53);
            LoadoutsSaveButton.TabIndex = 14;
            LoadoutsSaveButton.Text = "Save";
            LoadoutsSaveButton.UseVisualStyleBackColor = false;
            LoadoutsSaveButton.Click += SaveSelectedLoadout;
            // 
            // LoadoutsLoadButton
            // 
            LoadoutsLoadButton.BackColor = Color.FromArgb(255, 192, 128);
            LoadoutsLoadButton.Font = new Font("Franklin Gothic Medium", 23.7735844F, FontStyle.Bold);
            LoadoutsLoadButton.Location = new Point(1018, 514);
            LoadoutsLoadButton.Name = "LoadoutsLoadButton";
            LoadoutsLoadButton.Size = new Size(161, 53);
            LoadoutsLoadButton.TabIndex = 14;
            LoadoutsLoadButton.Text = "Load";
            LoadoutsLoadButton.UseVisualStyleBackColor = false;
            LoadoutsLoadButton.Click += LoadSelectedLoadout;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaption;
            richTextBox1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(838, 573);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(334, 178);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "For issues or questions please read the readme file on the github page:\nhttps://github.com/D1373D/TitanfallBurnCardSelectorR1Delta\n\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1184, 759);
            Controls.Add(richTextBox1);
            Controls.Add(LoadoutsLoadButton);
            Controls.Add(LoadoutsSaveButton);
            Controls.Add(LoadoutsTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(LoadoutsListBox);
            Controls.Add(ApplyProfile);
            Controls.Add(InventoryQuantityButton);
            Controls.Add(button1);
            Controls.Add(AddCardToInventory);
            Controls.Add(CardInventoryTable);
            Controls.Add(Button_AddEquipped2);
            Controls.Add(Button_AddEquipped1);
            Controls.Add(Button_AddEquipped0);
            Controls.Add(EquippedCard2);
            Controls.Add(EquippedCard1);
            Controls.Add(EquippedCard0);
            Controls.Add(BurnCardDisplayBox);
            Controls.Add(BurnCardFullList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BurnCardSelector";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BurnCardDisplayBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CardInventoryTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)InventoryQuantityButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox BurnCardFullList;
        public PictureBox BurnCardDisplayBox;
        private TextBox EquippedCard0;
        private TextBox EquippedCard1;
        private TextBox EquippedCard2;
        private Button Button_AddEquipped0;
        private Button Button_AddEquipped1;
        private Button Button_AddEquipped2;
        private DataGridView CardInventoryTable;
        private Button AddCardToInventory;
        private NumericUpDown InventoryQuantityButton;
        private Button button1;
        private Button ApplyProfile;
        private ListBox LoadoutsListBox;
        private TextBox InventoryTextBox;
        private TextBox LoadoutsTextBox;
        private Button LoadoutsSaveButton;
        private Button LoadoutsLoadButton;
        private DataGridViewTextBoxColumn Card;
        private DataGridViewTextBoxColumn X;
        private RichTextBox richTextBox1;
    }
}
