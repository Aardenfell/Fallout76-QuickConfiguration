﻿using Fo76ini.Interface;
using Fo76ini.API;
using Fo76ini.Properties;
using Fo76ini.Tweaks;
using Fo76ini.Utilities;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fo76ini.Forms.FormMain.Tabs
{
    public partial class UserControlSettings : UserControl, IExposeComponents
    {
        public ToolTip ToolTip => this.toolTip;

        private bool UpdatingUI = false;

        public UserControlSettings()
        {
            InitializeComponent();

            if (this.DesignMode)
                return;

            // Link tweaks
            LinkInfo();
            LinkControlsToTweaks();

            // Handle translations:
            Translation.LanguageChanged += OnLanguageChanged;

            // Assign a dropdown menu to hold languages:
            Localization.AssignDropDown(this.comboBoxLanguage);

            // Nuclear Winter:
            FormMods.NWModeUpdated += OnNWModeUpdated;

            // Add control elements to blacklist:
            /*Translation.BlackList.AddRange(new string[] {
                "buttonDownloadLanguages",
                "buttonRefreshLanguage"
            });*/

            if (this.DesignMode)
                return;

            this.labelTranslationsUpdateAvailable.Visible = false;
            Localization.NewTranslationsAvailable += Localization_NewTranslationsAvailable;
        }

        private void Localization_NewTranslationsAvailable(object sender, EventArgs e)
        {
            this.labelTranslationsUpdateAvailable.Visible = true;
        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;

            UpdatingUI = true;

            // Nuclear Winter:
            UpdateNWModeUI(false);

            // Load tweaks:
            LinkedTweaks.LoadValues();

            // "Associate with NXM links" checkbox:
            this.checkBoxHandleNXMLinks.Checked = NXMHandler.IsRegistered();

            // Path textboxes
            this.textBoxArchiveTwoPath.Text = Configuration.Archive2Path;
            this.textBoxSevenZipPath.Text = Configuration.SevenZipPath;
            this.textBoxDownloadsPath.Text = Configuration.DownloadPath;

            // Theme:
            switch (Configuration.Appearance.AppTheme)
            {
                case ThemeType.Light:
                    radioButtonLightTheme.Checked = true;
                    break;
                case ThemeType.Dark:
                    radioButtonDarkTheme.Checked = true;
                    break;
                case ThemeType.System:
                    radioButtonRespectSystemTheme.Checked = true;
                    break;
            }

            UpdatingUI = false;
        }

        #region Translations

        public void OnLanguageChanged(object sender, TranslationEventArgs e)
        {
            Translation translation = (Translation)sender;
            this.labelOutdatedLanguage.Visible = translation.IsOutdated();

            this.labelSettingsTitle.Font = CustomFonts.GetHeaderFont();
        }

        private void buttonDownloadLanguages_Click(object sender, EventArgs e)
        {
            if (this.backgroundWorkerDownloadLanguages.IsBusy)
                return;
            this.labelSettingsLocalization.Focus();
            this.buttonDownloadLanguages.Enabled = false;
            this.pictureBoxSpinnerDownloadLanguages.Visible = true;
            this.backgroundWorkerDownloadLanguages.RunWorkerAsync();
        }

        private void buttonRefreshLanguage_Click(object sender, EventArgs e)
        {
            Localization.LookupLanguages();
        }

        private Localization.DownloadResult languageFilesDownloadResult;
        private void backgroundWorkerDownloadLanguages_DoWork(object sender, DoWorkEventArgs e)
        {
            languageFilesDownloadResult = Localization.DownloadLanguageFiles();
        }

        private void backgroundWorkerDownloadLanguages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!languageFilesDownloadResult.Success)
                MsgBox.Get("failed")
                    .FormatText("Downloading language files failed.\n" + languageFilesDownloadResult.ErrorMessage)
                    .Popup(MessageBoxIcon.Error);
            else
                MsgBox.Get("downloadLanguagesFinished")
                    .FormatText(String.Join(", ", languageFilesDownloadResult.FileList))
                    .Popup(MessageBoxIcon.Information);

            this.buttonDownloadLanguages.Enabled = true;
            this.pictureBoxSpinnerDownloadLanguages.Visible = false;
            this.labelTranslationsUpdateAvailable.Visible = false;

            Localization.LookupLanguages();
        }

        #endregion

        #region Nuclear Winter (deprecated)

        private void OnNWModeUpdated(object sender, NuclearWinterEventArgs e)
        {
            this.Invoke(new Action(() => {
                UpdateNWModeUI(e.NuclearWinterModeEnabled);
            }));
        }

        private void UpdateNWModeUI(bool nwModeEnabled)
        {
            if (nwModeEnabled)
            {
                this.buttonToggleMods.Text = Localization.GetString("enableMods");
                //this.buttonToggleMods.Image = Resources.adventures;
            }
            else
            {
                this.buttonToggleMods.Text = Localization.GetString("disableMods");
                //this.buttonToggleMods.Image = Resources.fire;
            }
            this.buttonToggleMods.Refresh();

            //this.toolStripStatusLabelNuclearWinterModeActive.Visible = nwModeEnabled;

            Focus();
        }

        private void buttonNWMode_Click(object sender, EventArgs e)
        {
            if (NuclearWinterModeToggled != null)
                NuclearWinterModeToggled(sender, e);
        }
        public event EventHandler NuclearWinterModeToggled;

        #endregion

        private void checkBoxIgnoreUpdates_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxNotifyOnTranslationUpdate.Enabled = !this.checkBoxIgnoreUpdates.Checked;
        }

        #region Paths

        /*
         * Archive2 
         */

        private void textBoxArchiveTwoPath_TextChanged(object sender, EventArgs e)
        {
            if (UpdatingUI)
                return;
            Configuration.Archive2Path = this.textBoxArchiveTwoPath.Text;
        }

        private void buttonPickArchiveTwoPath_Click(object sender, EventArgs e)
        {
            if (UpdatingUI)
                return;
            this.openFileDialogArchiveTwoPath.FileName = Archive2.DefaultArchive2Path;
            if (this.openFileDialogArchiveTwoPath.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialogArchiveTwoPath.FileName;
                this.textBoxArchiveTwoPath.Text = path;
                Configuration.Archive2Path = this.textBoxArchiveTwoPath.Text;
            }
        }


        /*
         * 7-Zip
         */

        private void textBoxSevenZipPath_TextChanged(object sender, EventArgs e)
        {
            if (UpdatingUI)
                return;
            Configuration.SevenZipPath = this.textBoxSevenZipPath.Text;
        }

        private void buttonPickSevenZipPath_Click(object sender, EventArgs e)
        {
            if (UpdatingUI)
                return;
            this.openFileDialogSevenZipPath.FileName = SevenZip.DefaultExecPath;
            if (this.openFileDialogSevenZipPath.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialogSevenZipPath.FileName;
                this.textBoxSevenZipPath.Text = path;
                Configuration.SevenZipPath = this.textBoxSevenZipPath.Text;
            }
        }


        /*
         * Download folder
         */

        private void textBoxDownloadsPath_TextChanged(object sender, EventArgs e)
        {
            if (UpdatingUI)
                return;
        }

        private void buttonPickDownloadsPath_Click(object sender, EventArgs e)
        {
            if (UpdatingUI)
                return;

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Configuration.DefaultDownloadPath;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string path = dialog.FileName;
                this.textBoxDownloadsPath.Text = path;
                Configuration.DownloadPath = this.textBoxDownloadsPath.Text;
            }
            this.Focus();
        }

        #endregion

        #region NexusMods (NXM handler)

        private void checkBoxHandleNXMLinks_CheckedChanged(object sender, EventArgs e)
        {
            bool isRegistered = NXMHandler.IsRegistered();
            if (isRegistered == checkBoxHandleNXMLinks.Checked)
                return;

            try
            {
                if (isRegistered)
                    NXMHandler.Unregister();
                else
                    NXMHandler.Register();
            }
            catch (UnauthorizedAccessException ex)
            {
                if (!Utils.HasAdminRights())
                    MsgBox.Show("Access denied", "Start the tool as admin and try again.", MessageBoxIcon.Error);
                else
                    MsgBox.Show(ex.GetType().ToString(), ex.ToString(), MessageBoxIcon.Error);
                checkBoxHandleNXMLinks.Checked = isRegistered;
            }
            catch (Exception ex)
            {
                if (!Utils.HasAdminRights())
                    MsgBox.Show("Unknown error", "Start the tool as admin and try again.", MessageBoxIcon.Error);
                else
                    MsgBox.Show(ex.GetType().ToString(), ex.ToString(), MessageBoxIcon.Error);
                checkBoxHandleNXMLinks.Checked = isRegistered;
            }
        }

        #endregion

        private void linkLabelOpenProfileEditor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OpenProfileEditorRequested != null)
                OpenProfileEditorRequested(sender, e);
        }
        public event EventHandler OpenProfileEditorRequested;

        #region Themes

        private void radioButtonLightTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLightTheme.Checked && !UpdatingUI)
            {
                if (ApplyThemeRequested != null)
                {
                    ThemeEventArgs args = new ThemeEventArgs();
                    args.Theme = ThemeType.Light;
                    ApplyThemeRequested(sender, args);
                }
            }
        }

        private void radioButtonDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDarkTheme.Checked && !UpdatingUI)
            {
                if (ApplyThemeRequested != null)
                {
                    ThemeEventArgs args = new ThemeEventArgs();
                    args.Theme = ThemeType.Dark;
                    ApplyThemeRequested(sender, args);
                }
            }
        }

        private void radioButtonRespectSystemTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRespectSystemTheme.Checked && !UpdatingUI)
            {
                if (ApplyThemeRequested != null)
                {
                    ThemeEventArgs args = new ThemeEventArgs();
                    args.Theme = ThemeType.System;
                    ApplyThemeRequested(sender, args);
                }
            }
        }

        public event ThemeEventHandler ApplyThemeRequested;

        #endregion
    }

    public delegate void ThemeEventHandler(object sender, ThemeEventArgs e);

    public class ThemeEventArgs : EventArgs
    {
        public ThemeType Theme;
    }
}
