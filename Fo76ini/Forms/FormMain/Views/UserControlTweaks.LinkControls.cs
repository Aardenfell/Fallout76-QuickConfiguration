﻿using Fo76ini.Tweaks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fo76ini.Tweaks.Audio;
using Fo76ini.Tweaks.Camera;
using Fo76ini.Tweaks.Colors;
using Fo76ini.Tweaks.Controls;
using Fo76ini.Tweaks.General;
using Fo76ini.Tweaks.Graphics;
using Fo76ini.Tweaks.Interface;
using Fo76ini.Tweaks.Pipboy;
using Fo76ini.Tweaks.Video;
using Fo76ini.Tweaks.Volume;
using Fo76ini.Tweaks.Graphics.Effects;
using Fo76ini.Tweaks.Accessibility;
using Fo76ini.Tweaks.General.Gameplay;

namespace Fo76ini.Forms.FormMain
{
    /*
     * A bit similar to the *.Designer.cs, adds event handlers to (almost) all controls.
     * That is, instantiate classes that implement ITweak, and link the controls to it's value (among other things).
     */
    public partial class UserControlTweaks : UserControl
    {
        /// <summary>
        /// Adds tooltip information (ITweakInfo)
        /// </summary>
        public void LinkInfo()
        {
            // General tab
            LinkedTweaks.LinkInfo(checkBoxSkipIntroVideos, toolTip, introVideoTweak);
            LinkedTweaks.LinkInfo(checkBoxSkipSplash, toolTip, skipStartupSplash);

            LinkedTweaks.LinkInfo(checkBoxFasterFadeIn, toolTip, fasterFadeInTweak);

            LinkedTweaks.LinkInfo(checkBoxShowDamageNumbers, toolTip, showDamageNumbersAdventureTweak);
            LinkedTweaks.LinkInfo(checkBoxShowPublicTeamNotifications, toolTip, showPublicTeamNotificationsTweak);
            LinkedTweaks.LinkInfo(checkBoxShowFloatingQuestMarkers, toolTip, showFloatingQuestMarkersTweak);
            LinkedTweaks.LinkInfo(checkBoxShowFloatingQuestText, toolTip, showFloatingQuestTextTweak);
            LinkedTweaks.LinkInfo(checkBoxShowCrosshair, toolTip, showCrosshairTweak);
            LinkedTweaks.LinkInfo(checkBoxEnablePowerArmorHUD, toolTip, enablePowerArmorHUDTweak);
            LinkedTweaks.LinkInfo(checkBoxShowCompass, toolTip, showCompassTweak);
            LinkedTweaks.LinkInfo(checkBoxShowOtherPlayersNames, toolTip, showOtherPlayersNamesTweak);
            LinkedTweaks.LinkInfo(checkBoxShowOtherPlayersPings, toolTip, showOtherPlayersPingsTweak);
            LinkedTweaks.LinkInfo(comboBoxShowActiveEffectsOnHUD, toolTip, activeEffectsOnHUDTweak);
            LinkedTweaks.LinkInfo(labelShowActiveEffectsOnHUD, toolTip, activeEffectsOnHUDTweak);
            LinkedTweaks.LinkInfo(comboBoxHighlightCorpses, toolTip, corpseHighlightingTweak);
            LinkedTweaks.LinkInfo(labelHighlightCorpses, toolTip, corpseHighlightingTweak);
            LinkedTweaks.LinkInfo(numFloatingQuestMarkersDistance, toolTip, floatingQuestMarkersDistanceTweak);
            LinkedTweaks.LinkInfo(sliderFloatingQuestMarkersDistance, toolTip, floatingQuestMarkersDistanceTweak);
            LinkedTweaks.LinkInfo(labelFloatingQuestMarkersDistance, toolTip, floatingQuestMarkersDistanceTweak);
            LinkedTweaks.LinkInfo(numHUDOpacity, toolTip, hudOpacityTweak);
            LinkedTweaks.LinkInfo(sliderHUDOpacity, toolTip, hudOpacityTweak);
            LinkedTweaks.LinkInfo(labelHUDOpacity, toolTip, hudOpacityTweak);
            LinkedTweaks.LinkInfo(checkBoxBackpackVisible, toolTip, backpackVisibleTweak);
            LinkedTweaks.LinkInfo(checkBoxAskOpenPerkCardPacks, toolTip, askOpenPerkCardPacksTweak);
            LinkedTweaks.LinkInfo(labelQuickHealStimpakPriority, toolTip, quickHealStimpakPriorityTweak);
            LinkedTweaks.LinkInfo(comboBoxQuickHealStimpakPriority, toolTip, quickHealStimpakPriorityTweak);
            LinkedTweaks.LinkInfo(checkBoxRejectSharedPerks, toolTip, rejectSharedPerksEnabledTweak);
            LinkedTweaks.LinkInfo(labelVATSGrenadeMineTargetingMode, toolTip, vatsGrenadeMineTargetingModeTweak);
            LinkedTweaks.LinkInfo(comboBoxVATSGrenadeMineTargetingMode, toolTip, vatsGrenadeMineTargetingModeTweak);
            LinkedTweaks.LinkInfo(checkBoxAdvancedModDescriptions, toolTip, advancedModDescriptionsTweak);
            LinkedTweaks.LinkInfo(checkBoxAutoScrollPipboyItemStats, toolTip, autoScrollPipboyItemStatsTweak);
            LinkedTweaks.LinkInfo(checkBoxShowCAMPWeather, toolTip, showCAMPWeatherTweak);

            LinkedTweaks.LinkInfo(checkBoxEnableQuestTrackNotification, toolTip, enableQuestTrackNotificationTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableQuestAutoTrackMain, toolTip, autoTrackMainQuestWhenStartedTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableQuestAutoTrackSide, toolTip, autoTrackSideQuestWhenStartedTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableQuestAutoTrackMisc, toolTip, autoTrackMiscQuestWhenStartedTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableQuestAutoTrackEvent, toolTip, autoTrackEventQuestWhenStartedTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableQuestAutoTrackDaily, toolTip, autoTrackOtherQuestWhenStartedTweak);

            // Video tab
            LinkedTweaks.LinkInfo(numCustomResW, toolTip, displaySizeTweak);
            LinkedTweaks.LinkInfo(numCustomResH, toolTip, displaySizeTweak);
            LinkedTweaks.LinkInfo(labelResolution, toolTip, displaySizeTweak);
            LinkedTweaks.LinkInfo(labelCustomResolution, toolTip, displaySizeTweak);
            LinkedTweaks.LinkInfo(comboBoxResolution, toolTip, displaySizeTweak);
            LinkedTweaks.LinkInfo(comboBoxDisplayMode, toolTip, displayModeTweak);
            LinkedTweaks.LinkInfo(labelDisplayMode, toolTip, displayModeTweak);
            LinkedTweaks.LinkInfo(checkBoxVSync, toolTip, presentIntervalTweak);
            LinkedTweaks.LinkInfo(checkBoxTopMostWindow, toolTip, topMostWindowTweak);
            LinkedTweaks.LinkInfo(checkBoxFixHUDFor5_4and4_3, toolTip, fixHUD4to3RatioTweak);

            // Graphics:
            LinkedTweaks.LinkInfo(labelAntiAliasing, toolTip, antiAliasingTweak);
            LinkedTweaks.LinkInfo(comboBoxAntiAliasing, toolTip, antiAliasingTweak);
            LinkedTweaks.LinkInfo(labelAnisotropicFiltering, toolTip, anisotropicFilteringTweak);
            LinkedTweaks.LinkInfo(comboBoxAnisotropicFiltering, toolTip, anisotropicFilteringTweak);
            LinkedTweaks.LinkInfo(labelTextureQuality, toolTip, textureQualityTweak);
            LinkedTweaks.LinkInfo(comboBoxTextureQuality, toolTip, textureQualityTweak);
            LinkedTweaks.LinkInfo(labelShadowQuality, toolTip, shadowQualityTweak);
            LinkedTweaks.LinkInfo(comboBoxShadowQuality, toolTip, shadowQualityTweak);
            LinkedTweaks.LinkInfo(checkBoxDepthOfField, toolTip, dofEnabledTweak);
            LinkedTweaks.LinkInfo(labelDOFStrength, toolTip, dofStrengthTweak);
            LinkedTweaks.LinkInfo(sliderDOFStrength, toolTip, dofStrengthTweak);
            LinkedTweaks.LinkInfo(numDOFStrength, toolTip, dofStrengthTweak);
            LinkedTweaks.LinkInfo(checkBoxMotionBlur, toolTip, motionBlurTweak);
            LinkedTweaks.LinkInfo(checkBoxRadialBlur, toolTip, radialBlurTweak);
            LinkedTweaks.LinkInfo(checkBoxLensFlare, toolTip, lensFlareTweak);
            LinkedTweaks.LinkInfo(checkBoxAmbientOcclusion, toolTip, ambientOcclusionTweak);
            LinkedTweaks.LinkInfo(checkBoxSSReflections, toolTip, screenSpaceReflectionsTweak);
            LinkedTweaks.LinkInfo(checkBoxWaterDisplacement, toolTip, waterDisplacementsTweak);
            LinkedTweaks.LinkInfo(checkBoxWaterRefractions, toolTip, waterRefractionsTweak);
            LinkedTweaks.LinkInfo(checkBoxWaterReflections, toolTip, waterReflectionsTweak);
            LinkedTweaks.LinkInfo(checkBoxWaterHiRes, toolTip, waterHiResTweak);
            LinkedTweaks.LinkInfo(comboBoxWaterShadowFilter, toolTip, waterShadowFilterTweak);
            LinkedTweaks.LinkInfo(labelWaterShadowFilter, toolTip, waterShadowFilterTweak);
            LinkedTweaks.LinkInfo(checkBoxWaterFixSSRGlitch, toolTip, waterFixSSRGlitchTweak);
            LinkedTweaks.LinkInfo(checkBoxGodrays, toolTip, volumetricLightingTweak);
            LinkedTweaks.LinkInfo(labelGodrayQuality, toolTip, volumetricLightingQualityTweak);
            LinkedTweaks.LinkInfo(comboBoxGodrayQuality, toolTip, volumetricLightingQualityTweak);
            LinkedTweaks.LinkInfo(checkBoxDisableGore, toolTip, disableAllGoreTweak);
            LinkedTweaks.LinkInfo(checkBoxBloodSplatter, toolTip, bloodSplatterTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableIntenseWeatherEffects, toolTip, enableIntenseWeatherEffectsTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableMuzzleFlashes, toolTip, enableMuzzleFlashesTweaks);
            LinkedTweaks.LinkInfo(checkBoxEnableWeaponImpactEffects, toolTip, enableWeaponImpactEffectsTweak);
            LinkedTweaks.LinkInfo(labelShadowTextureResolution, toolTip, shadowMapResolutionTweak);
            LinkedTweaks.LinkInfo(comboBoxShadowTextureResolution, toolTip, shadowMapResolutionTweak);
            LinkedTweaks.LinkInfo(comboBoxShadowBlurriness, toolTip, shadowBlurrinessTweak);
            LinkedTweaks.LinkInfo(labelShadowBlurriness, toolTip, shadowBlurrinessTweak);
            LinkedTweaks.LinkInfo(numShadowDistance, toolTip, shadowDistanceTweak);
            LinkedTweaks.LinkInfo(sliderShadowDistance, toolTip, shadowDistanceTweak);
            LinkedTweaks.LinkInfo(numLODObjects, toolTip, lodFadeOutMultObjectsTweak);
            LinkedTweaks.LinkInfo(numLODItems, toolTip, lodFadeOutMultItemsTweak);
            LinkedTweaks.LinkInfo(numLODActors, toolTip, lodFadeOutMultActorsTweak);
            LinkedTweaks.LinkInfo(sliderLODObjects, toolTip, lodFadeOutMultObjectsTweak);
            LinkedTweaks.LinkInfo(sliderLODItems, toolTip, lodFadeOutMultItemsTweak);
            LinkedTweaks.LinkInfo(sliderLODActors, toolTip, lodFadeOutMultActorsTweak);
            LinkedTweaks.LinkInfo(checkBoxGrass, toolTip, enableGrassTweak);
            LinkedTweaks.LinkInfo(numTAAPostOverlay, toolTip, taaPostOverlayTweak);
            LinkedTweaks.LinkInfo(numTAAPostSharpen, toolTip, taaPostSharpenTweak);
            LinkedTweaks.LinkInfo(sliderTAAPostOverlay, toolTip, taaPostOverlayTweak);
            LinkedTweaks.LinkInfo(sliderTAAPostSharpen, toolTip, taaPostSharpenTweak);
            LinkedTweaks.LinkInfo(sliderGrassFadeDistance, toolTip, grassFadeDistanceTweak);
            LinkedTweaks.LinkInfo(numGrassFadeDistance, toolTip, grassFadeDistanceTweak);

            // Audio tab
            LinkedTweaks.LinkInfo(checkBoxEnableAudio, toolTip, enableAudioTweak);
            LinkedTweaks.LinkInfo(checkBoxMainMenuMusic, toolTip, playMainMenuMusicTweak);
            LinkedTweaks.LinkInfo(comboBoxVoiceChatMode, toolTip, voiceChatModeTweak);
            LinkedTweaks.LinkInfo(labelVoiceChatMode, toolTip, voiceChatModeTweak);
            LinkedTweaks.LinkInfo(checkBoxGeneralSubtitles, toolTip, generalSubtitlesTweak);
            LinkedTweaks.LinkInfo(checkBoxDialogueSubtitles, toolTip, dialogueSubtitlesTweak);
            LinkedTweaks.LinkInfo(checkBoxDialogueHistory, toolTip, showDialogueHistoryTweak);
            LinkedTweaks.LinkInfo(checkBoxPushToTalk, toolTip, voicePushToTalkEnabledTweak);
            LinkedTweaks.LinkInfo(numConversationHistorySize, toolTip, conversationHistorySizeTweak);
            LinkedTweaks.LinkInfo(sliderConversationHistorySize, toolTip, conversationHistorySizeTweak);
            LinkedTweaks.LinkInfo(labelConversationHistorySize, toolTip, conversationHistorySizeTweak);
            LinkedTweaks.LinkInfo(numVolumeMaster, toolTip, masterVolumeTweak);
            LinkedTweaks.LinkInfo(numAudioChat, toolTip, vivoxVoiceVolumeTweak);
            LinkedTweaks.LinkInfo(sliderVolumeMaster, toolTip, masterVolumeTweak);
            LinkedTweaks.LinkInfo(sliderAudioChat, toolTip, vivoxVoiceVolumeTweak);

            // Volume:
            LinkedTweaks.LinkInfo(labelVolumeMaster, toolTip, masterVolumeTweak);
            LinkedTweaks.LinkInfo(labelAudioChat, toolTip, vivoxVoiceVolumeTweak);

            LinkedTweaks.LinkInfo(numAudiofVal0, toolTip, val0Tweak);
            LinkedTweaks.LinkInfo(numAudiofVal1, toolTip, val1Tweak);
            LinkedTweaks.LinkInfo(numAudiofVal2, toolTip, val2Tweak);
            LinkedTweaks.LinkInfo(numAudiofVal3, toolTip, val3Tweak);
            LinkedTweaks.LinkInfo(numAudiofVal4, toolTip, val4Tweak);
            LinkedTweaks.LinkInfo(numAudiofVal5, toolTip, val5Tweak);
            LinkedTweaks.LinkInfo(numAudiofVal6, toolTip, val6Tweak);
            LinkedTweaks.LinkInfo(sliderAudiofVal0, toolTip, val0Tweak);
            LinkedTweaks.LinkInfo(sliderAudiofVal1, toolTip, val1Tweak);
            LinkedTweaks.LinkInfo(sliderAudiofVal2, toolTip, val2Tweak);
            LinkedTweaks.LinkInfo(sliderAudiofVal3, toolTip, val3Tweak);
            LinkedTweaks.LinkInfo(sliderAudiofVal4, toolTip, val4Tweak);
            LinkedTweaks.LinkInfo(sliderAudiofVal5, toolTip, val5Tweak);
            LinkedTweaks.LinkInfo(sliderAudiofVal6, toolTip, val6Tweak);
            LinkedTweaks.LinkInfo(labelAudiofVal0, toolTip, val0Tweak);
            LinkedTweaks.LinkInfo(labelAudiofVal1, toolTip, val1Tweak);
            LinkedTweaks.LinkInfo(labelAudiofVal2, toolTip, val2Tweak);
            LinkedTweaks.LinkInfo(labelAudiofVal3, toolTip, val3Tweak);
            LinkedTweaks.LinkInfo(labelAudiofVal4, toolTip, val4Tweak);
            LinkedTweaks.LinkInfo(labelAudiofVal5, toolTip, val5Tweak);
            LinkedTweaks.LinkInfo(labelAudiofVal6, toolTip, val6Tweak);

            // Controls tab
            LinkedTweaks.LinkInfo(numMouseSensitivityX, toolTip, mouseSensitivityTweakX);
            LinkedTweaks.LinkInfo(sliderMouseSensitivityX, toolTip, mouseSensitivityTweakX);
            LinkedTweaks.LinkInfo(numGamepadSensitivityX, toolTip, gamepadSensitivityTweakX);
            LinkedTweaks.LinkInfo(sliderGamepadSensitivityX, toolTip, gamepadSensitivityTweakX);
            LinkedTweaks.LinkInfo(numMouseSensitivityY, toolTip, mouseSensitivityTweakY);
            LinkedTweaks.LinkInfo(sliderMouseSensitivityY, toolTip, mouseSensitivityTweakY);
            LinkedTweaks.LinkInfo(numGamepadSensitivityY, toolTip, gamepadSensitivityTweakY);
            LinkedTweaks.LinkInfo(sliderGamepadSensitivityY, toolTip, gamepadSensitivityTweakY);
            LinkedTweaks.LinkInfo(checkBoxFixMouseSensitivity, toolTip, fixMouseSensitivityTweak);
            LinkedTweaks.LinkInfo(checkBoxFixAimSensitivity, toolTip, fixAimSensitivityTweak);
            LinkedTweaks.LinkInfo(checkBoxMouseInvertX, toolTip, mouseInvertXTweak);
            LinkedTweaks.LinkInfo(checkBoxMouseInvertY, toolTip, mouseInvertYTweak);
            LinkedTweaks.LinkInfo(checkBoxToggleAim, toolTip, toggleAimTweak);
            LinkedTweaks.LinkInfo(checkBoxGamepadEnabled, toolTip, gamepadEnableTweak);
            LinkedTweaks.LinkInfo(checkBoxGamepadRumble, toolTip, enableGamepadRumbleTweak);
            LinkedTweaks.LinkInfo(checkBoxAimAssist, toolTip, aimAssistTweak);

            // Camera tab
            LinkedTweaks.LinkInfo(this.checkBoxbApplyCameraNodeAnimations, toolTip, applyCameraNodeAnimationsTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderPosX, toolTip, cameraOverShoulderPosXTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderPosZ, toolTip, cameraOverShoulderPosZTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderCombatPosX, toolTip, cameraOverShoulderCombatPosXTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderCombatPosZ, toolTip, cameraOverShoulderCombatPosZTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderCombatAddY, toolTip, cameraOverShoulderCombatAddYTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderMeleeCombatPosX, toolTip, cameraOverShoulderMeleeCombatPosXTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderMeleeCombatPosZ, toolTip, cameraOverShoulderMeleeCombatPosZTweak);
            LinkedTweaks.LinkInfo(this.numfOverShoulderMeleeCombatAddY, toolTip, cameraOverShoulderMeleeCombatAddYTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderPosX, toolTip, cameraOverShoulderPosXTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderPosZ, toolTip, cameraOverShoulderPosZTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderCombatPosX, toolTip, cameraOverShoulderCombatPosXTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderCombatPosZ, toolTip, cameraOverShoulderCombatPosZTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderCombatAddY, toolTip, cameraOverShoulderCombatAddYTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderMeleeCombatPosX, toolTip, cameraOverShoulderMeleeCombatPosXTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderMeleeCombatPosZ, toolTip, cameraOverShoulderMeleeCombatPosZTweak);
            LinkedTweaks.LinkInfo(this.trackBarfOverShoulderMeleeCombatAddY, toolTip, cameraOverShoulderMeleeCombatAddYTweak);
            LinkedTweaks.LinkInfo(this.numericUpDownPhotomodeRange, toolTip, selfieModeRangeTweak);
            LinkedTweaks.LinkInfo(this.numericUpDownPhotomodeTranslationSpeed, toolTip, selfieCameraTranslationSpeedTweak);
            LinkedTweaks.LinkInfo(this.numericUpDownPhotomodeRotationSpeed, toolTip, selfieCameraRotationSpeedTweak);
            LinkedTweaks.LinkInfo(this.labelPhotomodeRange, toolTip, selfieModeRangeTweak);
            LinkedTweaks.LinkInfo(this.labelPhotomodeTranslationSpeed, toolTip, selfieCameraTranslationSpeedTweak);
            LinkedTweaks.LinkInfo(this.labelPhotomodeRotationSpeed, toolTip, selfieCameraRotationSpeedTweak);
            LinkedTweaks.LinkInfo(this.trackBarPhotomodeRange, toolTip, selfieModeRangeTweak);
            LinkedTweaks.LinkInfo(this.trackBarPhotomodeTranslationSpeed, toolTip, selfieCameraTranslationSpeedTweak);
            LinkedTweaks.LinkInfo(this.trackBarPhotomodeRotationSpeed, toolTip, selfieCameraRotationSpeedTweak);
            LinkedTweaks.LinkInfo(this.checkBoxVanityMode, toolTip, disableAutoVanityModeTweak);
            LinkedTweaks.LinkInfo(this.checkBoxForceVanityMode, toolTip, forceAutoVanityModeTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableCameraShake, toolTip, enableCameraShakeTweak);
            LinkedTweaks.LinkInfo(numADSFOV, toolTip, fov3rdADSTweak);
            LinkedTweaks.LinkInfo(numFOV, toolTip, fovTweak);
            LinkedTweaks.LinkInfo(sliderFOV, toolTip, fovTweak);
            LinkedTweaks.LinkInfo(numViewmodelFOV, toolTip, fov1stPersonTweak);
            LinkedTweaks.LinkInfo(sliderViewmodelFOV, toolTip, fov1stPersonTweak);
            LinkedTweaks.LinkInfo(labelADSFOV, toolTip, fov3rdADSTweak);
            LinkedTweaks.LinkInfo(numCameraDistanceMinimum, toolTip, vanityModeMinDistTweak);
            LinkedTweaks.LinkInfo(numCameraDistanceMaximum, toolTip, vanityModeMaxDistTweak);
            LinkedTweaks.LinkInfo(numfPitchZoomOutMaxDist, toolTip, pitchZoomOutMaxDistTweak);
            LinkedTweaks.LinkInfo(labelCameraDistanceMinimum, toolTip, vanityModeMinDistTweak);
            LinkedTweaks.LinkInfo(labelCameraDistanceMaximum, toolTip, vanityModeMaxDistTweak);
            LinkedTweaks.LinkInfo(labelPitchZoomOutMaxDist, toolTip, pitchZoomOutMaxDistTweak);
            LinkedTweaks.LinkInfo(sliderCameraDistanceMinimum, toolTip, vanityModeMinDistTweak);
            LinkedTweaks.LinkInfo(sliderCameraDistanceMaximum, toolTip, vanityModeMaxDistTweak);
            LinkedTweaks.LinkInfo(sliderfPitchZoomOutMaxDist, toolTip, pitchZoomOutMaxDistTweak);

            LinkedTweaks.LinkInfo(checkBoxWorkshopFreeCameraControlsHoldToggle, toolTip, workshopFreeCameraControlsHoldToggleTweak);
            LinkedTweaks.LinkInfo(labelFreeCamRotationSpeed, toolTip, workshopFreeCameraRotationSpeedTweak);
            LinkedTweaks.LinkInfo(labelFreeCamMovementSpeed, toolTip, workshopFreeCameraTranslationSpeedTweak);
            LinkedTweaks.LinkInfo(trackBarFreeCamRotationSpeed, toolTip, workshopFreeCameraRotationSpeedTweak);
            LinkedTweaks.LinkInfo(trackBarFreeCamMovementSpeed, toolTip, workshopFreeCameraTranslationSpeedTweak);
            LinkedTweaks.LinkInfo(checkBoxWorkshopFreeCameraStartAtPreviousLocation, toolTip, workshopStartAtPreviousFreeCameraLocationTweak);
            LinkedTweaks.LinkInfo(checkBoxWorkshopStartInFreeCamera, toolTip, workshopStartInFreeCameraTweak);

            // Accessibility
            LinkedTweaks.LinkInfo(labelAlternativeNoteViewBackgroundColor, toolTip, alternativeNoteViewBackgroundColorTweak);
            LinkedTweaks.LinkInfo(buttonPickAlternativeNoteViewBackgroundColor, toolTip, alternativeNoteViewBackgroundColorTweak);
            LinkedTweaks.LinkInfo(buttonResetAlternativeNoteViewBackgroundColor, toolTip, alternativeNoteViewBackgroundColorTweak);
            LinkedTweaks.LinkInfo(colorPreviewAlternativeNoteViewBackgroundColor, toolTip, alternativeNoteViewBackgroundColorTweak);

            LinkedTweaks.LinkInfo(labelAlternativeNoteViewTextColor, toolTip, alternativeNoteViewTextColorTweak);
            LinkedTweaks.LinkInfo(buttonPickAlternativeNoteViewTextColor, toolTip, alternativeNoteViewTextColorTweak);
            LinkedTweaks.LinkInfo(buttonResetAlternativeNoteViewTextColor, toolTip, alternativeNoteViewTextColorTweak);
            LinkedTweaks.LinkInfo(colorPreviewAlternativeNoteViewTextColor, toolTip, alternativeNoteViewTextColorTweak);

            LinkedTweaks.LinkInfo(labelMessageWindowFadeTime, toolTip, messageWindowFadeTimeTweak);
            LinkedTweaks.LinkInfo(trackBarMessageWindowFadeTime, toolTip, messageWindowFadeTimeTweak);

            LinkedTweaks.LinkInfo(labelMessageWindowVisibility, toolTip, messageWindowFadeAmountTweak);
            LinkedTweaks.LinkInfo(trackBarMessageWindowVisibility, toolTip, messageWindowFadeAmountTweak);

            LinkedTweaks.LinkInfo(checkBoxScreenNarration, toolTip, screenNarrationEnabledTweak);
            LinkedTweaks.LinkInfo(labelScreenNarrationVoiceType, toolTip, screenNarrationVoiceTypeTweak);
            LinkedTweaks.LinkInfo(comboBoxScreenNarrationVoiceType, toolTip, screenNarrationVoiceTypeTweak);

            LinkedTweaks.LinkInfo(checkBoxShowAccessibilityScreenOnStart, toolTip, showAccessibilityScreenOnStartTweak);
            LinkedTweaks.LinkInfo(checkBoxSingleButtonNotificationCancel, toolTip, singleButtonNotificationCancelTweak);
            LinkedTweaks.LinkInfo(checkBoxSpeechToText, toolTip, speechToTextTweak);
            LinkedTweaks.LinkInfo(checkBoxEnableLargerAlternativeNoteViewText, toolTip, useLargeEasyReadTextTweak);
        }

