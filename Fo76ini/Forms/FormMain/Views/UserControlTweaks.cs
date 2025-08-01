﻿using Fo76ini.Interface;
using Fo76ini.Profiles;
using Fo76ini.Properties;
using Fo76ini.Tweaks;
using Fo76ini.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fo76ini.Forms.FormMain
{
    public partial class UserControlTweaks : UserControl, IExposeComponents
    {
        public ToolTip ToolTip => this.toolTip;

        public UserControlTweaks()
        {
            InitializeComponent();

            if (this.DesignMode)
                return;

            ProfileManager.ProfileChanged += OnProfileChanged;

            /*
             * Dropdowns
             */

            #region Dropdowns

            // Let's add options to the drop-down menus:

            // Display resolution usage statistics (and lists):
            // https://store.steampowered.com/hwsurvey/Steam-Hardware-Software-Survey-Welcome-to-Steam
            // https://www.rapidtables.com/web/dev/screen-resolution-statistics.html
            // https://w3codemasters.in/most-common-screen-resolutions/
            // https://www.reneelab.com/video-with-4-3-format.html
            // https://www.overclock.net/threads/list-of-display-resolutions-aspect-ratios.539967/
            // https://en.wikipedia.org/wiki/List_of_common_resolutions
            DropDown.Add("Resolution", new DropDown(
                this.comboBoxResolution,
                new string[] {
                    "Custom",
                    "",
                    "┌───────────────────────────────┐",
                    "│  4:3                          │",
                    "├───────────────────────────────┤",
                    "│ [4:3]    640 x  480 (VGA)     │",
                    "│ [4:3]    800 x  600 (SVGA)    │",
                    "│ [4:3]    960 x  720           │",
                    "│ [4:3]   1024 x  768 (XGA)     │",
                    "│ [4:3]   1152 x  864           │",
                    "│ [4:3]   1280 x  960           │",
                    "│ [4:3]   1400 x 1050           │",
                    "│ [4:3]   1440 x 1080           │",
                    "│ [4:3]   1600 x 1200           │",
                    "│ [4:3]   1920 x 1440           │",
                    "│ [4:3]   2048 x 1536           │",
                    "│ [4:3]   2880 x 2160           │",
                    "│                               │",
                    "│                               │",
                    "├───────────────────────────────┤",
                    "│  5:3                          │",
                    "├───────────────────────────────┤",
                    "│ [5:3]    800 x  480           │",
                    "│ [5:3]   1280 x  768 (WXGA)    │",
                    "│                               │",
                    "│                               │",
                    "├───────────────────────────────┤",
                    "│  5:4                          │",
                    "├───────────────────────────────┤",
                    "│ [5:4]   1152 x  960           │",
                    "│ [5:4]   1280 x 1024           │",
                    "│ [5:4]   2560 x 2048           │",
                    "│ [5:4]   5120 x 4096           │",
                    "│                               │",
                    "│                               │",
                    "├───────────────────────────────┤",
                    "│  16:9                         │",
                    "├───────────────────────────────┤",
                    "│ [16:9]  1024 x  576           │",
                    "│ [16:9]  1152 x  648           │",
                    "│ [16:9]  1280 x  720 (HD)      │",
                    "│ [16:9]  1360 x  768           │",
                    "│ [16:9]  1365 x  768           │",
                    "│ [16:9]  1366 x  768           │",
                    "│ [16:9]  1536 x  864           │",
                    "│ [16:9]  1600 x  900           │",
                    "│ [16:9]  1920 x 1080 (Full HD) │",
                    "│ [16:9]  2560 x 1440 (WQHD)    │",
                    "│ [16:9]  3200 x 1800           │",
                    "│ [16:9]  3840 x 2160 (4K UHD1) │",
                    "│ [16:9]  5120 x 2880 (5K)      │",
                    "│ [16:9]  7680 x 4320 (8K UHD2) │",
                    "│                               │",
                    "│                               │",
                    "├───────────────────────────────┤",
                    "│  16:10                        │",
                    "├───────────────────────────────┤",
                    "│ [16:10]  640 x  400           │",
                    "│ [16:10] 1280 x  800           │",
                    "│ [16:10] 1440 x  900           │",
                    "│ [16:10] 1680 x 1050           │",
                    "│ [16:10] 1920 x 1200           │",
                    "│ [16:10] 2560 x 1600           │",
                    "│ [16:10] 3840 x 2400           │",
                    "│                               │",
                    "│                               │",
                    "├───────────────────────────────┤",
                    "│  17:9                         │",
                    "├───────────────────────────────┤",
                    "│ [17:9]  2048 x 1080           │",
                    "│                               │",
                    "│                               │",
                    "├───────────────────────────────┤",
                    "│  21:9                         │",
                    "├───────────────────────────────┤",
                    "│ [21:9]  1920 x  800           │",
                    "│ [21:9]  2560 x 1080           │",
                    "│ [21:9]  3440 x 1440           │",
                    "│ [21:9]  3840 x 1600           │",
                    "│ [21:9]  5120 x 2160           │",
                    "│                               │",
                    "│                               │",
                    "└───────────────────────────────┘",
                    ""
                }
            ));

            DropDown.Add("DisplayMode", new DropDown(
                this.comboBoxDisplayMode,
                new string[] {
                    "Fullscreen",
                    "Windowed",
                    "Borderless windowed",
                    "Borderless windowed (Fullscreen)"
                }
            ));

            DropDown.Add("AntiAliasing", new DropDown(
                this.comboBoxAntiAliasing,
                new string[] {
                    "Enabled, TAA (default)",
                    "Disabled"
                }
            ));

            DropDown.Add("AnisotropicFiltering", new DropDown(
                this.comboBoxAnisotropicFiltering,
                new string[] {
                    "None",
                    "2x",
                    "4x",
                    "8x",
                    "16x (default)"
                }
            ));

            DropDown.Add("ShadowTextureResolution", new DropDown(
                this.comboBoxShadowTextureResolution,
                new string[] {
                    "512 = Potato",
                    "1024 = Low",
                    "2048 = High (default)",
                    "4096 = Ultra",
                    "8192 = Insane"
                }
            ));

            DropDown.Add("ShadowBlurriness", new DropDown(
                this.comboBoxShadowBlurriness,
                new string[] {
                    "0x",
                    "1x (crisper, pixels noticeable)",
                    "2x (less blurry)",
                    "3x (blurry, default)"
                }
            ));

            DropDown.Add("ShadowQuality", new DropDown(
                this.comboBoxShadowQuality,
                new string[] {
                    "Low",
                    "Medium",
                    "High",
                    "Ultra",
                    "Custom"
                }
            ));

            DropDown.Add("VoiceChatMode", new DropDown(
                this.comboBoxVoiceChatMode,
                new string[] {
                    "Auto",
                    "Area",
                    "Team",
                    "None"
                }
            ));

            DropDown.Add("ShowActiveEffectsOnHUD", new DropDown(
                this.comboBoxShowActiveEffectsOnHUD,
                new string[] {
                    "Disabled",
                    "Detrimental",
                    "All"
                }
            ));

            /*DropDown.Add("iDirShadowSplits", new DropDown(
                this.comboBoxiDirShadowSplits,
                new string[] {
                    "1 - Low",
                    "2 - High / Medium",
                    "3 - Ultra"
                }
            ));*/

            DropDown.Add("CorpseHighlighting", new DropDown(
                this.comboBoxHighlightCorpses,
                new string[] {
                    "Disabled",
                    "Clear On Inspect",
                    "Clear On Remove"
                }
            ));

            DropDown.Add("TextureQuality", new DropDown(
                this.comboBoxTextureQuality,
                new string[] {
                    "Low",
                    "Medium",
                    "High",
                    "Ultra",
                    "Custom"
                }
            ));

            DropDown.Add("WaterShadowFilter", new DropDown(
                this.comboBoxWaterShadowFilter,
                new string[] {
                    "1 (Low)",
                    "2 (Medium)",
                    "3 (High)"
                }
            ));

            DropDown.Add("VolumetricLightingQuality", new DropDown(
                this.comboBoxGodrayQuality,
                new string[] {
                    "0 (Low)",
                    "1 (Medium)",
                    "2 (High)"
                }
            ));

            DropDown.Add("VATSGrenadeMineTargetingMode", new DropDown(
                this.comboBoxVATSGrenadeMineTargetingMode,
                new string[] {
                    "None",
                    "Only My Own",
                    "All"
                }
            ));

            DropDown.Add("QuickHealStimpakPriority", new DropDown(
                this.comboBoxQuickHealStimpakPriority,
                new string[] {
                    "Use Weakest First",
                    "Use Strongest First"
                }
            ));

            DropDown.Add("ScreenNarrationVoiceType", new DropDown(
                this.comboBoxScreenNarrationVoiceType,
                new string[] {
                    "Voice Type 1",
                    "Voice Type 2"
                }
            ));

            #endregion


            // Add control elements to blacklist:
            Translation.BlackList.AddRange(new string[] {
                "richTextBoxCredentialsExplanation",
                "labelSelectedQualityPreset"
            });

            Translation.LanguageChanged += Translation_LanguageChanged;

            // Link tweaks
            LinkInfo();
            LinkSliders();
            LinkControlsToTweaks();

            this.labelTweaksTitle.Font = new Font(CustomFonts.Overseer, 20, FontStyle.Regular);

            this.pictureBoxFOVPreview.Image = getFOVPreviewImage((int)this.fovTweak.GetValue());
            this.pictureBoxViewmodelFOV.Image = getViewmodelFOVPreviewImage((int)this.fov1stPersonTweak.GetValue());
        }

        private void Translation_LanguageChanged(object sender, TranslationEventArgs e)
        {
            LoadTextResources();

            this.labelTweaksTitle.Font = CustomFonts.GetHeaderFont();
        }

        private void UserControlTweaks_Load(object sender, EventArgs e)
        {
            LoadTextResources();
        }

        private void LoadTextResources()
        {
            /*
             * Loading texts:
             */

            if (Utils.IsWindows10OrNewer())
                this.webBrowserTweaksInfo.DocumentText = Localization.GetTextResource("TweaksInfo.html");
            else
                this.webBrowserTweaksInfo.Visible = false;

            // Loading RTF in the Constructor results in unformatted text for some reason...
            // we have to load it here:
            // this.richTextBoxCredentialsExplanation.Rtf = Localization.GetTextResource("Login with Bethesda.net.rtf");
        }

        private void webBrowserTweaksInfo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowserTweaksInfo.Document.BackColor = Theming.GetColor("BackColor", Color.White);
            this.webBrowserTweaksInfo.Document.ForeColor = Theming.GetColor("TextColor", Color.Black);
        }

        private void OnProfileChanged(object sender, ProfileEventArgs e)
        {
            // For some reason, it won't update the resolution combobox, unless I add this workaround:
            numCustomRes_ValueChanged(null, null);
        }

        #region Resolution combobox

        // Detect resolution:
        private void buttonDetectResolution_Click(object sender, EventArgs e)
        {
            Size res = Utils.GetDisplayResolution();
            this.numCustomResW.Value = res.Width;
            this.numCustomResH.Value = res.Height;
        }

        private void comboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If "Custom" selected, skip:
            if (this.comboBoxResolution.SelectedIndex == 0)
                return;

            // If an invalid option has been selected, set to "Custom" and skip:
            string res = this.comboBoxResolution.SelectedItem.ToString();
            Size? displaySize = GetResolutionFromString(res);
            if (!displaySize.HasValue)
            {
                this.comboBoxResolution.SelectedIndex = 0;
                return;
            }

            int width = displaySize.Value.Width;
            int height = displaySize.Value.Height;

            // Set the values of the NumericUpDowns (which in turn will trigger the event handlers which set the values in the *.ini files)
            if (this.numCustomResW.Value != width)
                this.numCustomResW.Value = width;

            if (this.numCustomResH.Value != height)
                this.numCustomResH.Value = height;
        }

        /// <summary>
        /// Extracts width and height from a string that looks like this: "[16:9] 1920 x 1080 (Full HD)"
        /// </summary>
        /// <returns>Width and height if a valid option has been selected. Otherwise null.</returns>
        private Size? GetResolutionFromString(String res)
        {
            if (!res.Contains("x"))
                return null;
            string[] split = res.Split('x').Select(x => x.Trim()).ToArray();
            int width = Convert.ToInt32(Regex.Match(split[0], @"[0-9]+$").Groups[0].Value);
            int height = Convert.ToInt32(Regex.Match(split[1], @"^[0-9]+").Groups[0].Value);
            return new Size(width, height);
        }

        /// <summary>
        /// Searches through the resolution combobox for an option that matches the given size.
        /// </summary>
        /// <param name="size"></param>
        /// <returns>The first occurence if a match was found. Otherwise -1.</returns>
        private int FindIndexInResolutionComboBox(Size size)
        {
            for (int i = 0; i < this.comboBoxResolution.Items.Count; i++)
            {
                string res = this.comboBoxResolution.Items[i].ToString();
                Size? s = GetResolutionFromString(res);
                if (s?.Width == size.Width && s?.Height == size.Height)
                    return i;
            }
            return -1;
        }

        private void numCustomRes_ValueChanged(object sender, EventArgs e)
        {
            Size size = new Size(
                Convert.ToInt32(numCustomResW.Value),
                Convert.ToInt32(numCustomResH.Value)
            );
            int i = FindIndexInResolutionComboBox(size);
            if (i > -1)
                this.comboBoxResolution.SelectedIndex = i;
            else
                this.comboBoxResolution.SelectedIndex = 0;
        }

        #endregion

        #region Camera

        private void buttonCameraPositionReset_Click(object sender, EventArgs e)
        {
            this.applyCameraNodeAnimationsTweak.ResetValue();
            this.cameraOverShoulderPosXTweak.ResetValue();
            this.cameraOverShoulderPosZTweak.ResetValue();
            this.cameraOverShoulderCombatPosXTweak.ResetValue();
            this.cameraOverShoulderCombatPosZTweak.ResetValue();
            this.cameraOverShoulderCombatAddYTweak.ResetValue();
            this.cameraOverShoulderMeleeCombatPosXTweak.ResetValue();
            this.cameraOverShoulderMeleeCombatPosZTweak.ResetValue();
            this.cameraOverShoulderMeleeCombatAddYTweak.ResetValue();
            LinkedTweaks.LoadValues();
        }

        private Bitmap getFOVPreviewImage(int fov)
        {
            fov = (int)(Math.Round((float)fov / 5f) * 5);
            fov = Utils.Clamp(fov, 70, 120);
            switch (fov)
            {
                case 70:
                    return Resources.fov_70;
                case 75:
                    return Resources.fov_75;
                case 80:
                    return Resources.fov_80;
                case 85:
                    return Resources.fov_85;
                case 90:
                    return Resources.fov_90;
                case 95:
                    return Resources.fov_95;
                case 100:
                    return Resources.fov_100;
                case 105:
                    return Resources.fov_105;
                case 110:
                    return Resources.fov_110;
                case 115:
                    return Resources.fov_115;
                case 120:
                    return Resources.fov_120;
                default:
                    return Resources.fov_70;
            }
        }

        private Bitmap getViewmodelFOVPreviewImage(int fov)
        {
            fov = (int)(Math.Round((float)fov / 5f) * 5);
            fov = Utils.Clamp(fov, 70, 120);
            switch (fov)
            {
                case 70:
                    return Resources.fov_viewmodel_70;
                case 75:
                    return Resources.fov_viewmodel_75;
                case 80:
                    return Resources.fov_viewmodel_80;
                case 85:
                    return Resources.fov_viewmodel_85;
                case 90:
                    return Resources.fov_viewmodel_90;
                case 95:
                    return Resources.fov_viewmodel_95;
                case 100:
                    return Resources.fov_viewmodel_100;
                case 105:
                    return Resources.fov_viewmodel_105;
                case 110:
                    return Resources.fov_viewmodel_110;
                case 115:
                    return Resources.fov_viewmodel_115;
                case 120:
                    return Resources.fov_viewmodel_120;
                default:
                    return Resources.fov_viewmodel_80;
            }
        }

        private void numFOV_ValueChanged(object sender, EventArgs e)
        {
            this.pictureBoxFOVPreview.Image = getFOVPreviewImage((int)this.numFOV.Value);
        }

        private void numViewmodelFOV_ValueChanged(object sender, EventArgs e)
        {
            this.pictureBoxViewmodelFOV.Image = getViewmodelFOVPreviewImage((int)this.numViewmodelFOV.Value);
        }

        #endregion

        private void buttonOpenTweakInfoInBrowser_Click(object sender, EventArgs e)
        {
            Utils.OpenHTMLInBrowser(Localization.GetTextResource("TweaksInfo.html"));
        }

        #region Overall graphics quality presets

        private void buttonSelectOverallQualityPreset_Click(object sender, EventArgs e)
        {
            if (contextMenuStripOverallQualityPresets.Visible)
                contextMenuStripOverallQualityPresets.Hide();
            else
                contextMenuStripOverallQualityPresets.Show(buttonSelectOverallQualityPreset, new Point(1, buttonSelectOverallQualityPreset.Height));
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGraphicsPreset(GraphicsPreset.Low);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGraphicsPreset(GraphicsPreset.Medium);
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGraphicsPreset(GraphicsPreset.High);
        }

        private void ultraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGraphicsPreset(GraphicsPreset.Ultra);
        }

        enum GraphicsPreset
        {
            Low,
            Medium,
            High,
            Ultra
        }

        private void LoadGraphicsPreset(GraphicsPreset preset)
        {
            // Load defaults for Medium preset:
            IniFile presetINI = new IniFile(Path.Combine(IniFiles.DefaultsPath, preset.ToString() + ".ini"));
            presetINI.Load();
            presetINI.ClearAllComments();

            // Merge into Fallout76Prefs.ini:
            IniFiles.F76Prefs.Merge(presetINI);

            // Set iGraphicPreset
            string translatedPresetStr = "";
            switch (preset)
            {
                case GraphicsPreset.Low:
                    IniFiles.F76Prefs.Set("Display", "iGraphicPreset", 1);
                    translatedPresetStr = Localization.GetString("lowPreset");
                    break;
                case GraphicsPreset.Medium:
                    IniFiles.F76Prefs.Set("Display", "iGraphicPreset", 2);
                    translatedPresetStr = Localization.GetString("mediumPreset");
                    break;
                case GraphicsPreset.High:
                    IniFiles.F76Prefs.Set("Display", "iGraphicPreset", 3);
                    translatedPresetStr = Localization.GetString("highPreset");
                    break;
                case GraphicsPreset.Ultra:
                    IniFiles.F76Prefs.Set("Display", "iGraphicPreset", 4);
                    translatedPresetStr = Localization.GetString("ultraPreset");
                    break;
            }

            // Reload all values:
            LinkedTweaks.LoadValues();

            // Show messagebox
            MsgBox.Get("iniGraphicsPresetChanged").FormatText(translatedPresetStr).Popup(MessageBoxIcon.Information);
        }

        #endregion
    }
}
