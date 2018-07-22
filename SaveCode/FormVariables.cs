using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveCode
{
    public static class FormVariables
    {
        public static Label TitleLabel { get; set; }
        public static TextBox TitleInput { get; set; }
        public static CheckBox UnfinishedCheckBox { get; set; }
        public static CheckBox ErrorCheckBox { get; set; }
        public static ComboBox LanguageMenu { get; set; }
        public static TextBox DescriptionInput { get; set; }
        public static Label DescriptionLabel { get; set; }
        public static TextBox ContentInput { get; set; }
        public static Label ContentLabel { get; set; }
        public static Label ErrorLabel { get; set; }
        public static TextBox ErrorInput { get; set; }
        public static Button SaveButton { get; set; }
        public static Button ClearFields { get; set; }
        public static Button UndoButton { get; set; }


        public static void Initialize(Label titleLabel, TextBox titleInput, CheckBox unfinishedCheckBox,
            CheckBox errorCheckBox, ComboBox languageMenu, TextBox descriptionInput, Label descriptionLabel,
            TextBox contentInput, Label contentLabel, Label errorLabel, TextBox errorInput, Button saveButton,
            Button clearFields, Button undoButton)
        {
            TitleLabel = titleLabel;
            TitleInput = titleInput;
            UnfinishedCheckBox = unfinishedCheckBox;
            ErrorCheckBox = errorCheckBox;
            LanguageMenu = languageMenu;
            DescriptionInput = descriptionInput;
            DescriptionLabel = descriptionLabel;
            ContentInput = contentInput;
            ContentLabel = contentLabel;
            ErrorLabel = errorLabel;
            ErrorInput = errorInput;
            SaveButton = saveButton;
            ClearFields = clearFields;
            UndoButton = undoButton;
        }

        public static void ClearValues()
        {
            TitleInput.Text = String.Empty;
            UnfinishedCheckBox.Checked = false;
            ErrorCheckBox.Checked = false;
            LanguageMenu.SelectedIndex = -1;
            DescriptionInput.Text = String.Empty;
            ContentInput.Text = String.Empty;
            ErrorInput.Text = String.Empty;
        }
    }
}
