using NUnit.Framework;

namespace AssetTool.Test.External.UAssetAPITest
{
    public class UAssetApiTests : TestBase
    {
        string BaseDir = "Data\\InputCooked";

        [SetUp]
        public void Setup()
        {
            AppConfig.DebugSaveUnitTest = false;
        }

        #region uasset files

        //UE 5.3
        [Test] public void UE53_AmmoDataTable() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_3\\RON\\AmmoDataTable.uasset", fileVersion: FileVersions["UE5_3"]));
        [Test] public void UE53_DefaultRecorderBoneCompression() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_3\\Engine\\DefaultRecorderBoneCompression.uasset", fileVersion: FileVersions["UE5_3"]));

        //UE 5.4
        [Test] public void UE54_ApprenticeBlacksmithNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeBlacksmithNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeCarpenterNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeCarpenterNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeEngineerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeEngineerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeFarmerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeFarmerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeHealerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeHealerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeInkeeperNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeInkeeperNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeLabourerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeLabourerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeWeaverNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeWeaverNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_ApprenticeWoodsmanNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\ApprenticeWoodsmanNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_BP_CubePawn() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\BlankGame\\BP_CubePawn.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_BP_Table_Lamp() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Billiards\\BP_Table_Lamp.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_DA_DailyGiftList() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\TheForeverWinter\\DA_DailyGiftList.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_HighNoTraitsVillagerIdleNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\HighNoTraitsVillagerIdleNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_HighVillagerIdleNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\HighSkill\\HighVillagerIdleNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_LowBeggarNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\LowSkill\\LowBeggarNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_LowVillagerIdleNoTraitsNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\LowSkill\\LowVillagerIdleNoTraitsNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_LowVillagerIdleNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\LowSkill\\LowVillagerIdleNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_M_Cube() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\BlankGame\\M_Cube.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_MediumNoTraitsVillagerIdleNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\MediumNoTraitsVillagerIdleNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_MediumVillagerIdleNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\MediumVillagerIdleNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_MI_BlueCube() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\BlankGame\\MI_BlueCube.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceBlacksmithNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceBlacksmithNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceCarpenterNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceCarpenterNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceEngineerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceEngineerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceFarmerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceFarmerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceHealerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceHealerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceInkeeperNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceInkeeperNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceLabourerNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceLabourerNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceWeaverNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceWeaverNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_NoviceWoodsmanNPCTemplate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\Bellwright\\Content\\Mist\\Characters\\NPC\\Villager\\MediumSkill\\NoviceWoodsmanNPCTemplate.uasset", fileVersion: FileVersions["UE5_4"]));
        [Test] public void UE54_SM_BlueCube() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_4\\BlankGame\\SM_BlueCube.uasset", fileVersion: FileVersions["UE5_4"]));