        /// <summary>
        /// Links trackbars to numericupdowns (and vice-versa)
        /// </summary>
        public void LinkSliders()
        {
            // Link numericUpDown and sliders:
            LinkedTweaks.LinkSlider(this.sliderGrassFadeDistance, this.numGrassFadeDistance, 1);
            //LinkSlider(this.sliderGrassDensity, this.numGrassDensity, 1, true);
            LinkedTweaks.LinkSlider(this.sliderDOFStrength, this.numDOFStrength, 10f);
            LinkedTweaks.LinkSlider(this.sliderLODObjects, this.numLODObjects, 10);
            LinkedTweaks.LinkSlider(this.sliderLODItems, this.numLODItems, 10);
            LinkedTweaks.LinkSlider(this.sliderLODActors, this.numLODActors, 10);
            LinkedTweaks.LinkSlider(this.sliderShadowDistance, this.numShadowDistance, 1);
            LinkedTweaks.LinkSlider(this.sliderMouseSensitivityX, this.numMouseSensitivityX, 10000.0);
            LinkedTweaks.LinkSlider(this.sliderMouseSensitivityY, this.numMouseSensitivityY, 10000.0);
            LinkedTweaks.LinkSlider(this.sliderGamepadSensitivityX, this.numGamepadSensitivityX, 10000.0);
            LinkedTweaks.LinkSlider(this.sliderGamepadSensitivityY, this.numGamepadSensitivityY, 10000.0);
            LinkedTweaks.LinkSlider(this.sliderTAAPostOverlay, this.numTAAPostOverlay, 100);
            LinkedTweaks.LinkSlider(this.sliderTAAPostSharpen, this.numTAAPostSharpen, 100);

            LinkedTweaks.LinkSlider(this.sliderVolumeMaster, this.numVolumeMaster, 100);
            LinkedTweaks.LinkSlider(this.sliderAudioChat, this.numAudioChat, 1);
            LinkedTweaks.LinkSlider(this.sliderAudiofVal0, this.numAudiofVal0, 100);
            LinkedTweaks.LinkSlider(this.sliderAudiofVal1, this.numAudiofVal1, 100);
            LinkedTweaks.LinkSlider(this.sliderAudiofVal2, this.numAudiofVal2, 100);
            LinkedTweaks.LinkSlider(this.sliderAudiofVal3, this.numAudiofVal3, 100);
            LinkedTweaks.LinkSlider(this.sliderAudiofVal4, this.numAudiofVal4, 100);
            LinkedTweaks.LinkSlider(this.sliderAudiofVal5, this.numAudiofVal5, 100);
            LinkedTweaks.LinkSlider(this.sliderAudiofVal6, this.numAudiofVal6, 100);

            LinkedTweaks.LinkSlider(this.sliderFloatingQuestMarkersDistance, this.numFloatingQuestMarkersDistance, 10);
            LinkedTweaks.LinkSlider(this.sliderConversationHistorySize, this.numConversationHistorySize, 1);
            LinkedTweaks.LinkSlider(this.sliderHUDOpacity, this.numHUDOpacity, 100);

            LinkedTweaks.LinkSlider(this.sliderCameraDistanceMinimum, this.numCameraDistanceMinimum, 1);
            LinkedTweaks.LinkSlider(this.sliderCameraDistanceMaximum, this.numCameraDistanceMaximum, 1);
            LinkedTweaks.LinkSlider(this.sliderfPitchZoomOutMaxDist, this.numfPitchZoomOutMaxDist, 1);

            LinkedTweaks.LinkSlider(this.trackBarPhotomodeTranslationSpeed, this.numericUpDownPhotomodeTranslationSpeed, 10);
            LinkedTweaks.LinkSlider(this.trackBarPhotomodeRotationSpeed, this.numericUpDownPhotomodeRotationSpeed, 10);
            LinkedTweaks.LinkSlider(this.trackBarPhotomodeRange, this.numericUpDownPhotomodeRange, 1);


            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderPosX, this.numfOverShoulderPosX, 1);
            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderPosZ, this.numfOverShoulderPosZ, 1);
            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderCombatPosX, this.numfOverShoulderCombatPosX, 1);
            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderCombatPosZ, this.numfOverShoulderCombatPosZ, 1);
            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderCombatAddY, this.numfOverShoulderCombatAddY, 1);
            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderMeleeCombatPosX, this.numfOverShoulderMeleeCombatPosX, 1);
            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderMeleeCombatPosZ, this.numfOverShoulderMeleeCombatPosZ, 1);
            LinkedTweaks.LinkSlider(this.trackBarfOverShoulderMeleeCombatAddY, this.numfOverShoulderMeleeCombatAddY, 1);

            LinkedTweaks.LinkSlider(this.trackBarFreeCamRotationSpeed, this.numericUpDownFreeCamRotationSpeed, 1);
            LinkedTweaks.LinkSlider(this.trackBarFreeCamMovementSpeed, this.numericUpDownFreeCamMovementSpeed, 1);
            LinkedTweaks.LinkSlider(this.trackBarMessageWindowFadeTime, this.numericUpDownMessageWindowFadeTime, 1);
            LinkedTweaks.LinkSlider(this.trackBarMessageWindowVisibility, this.numericUpDownMessageWindowVisibility, 1);
        }

        /// <summary>
        /// Link controls to tweaks, that means:
        /// -> If a control's value changes, change the value of a tweak.
        /// -> If the UI is being (re)loaded, set each value according to that of the linked tweak.
        /// </summary>
        public void LinkControlsToTweaks()
        {
            /*
             * General tab
             */

            // Skip intro videos
            LinkedTweaks.LinkTweakNegated(checkBoxSkipIntroVideos, introVideoTweak);


            // Faster fade in
            LinkedTweaks.LinkTweak(checkBoxFasterFadeIn, fasterFadeInTweak);


            // Show splash screen with news on startup
            LinkedTweaks.LinkTweak(checkBoxSkipSplash, skipStartupSplash);

            // Show damage numbers in Adventure mode
            LinkedTweaks.LinkTweak(checkBoxShowDamageNumbers, showDamageNumbersAdventureTweak);

            // Show Public Team Notifications
            LinkedTweaks.LinkTweak(checkBoxShowPublicTeamNotifications, showPublicTeamNotificationsTweak);

            // Show Floating Quest Markers
            LinkedTweaks.LinkTweak(checkBoxShowFloatingQuestMarkers, showFloatingQuestMarkersTweak);

            // Show Floating Quest Text
            LinkedTweaks.LinkTweak(checkBoxShowFloatingQuestText, showFloatingQuestTextTweak);

            // Show crosshair
            LinkedTweaks.LinkTweak(checkBoxShowCrosshair, showCrosshairTweak);

            // Enable Power Armor HUD
            LinkedTweaks.LinkTweak(checkBoxEnablePowerArmorHUD, enablePowerArmorHUDTweak);

            // Show compass
            LinkedTweaks.LinkTweak(checkBoxShowCompass, showCompassTweak);

            // Show Other Players' Names
            LinkedTweaks.LinkTweak(checkBoxShowOtherPlayersNames, showOtherPlayersNamesTweak);

            // Show Other Players' Pings
            LinkedTweaks.LinkTweak(checkBoxShowOtherPlayersPings, showOtherPlayersPingsTweak);

            // Show active effects on HUD
            LinkedTweaks.LinkTweak(comboBoxShowActiveEffectsOnHUD, activeEffectsOnHUDTweak);

            // Highlight corpses
            LinkedTweaks.LinkTweak(comboBoxHighlightCorpses, corpseHighlightingTweak);

            // Floating Quest Markers Draw Distance
            LinkedTweaks.LinkTweak(numFloatingQuestMarkersDistance, floatingQuestMarkersDistanceTweak);

            // HUD Opacity
            LinkedTweaks.LinkTweak(numHUDOpacity, hudOpacityTweak);

            // Backpack visible
            LinkedTweaks.LinkTweak(checkBoxBackpackVisible, backpackVisibleTweak);


            // XYZ Quest Active when started
            LinkedTweaks.LinkTweak(checkBoxEnableQuestTrackNotification, enableQuestTrackNotificationTweak);
            LinkedTweaks.LinkTweak(checkBoxEnableQuestAutoTrackMain, autoTrackMainQuestWhenStartedTweak);
            LinkedTweaks.LinkTweak(checkBoxEnableQuestAutoTrackSide, autoTrackSideQuestWhenStartedTweak);
            LinkedTweaks.LinkTweak(checkBoxEnableQuestAutoTrackMisc, autoTrackMiscQuestWhenStartedTweak);
            LinkedTweaks.LinkTweak(checkBoxEnableQuestAutoTrackEvent, autoTrackEventQuestWhenStartedTweak);
            LinkedTweaks.LinkTweak(checkBoxEnableQuestAutoTrackDaily, autoTrackOtherQuestWhenStartedTweak);

            LinkedTweaks.LinkTweak(checkBoxAskOpenPerkCardPacks, askOpenPerkCardPacksTweak);
            LinkedTweaks.LinkTweak(comboBoxQuickHealStimpakPriority, quickHealStimpakPriorityTweak);
            LinkedTweaks.LinkTweak(checkBoxRejectSharedPerks, rejectSharedPerksEnabledTweak);
            LinkedTweaks.LinkTweak(comboBoxVATSGrenadeMineTargetingMode, vatsGrenadeMineTargetingModeTweak);
            LinkedTweaks.LinkTweak(checkBoxAdvancedModDescriptions, advancedModDescriptionsTweak);
            LinkedTweaks.LinkTweak(checkBoxAutoScrollPipboyItemStats, autoScrollPipboyItemStatsTweak);
            LinkedTweaks.LinkTweak(checkBoxShowCAMPWeather, showCAMPWeatherTweak);


            /*
             * Video tab
             */

            // Custom resolution
            LinkedTweaks.LinkSize(numCustomResW, numCustomResH, displaySizeTweak);

            // Display mode
            LinkedTweaks.LinkTweak(comboBoxDisplayMode, displayModeTweak);

            // iPresentInterval
            LinkedTweaks.LinkTweak(checkBoxVSync, presentIntervalTweak);

            // Top most window
            LinkedTweaks.LinkTweak(checkBoxTopMostWindow, topMostWindowTweak);

            // Fix HUD for 5:4 and 4:3 screens
            LinkedTweaks.LinkTweak(checkBoxFixHUDFor5_4and4_3, fixHUD4to3RatioTweak);



            /*
             * Graphics
             */

            // Graphics preset label
            LinkedTweaks.AddSetValueAction(() =>
            {
                string preset = "Unknown";
                switch (IniFiles.GetInt("Display", "iGraphicPreset", 0))
                {
                    case 0:
                        preset = Localization.GetString("customPreset");
                        break;
                    case 1:
                        preset = Localization.GetString("lowPreset");
                        break;
                    case 2:
                        preset = Localization.GetString("mediumPreset");
                        break;
                    case 3:
                        preset = Localization.GetString("highPreset");
                        break;
                    case 4:
                        preset = Localization.GetString("ultraPreset");
                        break;
                    default:
                        preset = $"Unknown ({IniFiles.GetInt("Display", "iGraphicPreset", 0)})";
                        break;
                }
                this.labelSelectedQualityPreset.Text = String.Format(Localization.GetString("currentPreset"), preset);
            });

            // Anti aliasing
            LinkedTweaks.LinkTweak(comboBoxAntiAliasing, antiAliasingTweak);

            // Anisotropic filtering
            LinkedTweaks.LinkTweak(
                comboBoxAnisotropicFiltering,
                new int[] { 0, 2, 4, 8, 16 },
                anisotropicFilteringTweak);

            // Texture quality
            LinkedTweaks.LinkTweak(comboBoxTextureQuality, textureQualityTweak);

            // Enable Depth of Field
            LinkedTweaks.LinkTweak(checkBoxDepthOfField, dofEnabledTweak);

            // Depth of Field Strength
            LinkedTweaks.LinkTweak(numDOFStrength, dofStrengthTweak);

            // Motion Blur
            LinkedTweaks.LinkTweak(checkBoxMotionBlur, motionBlurTweak);

            // Radial Blur
            LinkedTweaks.LinkTweak(checkBoxRadialBlur, radialBlurTweak);

            // Lens Flare
            LinkedTweaks.LinkTweak(checkBoxLensFlare, lensFlareTweak);

            // Ambient Occlusion
            LinkedTweaks.LinkTweak(checkBoxAmbientOcclusion, ambientOcclusionTweak);

            // Screen space reflections
            LinkedTweaks.LinkTweak(checkBoxSSReflections, screenSpaceReflectionsTweak);

            // Water / Displacement
            LinkedTweaks.LinkTweak(checkBoxWaterDisplacement, waterDisplacementsTweak);

            // Water / Refractions
            LinkedTweaks.LinkTweak(checkBoxWaterRefractions, waterRefractionsTweak);

            // Water / Reflections
            LinkedTweaks.LinkTweak(checkBoxWaterReflections, waterReflectionsTweak);

            // Water / HiRes
            LinkedTweaks.LinkTweak(checkBoxWaterHiRes, waterHiResTweak);

            // Water / Shadow filter
            LinkedTweaks.LinkTweak(
                comboBoxWaterShadowFilter,
                new int[] { 1, 2, 3 },
                waterShadowFilterTweak);

            // Water / Fix SSR glitch
            LinkedTweaks.LinkTweak(checkBoxWaterFixSSRGlitch, waterFixSSRGlitchTweak);

            // Lighting / Volumetric Lighting
            LinkedTweaks.LinkTweak(checkBoxGodrays, volumetricLightingTweak);

            // Lighting / Volumetric Lighting Quality
            LinkedTweaks.LinkTweak(
                comboBoxGodrayQuality,
                new int[] { 0, 1, 2 },
                volumetricLightingQualityTweak);

            // Effects / Disable gore
            LinkedTweaks.LinkTweak(checkBoxDisableGore, disableAllGoreTweak);

            // Effects / Blood splatter
            LinkedTweaks.LinkTweak(checkBoxBloodSplatter, bloodSplatterTweak);

            // Effects
            LinkedTweaks.LinkTweak(checkBoxEnableIntenseWeatherEffects, enableIntenseWeatherEffectsTweak);
            LinkedTweaks.LinkTweak(checkBoxEnableMuzzleFlashes, enableMuzzleFlashesTweaks);
            LinkedTweaks.LinkTweak(checkBoxEnableWeaponImpactEffects, enableWeaponImpactEffectsTweak);

            // Shadow quality
            LinkedTweaks.LinkTweak(comboBoxShadowQuality, shadowQualityTweak);

            // Shadow texture map resolution
            LinkedTweaks.LinkTweak(
                comboBoxShadowTextureResolution,
                new int[] { 512, 1024, 2048, 4096, 8192 },
                shadowMapResolutionTweak);

            // Shadows / Blurriness
            LinkedTweaks.LinkTweak(
                comboBoxShadowBlurriness,
                new int[] { 0, 1, 2, 3 },
                shadowBlurrinessTweak);

            // Shadow distance
            LinkedTweaks.LinkTweak(numShadowDistance, shadowDistanceTweak);

            // Enable grass
            LinkedTweaks.LinkTweak(checkBoxGrass, enableGrassTweak);

            // Grass fade distance
            LinkedTweaks.LinkTweak(numGrassFadeDistance, grassFadeDistanceTweak);

            // LOD Fade Distances
            LinkedTweaks.LinkTweak(numLODObjects, lodFadeOutMultObjectsTweak);
            LinkedTweaks.LinkTweak(numLODItems, lodFadeOutMultItemsTweak);
            LinkedTweaks.LinkTweak(numLODActors, lodFadeOutMultActorsTweak);

            // TAA Sharpening
            LinkedTweaks.LinkTweak(numTAAPostOverlay, taaPostOverlayTweak);
            LinkedTweaks.LinkTweak(numTAAPostSharpen, taaPostSharpenTweak);



            /*
             * Audio tab
             */

            // Enable audio
            LinkedTweaks.LinkTweak(checkBoxEnableAudio, enableAudioTweak);

            // Play music in main menu
            LinkedTweaks.LinkTweak(checkBoxMainMenuMusic, playMainMenuMusicTweak);


            // Voice Chat Mode
            LinkedTweaks.LinkTweak(comboBoxVoiceChatMode, voiceChatModeTweak);

            // Push-To-Talk
            LinkedTweaks.LinkTweak(checkBoxPushToTalk, voicePushToTalkEnabledTweak);


            // General subtitles
            LinkedTweaks.LinkTweak(checkBoxGeneralSubtitles, generalSubtitlesTweak);

            // Dialogue subtitles
            LinkedTweaks.LinkTweak(checkBoxDialogueSubtitles, dialogueSubtitlesTweak);

            // Dialogue history
            LinkedTweaks.LinkTweak(checkBoxDialogueHistory, showDialogueHistoryTweak);

            // Conversation History Size
            LinkedTweaks.LinkTweak(numConversationHistorySize, conversationHistorySizeTweak);


            // Master volume
            LinkedTweaks.LinkTweak(numVolumeMaster, masterVolumeTweak);

            // Voice chat volume
            LinkedTweaks.LinkTweak(numAudioChat, vivoxVoiceVolumeTweak);

            // Audio menu:
            LinkedTweaks.LinkTweak(numAudiofVal0, val0Tweak);
            LinkedTweaks.LinkTweak(numAudiofVal1, val1Tweak);
            LinkedTweaks.LinkTweak(numAudiofVal2, val2Tweak);
            LinkedTweaks.LinkTweak(numAudiofVal3, val3Tweak);
            LinkedTweaks.LinkTweak(numAudiofVal4, val4Tweak);
            LinkedTweaks.LinkTweak(numAudiofVal5, val5Tweak);
            LinkedTweaks.LinkTweak(numAudiofVal6, val6Tweak);



            /*
             * Controls tab
             */

            // Mouse sensitivity
            LinkedTweaks.LinkTweak(numMouseSensitivityX, mouseSensitivityTweakX);
            LinkedTweaks.LinkTweak(numMouseSensitivityY, mouseSensitivityTweakY);

            // Fix mouse sensitivity
            LinkedTweaks.LinkTweak(checkBoxFixMouseSensitivity, fixMouseSensitivityTweak);

            // Fix aim sensitivity
            LinkedTweaks.LinkTweak(checkBoxFixAimSensitivity, fixAimSensitivityTweak);

            // Invert mouse:
            LinkedTweaks.LinkTweak(checkBoxMouseInvertX, mouseInvertXTweak);
            LinkedTweaks.LinkTweak(checkBoxMouseInvertY, mouseInvertYTweak);

            // Toggle Aim
            LinkedTweaks.LinkTweak(checkBoxToggleAim, toggleAimTweak);

            // Gamepad sensitivity
            LinkedTweaks.LinkTweak(numGamepadSensitivityX, gamepadSensitivityTweakX);
            LinkedTweaks.LinkTweak(numGamepadSensitivityY, gamepadSensitivityTweakY);

            // Gamepad enabled
            LinkedTweaks.LinkTweak(checkBoxGamepadEnabled, gamepadEnableTweak);

            // Vibration
            LinkedTweaks.LinkTweak(checkBoxGamepadRumble, enableGamepadRumbleTweak);

            // Aim Assist
            LinkedTweaks.LinkTweak(checkBoxAimAssist, aimAssistTweak);



            /*
             * Camera tab
             */

            // Field of View
            LinkedTweaks.LinkSlider(sliderFOV, numFOV, 0.2f);
            LinkedTweaks.LinkTweak(numFOV, fovTweak);

            // Field of View
            LinkedTweaks.LinkSlider(sliderViewmodelFOV, numViewmodelFOV, 0.2f);
            LinkedTweaks.LinkTweak(numViewmodelFOV, fov1stPersonTweak);

            // 3rd person ADS FOV
            LinkedTweaks.LinkTweak(numADSFOV, fov3rdADSTweak);

            // Enable Camera Shake
            LinkedTweaks.LinkTweak(checkBoxEnableCameraShake, enableCameraShakeTweak);

            // Camera distance
            LinkedTweaks.LinkTweak(numCameraDistanceMinimum, vanityModeMinDistTweak);
            LinkedTweaks.LinkTweak(numCameraDistanceMaximum, vanityModeMaxDistTweak);

            // fPitchZoomOutMaxDist
            LinkedTweaks.LinkTweak(numfPitchZoomOutMaxDist, pitchZoomOutMaxDistTweak);

            // Photomode options:
            LinkedTweaks.LinkTweak(this.numericUpDownPhotomodeRange, selfieModeRangeTweak);
            LinkedTweaks.LinkTweak(this.numericUpDownPhotomodeTranslationSpeed, selfieCameraTranslationSpeedTweak);
            LinkedTweaks.LinkTweak(this.numericUpDownPhotomodeRotationSpeed, selfieCameraRotationSpeedTweak);

            // Vanity mode
            LinkedTweaks.LinkTweakNegated(this.checkBoxVanityMode, disableAutoVanityModeTweak);
            LinkedTweaks.LinkTweak(this.checkBoxForceVanityMode, forceAutoVanityModeTweak);

            // bApplyCameraNodeAnimations
            LinkedTweaks.LinkTweak(this.checkBoxbApplyCameraNodeAnimations, applyCameraNodeAnimationsTweak);

            // OverShoulder sliders:
            LinkedTweaks.LinkTweak(this.numfOverShoulderPosX, cameraOverShoulderPosXTweak);
            LinkedTweaks.LinkTweak(this.numfOverShoulderPosZ, cameraOverShoulderPosZTweak);
            LinkedTweaks.LinkTweak(this.numfOverShoulderCombatPosX, cameraOverShoulderCombatPosXTweak);
            LinkedTweaks.LinkTweak(this.numfOverShoulderCombatPosZ, cameraOverShoulderCombatPosZTweak);
            LinkedTweaks.LinkTweak(this.numfOverShoulderCombatAddY, cameraOverShoulderCombatAddYTweak);
            LinkedTweaks.LinkTweak(this.numfOverShoulderMeleeCombatPosX, cameraOverShoulderMeleeCombatPosXTweak);
            LinkedTweaks.LinkTweak(this.numfOverShoulderMeleeCombatPosZ, cameraOverShoulderMeleeCombatPosZTweak);
            LinkedTweaks.LinkTweak(this.numfOverShoulderMeleeCombatAddY, cameraOverShoulderMeleeCombatAddYTweak);

            // Workshop Free Camera:
            LinkedTweaks.LinkTweak(this.checkBoxWorkshopFreeCameraControlsHoldToggle, workshopFreeCameraControlsHoldToggleTweak);
            LinkedTweaks.LinkTweak(this.numericUpDownFreeCamRotationSpeed, workshopFreeCameraRotationSpeedTweak);
            LinkedTweaks.LinkTweak(this.numericUpDownFreeCamMovementSpeed, workshopFreeCameraTranslationSpeedTweak);
            LinkedTweaks.LinkTweak(this.checkBoxWorkshopFreeCameraStartAtPreviousLocation, workshopStartAtPreviousFreeCameraLocationTweak);
            LinkedTweaks.LinkTweak(this.checkBoxWorkshopStartInFreeCamera, workshopStartInFreeCameraTweak);



            /*
             * Accessibility tab
             */

            LinkedTweaks.LinkTweak(this.numericUpDownMessageWindowFadeTime, messageWindowFadeTimeTweak);
            LinkedTweaks.LinkTweak(this.numericUpDownMessageWindowVisibility, messageWindowFadeAmountTweak);
            LinkedTweaks.LinkTweak(this.checkBoxScreenNarration, screenNarrationEnabledTweak);
            LinkedTweaks.LinkTweak(this.comboBoxScreenNarrationVoiceType, screenNarrationVoiceTypeTweak);
            LinkedTweaks.LinkTweak(this.checkBoxShowAccessibilityScreenOnStart, showAccessibilityScreenOnStartTweak);
            LinkedTweaks.LinkTweak(this.checkBoxSingleButtonNotificationCancel, singleButtonNotificationCancelTweak);
            LinkedTweaks.LinkTweak(this.checkBoxSpeechToText, speechToTextTweak);
            LinkedTweaks.LinkTweak(this.checkBoxEnableLargerAlternativeNoteViewText, useLargeEasyReadTextTweak);

            // Alternative Note View Text Color:
            LinkedTweaks.LinkColor(
                buttonPickAlternativeNoteViewTextColor,   // "Pick color" button
                buttonResetAlternativeNoteViewTextColor,  // "Reset" button
                colorDialog,                              // The color picking dialog that should open when clicking on "Pick color"
                colorPreviewAlternativeNoteViewTextColor, // The colored square that is left to the label.
                alternativeNoteViewTextColorTweak);

            // Alternative Note View Background Color:
            LinkedTweaks.LinkColor(
                buttonPickAlternativeNoteViewBackgroundColor,
                buttonResetAlternativeNoteViewBackgroundColor,
                colorDialog,
                colorPreviewAlternativeNoteViewBackgroundColor,
                alternativeNoteViewBackgroundColorTweak);
        }


        /*
         * Define and instantiate all tweaks:
         */

        // General tab
        private EnableSteamTweak enableSteamTweak = new EnableSteamTweak();
        private AutoSigninTweak autoSigninTweak = new AutoSigninTweak();
        private IntroVideoTweak introVideoTweak = new IntroVideoTweak();
        private SkipStartupSplash skipStartupSplash = new SkipStartupSplash();

        private FasterFadeInTweak fasterFadeInTweak = new FasterFadeInTweak();

        private ShowDamageNumbersAdventureTweak showDamageNumbersAdventureTweak = new ShowDamageNumbersAdventureTweak();
        private ShowPublicTeamNotificationsTweak showPublicTeamNotificationsTweak = new ShowPublicTeamNotificationsTweak();
        private ShowFloatingQuestMarkersTweak showFloatingQuestMarkersTweak = new ShowFloatingQuestMarkersTweak();
        private ShowFloatingQuestTextTweak showFloatingQuestTextTweak = new ShowFloatingQuestTextTweak();
        private ShowCompassTweak showCompassTweak = new ShowCompassTweak();
        private EnablePowerArmorHUDTweak enablePowerArmorHUDTweak = new EnablePowerArmorHUDTweak();
        private ShowCrosshairTweak showCrosshairTweak = new ShowCrosshairTweak();
        private ShowOtherPlayersNamesTweak showOtherPlayersNamesTweak = new ShowOtherPlayersNamesTweak();
        private ShowOtherPlayersPingsTweak showOtherPlayersPingsTweak = new ShowOtherPlayersPingsTweak();
        private ActiveEffectsOnHUDTweak activeEffectsOnHUDTweak = new ActiveEffectsOnHUDTweak();
        private CorpseHighlightingTweak corpseHighlightingTweak = new CorpseHighlightingTweak();
        private FloatingQuestMarkersDistanceTweak floatingQuestMarkersDistanceTweak = new FloatingQuestMarkersDistanceTweak();
        private HUDOpacityTweak hudOpacityTweak = new HUDOpacityTweak();
        private BackpackVisibleTweak backpackVisibleTweak = new BackpackVisibleTweak();
        private AskOpenPerkCardPacksTweak askOpenPerkCardPacksTweak = new AskOpenPerkCardPacksTweak();
        private RejectSharedPerksEnabledTweak rejectSharedPerksEnabledTweak = new RejectSharedPerksEnabledTweak();
        private VATSGrenadeMineTargetingModeTweak vatsGrenadeMineTargetingModeTweak = new VATSGrenadeMineTargetingModeTweak();
        private AdvancedModDescriptionsTweak advancedModDescriptionsTweak = new AdvancedModDescriptionsTweak();
        private AutoScrollPipboyItemStatsTweak autoScrollPipboyItemStatsTweak = new AutoScrollPipboyItemStatsTweak();
        private QuickHealStimpakPriorityTweak quickHealStimpakPriorityTweak = new QuickHealStimpakPriorityTweak();
        private ShowCAMPWeatherTweak showCAMPWeatherTweak = new ShowCAMPWeatherTweak();
        
        private EnableQuestTrackNotificationTweak enableQuestTrackNotificationTweak = new EnableQuestTrackNotificationTweak();
        private AutoTrackQuestWhenStartedTweak autoTrackMainQuestWhenStartedTweak = new AutoTrackQuestWhenStartedTweak("Main", "Main");
        private AutoTrackQuestWhenStartedTweak autoTrackSideQuestWhenStartedTweak = new AutoTrackQuestWhenStartedTweak("Side", "Side");
        private AutoTrackQuestWhenStartedTweak autoTrackMiscQuestWhenStartedTweak = new AutoTrackQuestWhenStartedTweak("Misc", "Miscellaneous");
        private AutoTrackQuestWhenStartedTweak autoTrackEventQuestWhenStartedTweak = new AutoTrackQuestWhenStartedTweak("Event", "Event");
        private AutoTrackQuestWhenStartedTweak autoTrackOtherQuestWhenStartedTweak = new AutoTrackQuestWhenStartedTweak("Other", "Daily");

        // Video tab
        private DisplaySizeTweak displaySizeTweak = new DisplaySizeTweak();
        private DisplayModeTweak displayModeTweak = new DisplayModeTweak();
        private PresentIntervalTweak presentIntervalTweak = new PresentIntervalTweak();
        private TopMostWindowTweak topMostWindowTweak = new TopMostWindowTweak();
        private FixHUD4to3RatioTweak fixHUD4to3RatioTweak = new FixHUD4to3RatioTweak();

        // Video tab --> Graphics
        private AntiAliasingTweak antiAliasingTweak = new AntiAliasingTweak();
        private AnisotropicFilteringTweak anisotropicFilteringTweak = new AnisotropicFilteringTweak();
        private TextureQualityPresetTweak textureQualityTweak = new TextureQualityPresetTweak();
        private DepthOfFieldEnabledTweak dofEnabledTweak = new DepthOfFieldEnabledTweak();
        private DepthOfFieldStrengthTweak dofStrengthTweak = new DepthOfFieldStrengthTweak();
        private MotionBlurTweak motionBlurTweak = new MotionBlurTweak();
        private RadialBlurTweak radialBlurTweak = new RadialBlurTweak();
        private LensFlareTweak lensFlareTweak = new LensFlareTweak();
        private AmbientOcclusionTweak ambientOcclusionTweak = new AmbientOcclusionTweak();
        private VolumetricLightingTweak volumetricLightingTweak = new VolumetricLightingTweak();
        private VolumetricLightingQualityTweak volumetricLightingQualityTweak = new VolumetricLightingQualityTweak();

        private DisableAllGoreTweak disableAllGoreTweak = new DisableAllGoreTweak();
        private BloodSplatterEnabledTweak bloodSplatterTweak = new BloodSplatterEnabledTweak();
        private EnableIntenseWeatherEffectsTweak enableIntenseWeatherEffectsTweak = new EnableIntenseWeatherEffectsTweak();
        private EnableMuzzleFlashesTweaks enableMuzzleFlashesTweaks = new EnableMuzzleFlashesTweaks();
        private EnableWeaponImpactEffectsTweak enableWeaponImpactEffectsTweak = new EnableWeaponImpactEffectsTweak();

        private ShadowMapResolutionTweak shadowMapResolutionTweak = new ShadowMapResolutionTweak();
        private ShadowBlurrinessTweak shadowBlurrinessTweak = new ShadowBlurrinessTweak();
        private ShadowDistanceTweak shadowDistanceTweak = new ShadowDistanceTweak();
        //private DirShadowSplitsTweak dirShadowSplitsTweak = new DirShadowSplitsTweak();
        private ShadowQualityPresetTweak shadowQualityTweak = new ShadowQualityPresetTweak();
        private LODFadeOutMultObjectsTweak lodFadeOutMultObjectsTweak = new LODFadeOutMultObjectsTweak();
        private LODFadeOutMultItemsTweak lodFadeOutMultItemsTweak = new LODFadeOutMultItemsTweak();
        private LODFadeOutMultActorsTweak lodFadeOutMultActorsTweak = new LODFadeOutMultActorsTweak();
        private EnableGrassTweak enableGrassTweak = new EnableGrassTweak();
        private GrassFadeDistanceTweak grassFadeDistanceTweak = new GrassFadeDistanceTweak();
        //private BlendSplitDirShadowTweak blendSplitDirShadowTweak = new BlendSplitDirShadowTweak();
        private TAAPostOverlayTweak taaPostOverlayTweak = new TAAPostOverlayTweak();
        private TAAPostSharpenTweak taaPostSharpenTweak = new TAAPostSharpenTweak();
        private ScreenSpaceReflectionsTweak screenSpaceReflectionsTweak = new ScreenSpaceReflectionsTweak();
        //private BloomTweak bloomTweak = new BloomTweak();

        private WaterDisplacementsTweak waterDisplacementsTweak = new WaterDisplacementsTweak();
        private WaterRefractionsTweak waterRefractionsTweak = new WaterRefractionsTweak();
        private WaterReflectionsTweak waterReflectionsTweak = new WaterReflectionsTweak();
        private WaterHiResTweak waterHiResTweak = new WaterHiResTweak();
        private WaterShadowFilterTweak waterShadowFilterTweak = new WaterShadowFilterTweak();
        private WaterFixSSRGlitchTweak waterFixSSRGlitchTweak = new WaterFixSSRGlitchTweak();

        // Audio tab
        private EnableAudioTweak enableAudioTweak = new EnableAudioTweak();
        private PlayMainMenuMusicTweak playMainMenuMusicTweak = new PlayMainMenuMusicTweak();

        private VoiceChatModeTweak voiceChatModeTweak = new VoiceChatModeTweak();
        private VoicePushToTalkEnabledTweak voicePushToTalkEnabledTweak = new VoicePushToTalkEnabledTweak();

        private GeneralSubtitlesTweak generalSubtitlesTweak = new GeneralSubtitlesTweak();
        private DialogueSubtitlesTweak dialogueSubtitlesTweak = new DialogueSubtitlesTweak();
        private ShowDialogueHistoryTweak showDialogueHistoryTweak = new ShowDialogueHistoryTweak();
        private ConversationHistorySizeTweak conversationHistorySizeTweak = new ConversationHistorySizeTweak();

        private MasterVolumeTweak masterVolumeTweak = new MasterVolumeTweak();
        private VivoxVoiceVolumeTweak vivoxVoiceVolumeTweak = new VivoxVoiceVolumeTweak();

        private AudioMenuValTweak val0Tweak = new AudioMenuValTweak("0", "Menu Music");
        private AudioMenuValTweak val1Tweak = new AudioMenuValTweak("1", "World Radios");
        private AudioMenuValTweak val2Tweak = new AudioMenuValTweak("2", "Voice");
        private AudioMenuValTweak val3Tweak = new AudioMenuValTweak("3", "Music");
        private AudioMenuValTweak val4Tweak = new AudioMenuValTweak("4", "Effects");
        private AudioMenuValTweak val5Tweak = new AudioMenuValTweak("5", "Footsteps");
        private AudioMenuValTweak val6Tweak = new AudioMenuValTweak("6", "Pip-Boy Radio");

        // Controls tab
        private MouseSensitivityTweakX mouseSensitivityTweakX = new MouseSensitivityTweakX();
        private MouseSensitivityTweakY mouseSensitivityTweakY = new MouseSensitivityTweakY();
        private GamepadSensitivityTweakX gamepadSensitivityTweakX = new GamepadSensitivityTweakX();
        private GamepadSensitivityTweakY gamepadSensitivityTweakY = new GamepadSensitivityTweakY();
        private FixMouseSensitivityTweak fixMouseSensitivityTweak = new FixMouseSensitivityTweak();
        private FixAimSensitivityTweak fixAimSensitivityTweak = new FixAimSensitivityTweak();
        private MouseInvertXTweak mouseInvertXTweak = new MouseInvertXTweak();
        private MouseInvertYTweak mouseInvertYTweak = new MouseInvertYTweak();
        private ToggleAimTweak toggleAimTweak = new ToggleAimTweak();
        private GamepadEnableTweak gamepadEnableTweak = new GamepadEnableTweak();
        private EnableGamepadRumbleTweak enableGamepadRumbleTweak = new EnableGamepadRumbleTweak();
        private AimAssistTweak aimAssistTweak = new AimAssistTweak();

        // Camera tab
        private FieldOfViewTweak fovTweak = new FieldOfViewTweak();
        private FOV3rdADSTweak fov3rdADSTweak = new FOV3rdADSTweak();
        private FOV1stPersonTweak fov1stPersonTweak = new FOV1stPersonTweak();

        private EnableCameraShakeTweak enableCameraShakeTweak = new EnableCameraShakeTweak();

        private VanityModeMinDistTweak vanityModeMinDistTweak = new VanityModeMinDistTweak();
        private VanityModeMaxDistTweak vanityModeMaxDistTweak = new VanityModeMaxDistTweak();
        private PitchZoomOutMaxDistTweak pitchZoomOutMaxDistTweak = new PitchZoomOutMaxDistTweak();

        private DisableAutoVanityModeTweak disableAutoVanityModeTweak = new DisableAutoVanityModeTweak();
        private ForceAutoVanityModeTweak forceAutoVanityModeTweak = new ForceAutoVanityModeTweak();

        private SelfieModeRangeTweak selfieModeRangeTweak = new SelfieModeRangeTweak();
        private SelfieCameraTranslationSpeedTweak selfieCameraTranslationSpeedTweak = new SelfieCameraTranslationSpeedTweak();
        private SelfieCameraRotationSpeedTweak selfieCameraRotationSpeedTweak = new SelfieCameraRotationSpeedTweak();

        private WorkshopFreeCameraControlsHoldToggleTweak workshopFreeCameraControlsHoldToggleTweak = new WorkshopFreeCameraControlsHoldToggleTweak();
        private WorkshopFreeCameraRotationSpeedTweak workshopFreeCameraRotationSpeedTweak = new WorkshopFreeCameraRotationSpeedTweak();
        private WorkshopFreeCameraTranslationSpeedTweak workshopFreeCameraTranslationSpeedTweak = new WorkshopFreeCameraTranslationSpeedTweak();
        private WorkshopStartAtPreviousFreeCameraLocationTweak workshopStartAtPreviousFreeCameraLocationTweak = new WorkshopStartAtPreviousFreeCameraLocationTweak();
        private WorkshopStartInFreeCameraTweak workshopStartInFreeCameraTweak = new WorkshopStartInFreeCameraTweak();

        private ApplyCameraNodeAnimationsTweak applyCameraNodeAnimationsTweak = new ApplyCameraNodeAnimationsTweak();
        private CameraOverShoulderPosXTweak cameraOverShoulderPosXTweak = new CameraOverShoulderPosXTweak();
        private CameraOverShoulderPosZTweak cameraOverShoulderPosZTweak = new CameraOverShoulderPosZTweak();
        private CameraOverShoulderCombatPosXTweak cameraOverShoulderCombatPosXTweak = new CameraOverShoulderCombatPosXTweak();
        private CameraOverShoulderCombatPosZTweak cameraOverShoulderCombatPosZTweak = new CameraOverShoulderCombatPosZTweak();
        private CameraOverShoulderCombatAddYTweak cameraOverShoulderCombatAddYTweak = new CameraOverShoulderCombatAddYTweak();
        private CameraOverShoulderMeleeCombatPosXTweak cameraOverShoulderMeleeCombatPosXTweak = new CameraOverShoulderMeleeCombatPosXTweak();
        private CameraOverShoulderMeleeCombatPosZTweak cameraOverShoulderMeleeCombatPosZTweak = new CameraOverShoulderMeleeCombatPosZTweak();
        private CameraOverShoulderMeleeCombatAddYTweak cameraOverShoulderMeleeCombatAddYTweak = new CameraOverShoulderMeleeCombatAddYTweak();

        // Accessibility tab
        private AlternativeNoteViewBackgroundColorTweak alternativeNoteViewBackgroundColorTweak = new AlternativeNoteViewBackgroundColorTweak();
        private AlternativeNoteViewTextColorTweak alternativeNoteViewTextColorTweak = new AlternativeNoteViewTextColorTweak();
        private MessageWindowFadeAmountTweak messageWindowFadeAmountTweak = new MessageWindowFadeAmountTweak();
        private MessageWindowFadeTimeTweak messageWindowFadeTimeTweak = new MessageWindowFadeTimeTweak();
        private ScreenNarrationEnabledTweak screenNarrationEnabledTweak = new ScreenNarrationEnabledTweak();
        private ScreenNarrationVoiceTypeTweak screenNarrationVoiceTypeTweak = new ScreenNarrationVoiceTypeTweak();
        private ShowAccessibilityScreenOnStartTweak showAccessibilityScreenOnStartTweak = new ShowAccessibilityScreenOnStartTweak();
        private SingleButtonNotificationCancelTweak singleButtonNotificationCancelTweak = new SingleButtonNotificationCancelTweak();
        private SpeechToTextTweak speechToTextTweak = new SpeechToTextTweak();
        private UseLargeEasyReadTextTweak useLargeEasyReadTextTweak = new UseLargeEasyReadTextTweak();
    }
}
