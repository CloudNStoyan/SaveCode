using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveCode
{
    public static class OldFields
    {
        private static  string Title { get; set; }
        private static  bool Unfinished { get; set; }
        private static  bool Errors { get; set; }
        private static  int SelectedLanguage { get; set; }
        private static  string Description { get; set; }
        private static  string Content { get; set; }
        private static  string ErrorContent { get; set; }
        public static bool HasBeenFilled { get; private set; }

        public static void FillFormData()
        {
            FormVariables.TitleInput.Text = Title;
            FormVariables.UnfinishedCheckBox.Checked = Unfinished;
            FormVariables.ErrorCheckBox.Checked = Errors;
            FormVariables.LanguageMenu.SelectedIndex = SelectedLanguage;
            FormVariables.DescriptionInput.Text = Description;
            FormVariables.ContentInput.Text = Content;
            FormVariables.ErrorInput.Text = ErrorContent;
        }

        public static void GetFormData()
        {
            Title = FormVariables.TitleInput.Text;
            Unfinished = FormVariables.UnfinishedCheckBox.Checked;
            Errors = FormVariables.ErrorCheckBox.Checked;
            SelectedLanguage = FormVariables.LanguageMenu.SelectedIndex;
            Description = FormVariables.DescriptionInput.Text;
            Content = FormVariables.ContentInput.Text;
            ErrorContent = FormVariables.ErrorInput.Text;
            HasBeenFilled = true;
        }
    }
}
