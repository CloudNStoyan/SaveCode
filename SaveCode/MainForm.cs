using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveCode
{
    public partial class MainForm : Form
    {
        private string[] languages = {"C#","Javascript","Java"};
        private string mainFolderPath = @"C:\Users\Stoyan\Documents\SavedCode";

        public MainForm()
        {
            InitializeComponent();
            FormVariables.Initialize(this.titleLabel, this.titleInput, this.unfinishedCheckBox, this.errorCheckBox,
                this.languageMenu, this.descriptionInput, this.descriptionLabel, this.contentInput, this.contentLabel,
                this.errorLabel, this.errorInput, this.saveButton, this.clearFields, this.undoButton);

            FormVariables.LanguageMenu.Items.AddRange(languages);
            FormVariables.ErrorLabel.Visible = false;
            FormVariables.ErrorInput.Visible = false;
            CheckForFolder();
        }

        private void Save(object sender, EventArgs e)
        {
            if (ErrorInFields())
            {
                return;
            }

            string currentFolderPath = mainFolderPath + @"\" + FormVariables.TitleInput.Text.Replace(" ", "_");

            if (!Directory.Exists(currentFolderPath))
            {
                Directory.CreateDirectory(currentFolderPath);
            }
            else
            {
                MessageBox.Show(@"There is already saved code with this title!");
                return;
            }

            string language = languageMenu.SelectedIndex == 0 ? ".cs" : ".js";

            switch (languageMenu.SelectedIndex) 
            {
                case 0:
                    language = ".cs";
                    break;
                case 1:
                    language = ".js";
                    break;
                case 2:
                    language = ".java";
                    break;
            }

            File.WriteAllText(currentFolderPath + @"\Code" + language, FormVariables.ContentInput.Text);

            string description = $"Description: {FormVariables.DescriptionInput.Text}";
            string unfinished = FormVariables.UnfinishedCheckBox.Checked ? "Finished: False" : "Finished: True";
            string errors = IsEmptyString(FormVariables.ErrorInput.Text) ? "Errors: None" : $"Errors: {FormVariables.ErrorInput.Text}";

            var buildInfo = new StringBuilder();
            buildInfo.AppendLine(description);
            buildInfo.AppendLine(unfinished);
            buildInfo.AppendLine(errors);


            File.WriteAllText(currentFolderPath + @"\Info.txt", buildInfo.ToString().Trim());

            OldFields.GetFormData();
            FormVariables.ClearValues();

            MessageBox.Show(@"Saved!");

        }

        private void ShowHideErrors(object sender, EventArgs e)
        {
            FormVariables.ErrorLabel.Visible = !errorLabel.Visible;
            FormVariables.ErrorInput.Visible = !errorInput.Visible;
        }

        private bool IsEmptyString(string input)
        {
            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
            {
                return true;
            }

            return false;
        }

        private bool ErrorInFields()
        {
            var listOfErrors = new StringBuilder();

            if (IsEmptyString(FormVariables.TitleInput.Text))
            {
                listOfErrors.AppendLine("Title is required!");
            }

            if (IsEmptyString(FormVariables.ContentInput.Text))
            {
                listOfErrors.AppendLine("Content is required!");
            }

            if (IsEmptyString(FormVariables.DescriptionInput.Text))
            {
                listOfErrors.AppendLine("Description is required!");
            }

            if (FormVariables.ErrorCheckBox.Checked && IsEmptyString(FormVariables.ErrorInput.Text))
            {
                listOfErrors.AppendLine("Specify error is required!");
            }

            if (languageMenu.SelectedIndex == -1)
            {
                listOfErrors.AppendLine("Code language is required!");
            }

            if (listOfErrors.Length > 0)
            {
                MessageBox.Show(listOfErrors.ToString().Trim());
                return true;
            }

            return false;
        }

        private void CheckForFolder()
        {
            string path = @"C:\Users\Stoyan\Documents\SavedCode";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(mainFolderPath);
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            OldFields.GetFormData();
            FormVariables.ClearValues();
        }

        private void UndoClear(object sender, EventArgs e)
        {
            if (OldFields.HasBeenFilled)
            {
                OldFields.FillFormData();
            }
            else
            {
                MessageBox.Show(@"There is nothing to undo!");
            }
        }
    }
}
