namespace AssetTool.Test
{
    public class DataTest : TestBase
    {
        public DataTest() => GlobalNames.Clear();

        [Fact] public void OK_FogBrightnessLUT() => Assert.True(StructWriter.RebuildAssetInMemory("FogBrightnessLUT"));
        [Fact] public void OK_SunlightColorLUT() => Assert.True(StructWriter.RebuildAssetInMemory("SunlightColorLUT"));
        [Fact] public void OK_M_LightStage_Skybox_Black() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Skybox_Black"));
        [Fact] public void OK_S_Endereco() => Assert.True(StructWriter.RebuildAssetInMemory("S_Endereco"));
        [Fact] public void OK_M_LightStage_Arrows() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Arrows"));
        [Fact] public void OK_M_LightStage_Skybox_HDRI() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Skybox_HDRI"));
        [Fact] public void OK_Blueprint_Effect_Sparks() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Sparks"));
        [Fact] public void OK_M_LightStage_Skybox_Master() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Skybox_Master"));
        [Fact] public void OK_Blueprint_Effect_Explosion() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Explosion"));
        [Fact] public void OK_Blueprint_Effect_Fire() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Fire"));
        [Fact] public void OK_Blueprint_Effect_Smoke() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Smoke"));
        [Fact] public void OK_Blueprint_Effect_Steam() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Steam"));
        [Fact] public void OK_BP_ThirdPersonCharacter() => Assert.True(StructWriter.RebuildAssetInMemory("BP_ThirdPersonCharacter"));
        [Fact] public void OK_Blueprint_CeilingLight() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_CeilingLight"));
        [Fact] public void OK_Blueprint_WallSconce() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_WallSconce"));
        [Fact] public void OK_SM_Arrows() => Assert.True(StructWriter.RebuildAssetInMemory("SM_Arrows"));
        [Fact] public void OK_Skybox() => Assert.True(StructWriter.RebuildAssetInMemory("Skybox"));
        [Fact] public void BP_LightStudio() => Assert.True(StructWriter.RebuildAssetInMemory("BP_LightStudio"));
    }
}