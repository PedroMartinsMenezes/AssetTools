using NUnit.Framework;

namespace AssetTool.Test
{
    public class DataTest : TestBase
    {
        //public DataTest() => GlobalNames.Clear();

        [Test] public void FogBrightnessLUT() => Assert.That(StructWriter.RebuildAsset("FogBrightnessLUT"));
        [Test] public void SunlightColorLUT() => Assert.That(StructWriter.RebuildAsset("SunlightColorLUT"));
        [Test] public void M_LightStage_Skybox_Black() => Assert.That(StructWriter.RebuildAsset("M_LightStage_Skybox_Black"));
        [Test] public void S_Endereco() => Assert.That(StructWriter.RebuildAsset("S_Endereco"));
        [Test] public void M_LightStage_Arrows() => Assert.That(StructWriter.RebuildAsset("M_LightStage_Arrows"));
        [Test] public void M_LightStage_Skybox_HDRI() => Assert.That(StructWriter.RebuildAsset("M_LightStage_Skybox_HDRI"));
        [Test] public void Blueprint_Effect_Sparks() => Assert.That(StructWriter.RebuildAsset("Blueprint_Effect_Sparks"));
        [Test] public void M_LightStage_Skybox_Master() => Assert.That(StructWriter.RebuildAsset("M_LightStage_Skybox_Master"));
        [Test] public void Blueprint_Effect_Explosion() => Assert.That(StructWriter.RebuildAsset("Blueprint_Effect_Explosion"));
        [Test] public void Blueprint_Effect_Fire() => Assert.That(StructWriter.RebuildAsset("Blueprint_Effect_Fire"));
        [Test] public void Blueprint_Effect_Smoke() => Assert.That(StructWriter.RebuildAsset("Blueprint_Effect_Smoke"));
        [Test] public void Blueprint_Effect_Steam() => Assert.That(StructWriter.RebuildAsset("Blueprint_Effect_Steam"));
        [Test] public void BP_ThirdPersonCharacter() => Assert.That(StructWriter.RebuildAsset("BP_ThirdPersonCharacter"));
        [Test] public void Blueprint_CeilingLight() => Assert.That(StructWriter.RebuildAsset("Blueprint_CeilingLight"));
        [Test] public void Blueprint_WallSconce() => Assert.That(StructWriter.RebuildAsset("Blueprint_WallSconce"));
        [Test] public void SM_Arrows() => Assert.That(StructWriter.RebuildAsset("SM_Arrows"));
        [Test] public void Skybox() => Assert.That(StructWriter.RebuildAsset("Skybox"));
        [Test] public void BP_LightStudio() => Assert.That(StructWriter.RebuildAsset("BP_LightStudio"));
    }
}