namespace AssetTool.Test
{
    public class DataTest : TestBase
    {
        public DataTest() => GlobalNames.Clear();

        [Fact] public void FogBrightnessLUT() => Assert.True(StructWriter.RebuildAssetInMemory("FogBrightnessLUT"));
        [Fact] public void SunlightColorLUT() => Assert.True(StructWriter.RebuildAssetInMemory("SunlightColorLUT"));
        [Fact] public void M_LightStage_Skybox_Black() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Skybox_Black"));
        [Fact] public void S_Endereco() => Assert.True(StructWriter.RebuildAssetInMemory("S_Endereco"));
        [Fact] public void M_LightStage_Arrows() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Arrows"));
        [Fact] public void M_LightStage_Skybox_HDRI() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Skybox_HDRI"));
        [Fact] public void Blueprint_Effect_Sparks() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Sparks"));
        [Fact] public void M_LightStage_Skybox_Master() => Assert.True(StructWriter.RebuildAssetInMemory("M_LightStage_Skybox_Master"));
        [Fact] public void Blueprint_Effect_Explosion() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Explosion"));
        [Fact] public void Blueprint_Effect_Fire() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Fire"));
        [Fact] public void Blueprint_Effect_Smoke() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Smoke"));
        [Fact] public void Blueprint_Effect_Steam() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_Effect_Steam"));
        [Fact] public void BP_ThirdPersonCharacter() => Assert.True(StructWriter.RebuildAssetInMemory("BP_ThirdPersonCharacter"));
        [Fact] public void Blueprint_CeilingLight() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_CeilingLight"));
        [Fact] public void Blueprint_WallSconce() => Assert.True(StructWriter.RebuildAssetInMemory("Blueprint_WallSconce"));
        [Fact] public void SM_Arrows() => Assert.True(StructWriter.RebuildAssetInMemory("SM_Arrows"));
        [Fact] public void Skybox() => Assert.True(StructWriter.RebuildAssetInMemory("Skybox"));
        [Fact] public void BP_LightStudio() => Assert.True(StructWriter.RebuildAssetInMemory("BP_LightStudio"));
    }
}