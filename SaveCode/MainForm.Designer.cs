namespace SaveCode
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.unfinishedCheckBox = new System.Windows.Forms.CheckBox();
            this.errorCheckBox = new System.Windows.Forms.CheckBox();
            this.languageMenu = new System.Windows.Forms.ComboBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.contentInput = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearFields = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(49, 10);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(301, 20);
            this.titleInput.TabIndex = 1;
            // 
            // unfinishedCheckBox
            // 
            this.unfinishedCheckBox.AutoSize = true;
            this.unfinishedCheckBox.Location = new System.Drawing.Point(16, 36);
            this.unfinishedCheckBox.Name = "unfinishedCheckBox";
            this.unfinishedCheckBox.Size = new System.Drawing.Size(76, 17);
            this.unfinishedCheckBox.TabIndex = 3;
            this.unfinishedCheckBox.Text = "Unfinished";
            this.unfinishedCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorCheckBox
            // 
            this.errorCheckBox.AutoSize = true;
            this.errorCheckBox.Location = new System.Drawing.Point(99, 37);
            this.errorCheckBox.Name = "errorCheckBox";
            this.errorCheckBox.Size = new System.Drawing.Size(53, 17);
            this.errorCheckBox.TabIndex = 4;
            this.errorCheckBox.Text = "Errors";
            this.errorCheckBox.UseVisualStyleBackColor = true;
            this.errorCheckBox.CheckedChanged += new System.EventHandler(this.ShowHideErrors);
            // 
            // languageMenu
            // 
            this.languageMenu.FormattingEnabled = true;
            this.languageMenu.Location = new System.Drawing.Point(158, 34);
            this.languageMenu.Name = "languageMenu";
            this.languageMenu.Size = new System.Drawing.Size(121, 21);
            this.languageMenu.TabIndex = 5;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(82, 59);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(268, 20);
            this.descriptionInput.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 63);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description:";
            // 
            // contentInput
            // 
            this.contentInput.Location = new System.Drawing.Point(12, 104);
            this.contentInput.Multiline = true;
            this.contentInput.Name = "contentInput";
            this.contentInput.Size = new System.Drawing.Size(334, 227);
            this.contentInput.TabIndex = 8;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(13, 88);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(47, 13);
            this.contentLabel.TabIndex = 9;
            this.contentLabel.Text = "Content:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(13, 354);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(37, 13);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Errors:";
            // 
            // errorInput
            // 
            this.errorInput.Location = new System.Drawing.Point(56, 351);
            this.errorInput.Name = "errorInput";
            this.errorInput.Size = new System.Drawing.Size(290, 20);
            this.errorInput.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(142, 377);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Save);
            // 
            // clearFields
            // 
            this.clearFields.Location = new System.Drawing.Point(61, 377);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(75, 23);
            this.clearFields.TabIndex = 13;
            this.clearFields.Text = "Clear";
            this.clearFields.UseVisualStyleBackColor = true;
            this.clearFields.Click += new System.EventHandler(this.Clear);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(223, 377);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 23);
            this.undoButton.TabIndex = 14;
            this.undoButton.Text = "Undo Clear";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoClear);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 407);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.errorInput);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.contentInput);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.languageMenu);
            this.Controls.Add(this.errorCheckBox);
            this.Controls.Add(this.unfinishedCheckBox);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(382, 446);
            this.MinimumSize = new System.Drawing.Size(382, 446);
            this.Name = "MainForm";
            this.Text = "Code Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.CheckBox unfinishedCheckBox;
        private System.Windows.Forms.CheckBox errorCheckBox;
        private System.Windows.Forms.ComboBox languageMenu;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox contentInput;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox errorInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.Button undoButton;
    }
}