        //[Test] public void ABP_SMG_A() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestJson\\ABP_SMG_A.uasset.uasset", ""));
        //[Test] public void AlternateStartActor() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestCustomProperty\\AlternateStartActor.uasset", ""));
        //[Test] public void AM_MedChar_Reload_RingLauncher() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\MidAir\\AM_MedChar_Reload_RingLauncher.uasset", ""));
        //[Test] public void as_mt_base() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestMaterials\\as_mt_base.uasset", ""));
        //[Test] public void Assault_M1A1Thompson_WW2_DrumSuppressor() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\VERSIONED\\Assault_M1A1Thompson_WW2_DrumSuppressor.uasset", ""));
        //[Test] public void AssetDatabase_AutoGenerated() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestJson\\AssetDatabase_AutoGenerated.uasset", ""));
        //[Test] public void Augment_BroadBrush() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Astroneer\\Augment_BroadBrush.uasset", ""));
        //[Test] public void BIOME_AzureWeald() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestDuplicateNameMapEntries\\BIOME_AzureWeald.uasset", ""));
        //[Test] public void BP_BuildObject_BaseCampWorkHard() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palworld\\BP_BuildObject_BaseCampWorkHard.uasset", ""));
        //[Test] public void BP_DetPack_Charge() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUnknownProperties\\BP_DetPack_Charge.uasset", ""));
        //[Test] public void BP_InteractableBox() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palworld\\BP_InteractableBox.uasset", ""));
        //[Test] public void BP_MimicCrate() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\ToTheCore\\BP_MimicCrate.uasset", ""));
        //[Test] public void BP_TekkenPlayer_Modular() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Tekken\\BP_TekkenPlayer_Modular.uasset", ""));
        //[Test] public void CharacterCostume_chr0001_DataTable() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\StarlitSeason\\CharacterCostume_chr0001_DataTable.uasset", ""));
        //[Test] public void ChroniclerpathCutscene() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\MutantYearZero\\ChroniclerpathCutscene.uasset", ""));
        //[Test] public void DebugMenu() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Astroneer\\DebugMenu.uasset", ""));
        //[Test] public void DT_FishConfigs() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palia\\DT_FishConfigs.uasset", ""));
        //[Test] public void DT_FishingLevelConfigs() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palia\\DT_FishingLevelConfigs.uasset", ""));
        //[Test] public void DT_FishingLevelSegmentConfigs() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palia\\DT_FishingLevelSegmentConfigs.uasset", ""));
        //[Test] public void DT_FishingLootConfigs() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palia\\DT_FishingLootConfigs.uasset", ""));
        //[Test] public void DT_FishingNibbleConfig() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palia\\DT_FishingNibbleConfig.uasset", ""));
        //[Test] public void DT_FishingNibbleLevelConfig() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palia\\DT_FishingNibbleLevelConfig.uasset", ""));
        //[Test] public void DT_ShopConfigs() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Palia\\DT_ShopConfigs.uasset", ""));
        //[Test] public void DV_ItemDescription() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\TheBeastInside\\DV_ItemDescription.uasset", ""));
        //[Test] public void ex02_IGC_03_Subtitle() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestACE7\\ex02_IGC_03_Subtitle.uasset", ""));
        //[Test] public void FinalCinematic() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Liminal\\FinalCinematic.uasset", ""));
        //[Test] public void FixedStaff() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\F1Manager2023\\FixedStaff.uasset", ""));
        //[Test] public void InCathedralCinematic() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Liminal\\InCathedralCinematic.uasset", ""));
        //[Test] public void InventoryStruct() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Liminal\\InventoryStruct.uasset", ""));
        //[Test] public void ItemInfo() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\LiesOfP\\ItemInfo.uasset", ""));
        //[Test] public void Items() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestJson\\Items.uasset", ""));
        //[Test] public void LargeResourceCanister_IT() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Astroneer\\LargeResourceCanister_IT.uasset", ""));
        //[Test] public void LiftStruct() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\TheOccupation\\LiftStruct.uasset", ""));
        //[Test] public void M_COM_DetailMaster_B() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestMaterials\\M_COM_DetailMaster_B.uasset", ""));
        //[Test] public void MainChar_BellySlice_BR() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\MISC_426\\MainChar_BellySlice_BR.uasset", ""));
        //[Test] public void MainCut() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\MutantYearZero\\MainCut.uasset", ""));
        //[Test] public void MF_CharacterEffects() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\TheBeastInside\\MF_CharacterEffects.uasset", ""));
        //[Test] public void MGA_HeavyWeapon_Parent() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestJson\\MGA_HeavyWeapon_Parent.uasset", ""));
        //[Test] public void MI_F1_Driver_LoganSargeant_Visor() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\F1Manager2023\\MI_F1_Driver_LoganSargeant_Visor.uasset", ""));
        //[Test] public void MP00_GateTutorial() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\SnakePass\\MP00_GateTutorial.uasset", ""));
        //[Test] public void MP00_Intro() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\SnakePass\\MP00_Intro.uasset", ""));
        //[Test] public void NewDataTable() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestUE5_1\\UnderlyingEnumTypes\\NewDataTable.uasset", ""));
        //[Test] public void OC_Gatling_DamageB_B() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestImproperNameMapHashes\\OC_Gatling_DamageB_B.uasset", ""));
        //[Test] public void PB_DT_ItemMaster() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Bloodstained\\PB_DT_ItemMaster.uasset", ""));
        //[Test] public void PB_DT_RandomizerRoomCheck() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Bloodstained\\PB_DT_RandomizerRoomCheck.uasset", ""));
        //[Test] public void plwp_6aam_a0() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestACE7\\plwp_6aam_a0.uasset", ""));
        //[Test] public void RaceSimDataAsset() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestJson\\RaceSimDataAsset.uasset", ""));
        //[Test] public void RecieverPneumaticTerminals() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\TheOccupation\\RecieverPneumaticTerminals.uasset", ""));
        //[Test] public void ResourceProgressCurve() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Astroneer\\ResourceProgressCurve.uasset", ""));
        //[Test] public void Roboto() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Biodigital\\Roboto.uasset", ""));
        //[Test] public void RobotoTiny() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\Biodigital\\RobotoTiny.uasset", ""));
        //[Test] public void SK_Inner_Female1() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\CodeVein\\SK_Inner_Female1.uasset", ""));
        //[Test] public void SkillHitInfo() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\LiesOfP\\SkillHitInfo.uasset", ""));
        //[Test] public void SkillInfo() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\LiesOfP\\SkillInfo.uasset", ""));
        //[Test] public void StaffPhotoData() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\F1Manager2023\\StaffPhotoData.uasset", ""));
        //[Test] public void TestActorBP() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestEditorAssets\\TestActorBP.uasset", ""));
        //[Test] public void TestMaterial() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestEditorAssets\\TestMaterial.uasset", ""));
        //[Test] public void TestSoundClass() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestEditorAssets\\TestSoundClass.uasset", ""));
        //[Test] public void TurboAcres_Environment() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestJson\\TurboAcres_Environment.uasset", ""));
        //[Test] public void WBP_PartyPlayerRow() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestManyAssets\\MidAir\\WBP_PartyPlayerRow.uasset", ""));
        //[Test] public void WPN_LockOnRifle() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestJson\\WPN_LockOnRifle.uasset", ""));
        //[Test] public void wtf() => Assert.That(AssetConverter.RebuildAssetFast($"{BaseDir}\\UAssetAPI\\TestCustomSerializationStructsInMap\\wtf.uasset", ""));
        #endregion
    }
}
