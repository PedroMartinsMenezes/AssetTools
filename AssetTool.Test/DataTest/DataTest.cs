namespace AssetTool.Test
{
    public class DataTest : TestBase
    {
        public DataTest() => GlobalNames.Clear();

        [Fact] public void OK_FogBrightnessLUT() => Assert.True(StructWriter.RebuildAsset("FogBrightnessLUT"));
        [Fact] public void OK_SunlightColorLUT() => Assert.True(StructWriter.RebuildAsset("SunlightColorLUT"));
        [Fact] public void OK_M_LightStage_Skybox_Black() => Assert.True(StructWriter.RebuildAsset("M_LightStage_Skybox_Black"));
        [Fact] public void OK_S_Endereco() => Assert.True(StructWriter.RebuildAsset("S_Endereco"));
        [Fact] public void OK_M_LightStage_Arrows() => Assert.True(StructWriter.RebuildAsset("M_LightStage_Arrows"));
        [Fact] public void OK_M_LightStage_Skybox_HDRI() => Assert.True(StructWriter.RebuildAsset("M_LightStage_Skybox_HDRI"));
        [Fact] public void OK_Blueprint_Effect_Sparks() => Assert.True(StructWriter.RebuildAsset("Blueprint_Effect_Sparks"));
        [Fact] public void OK_M_LightStage_Skybox_Master() => Assert.True(StructWriter.RebuildAsset("M_LightStage_Skybox_Master"));
        [Fact] public void OK_Blueprint_Effect_Explosion() => Assert.True(StructWriter.RebuildAsset("Blueprint_Effect_Explosion"));
        [Fact] public void OK_Blueprint_Effect_Fire() => Assert.True(StructWriter.RebuildAsset("Blueprint_Effect_Fire"));
        [Fact] public void OK_Blueprint_Effect_Smoke() => Assert.True(StructWriter.RebuildAsset("Blueprint_Effect_Smoke"));
        [Fact] public void OK_Blueprint_Effect_Steam() => Assert.True(StructWriter.RebuildAsset("Blueprint_Effect_Steam"));
        [Fact] public void OK_BP_ThirdPersonCharacter() => Assert.True(StructWriter.RebuildAsset("BP_ThirdPersonCharacter"));
        [Fact] public void OK_Blueprint_CeilingLight() => Assert.True(StructWriter.RebuildAsset("Blueprint_CeilingLight"));
        [Fact] public void OK_Blueprint_WallSconce() => Assert.True(StructWriter.RebuildAsset("Blueprint_WallSconce"));

        [Fact] public void SM_Arrows() => Assert.True(StructWriter.RebuildAsset("SM_Arrows"));
        [Fact] public void Skybox() => Assert.True(StructWriter.RebuildAsset("Skybox"));
        [Fact] public void BP_LightStudio() => Assert.True(StructWriter.RebuildAsset("BP_LightStudio"));
    }
}